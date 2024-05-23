package com.clouds;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.UnsupportedEncodingException;
import java.sql.*;
import java.text.DateFormat;
import java.text.SimpleDateFormat;

public class DataBase {

    public static Connection connection;
    public static Statement statement;
    public static ResultSet resultSet;

    public DataBase() {
        connection = null;
    }

    public static void connect() throws ClassNotFoundException, SQLException {
        connection = null;
        Class.forName("org.sqlite.JDBC");
        //connection = DriverManager.getConnection("jdbc:sqlite:/Users/alex_aredov/IdeaProjects/MCBserver/identifier.sqlite");
        connection = DriverManager.getConnection("jdbc:sqlite:C:/Users/aared/OneDrive/Документы/GitHub/C_sharp_on_pc/Lesson5/Project1/MCBserver/identifier.sqlite");
        //connection = DriverManager.getConnection("jdbc:sqlite:/Users/alex_aredov/Documents/GitHub/C_sharp_on_pc/Lesson5/Project1/MCBserver/identifier.sqlite");
        statement = connection.createStatement();
    }


    public static JSONObject GetByCode(String codeNew) throws SQLException, UnsupportedEncodingException {
        statement = connection.createStatement();
        ResultSet resultSetCode = statement.executeQuery("SELECT * FROM \"MKB_directory\" WHERE \"ICD_code\"=\"" + codeNew + "\";");
        if (resultSetCode.next()) {
            return formResultToJSONdisease(resultSetCode);
        } else {
            return null;
        }
    }

    private static JSONObject formResultToJSONdisease(ResultSet resultSet) throws SQLException, UnsupportedEncodingException {
        JSONObject jsonObject = new JSONObject();
        Disease disease = new Disease(resultSet.getString("ICD_code"),
                resultSet.getString("Disease_name"));
        jsonObject.put("ICD_code", disease.getICDcode());
        jsonObject.put("Disease_name", disease.getDiseaseName());
        return jsonObject;
    }

    private static JSONObject formResultToJSONpatient(ResultSet resultSet) throws SQLException, UnsupportedEncodingException {
        JSONObject jsonObject = new JSONObject();
        Patient patient = new Patient(resultSet.getInt("ID"),
                resultSet.getString("Name"),
                resultSet.getString("Surname"),
                resultSet.getString("SecondSurname"),
                resultSet.getDate("DateOfBirth"),
                resultSet.getInt("Gender"),
                resultSet.getString("Country"),
                resultSet.getString("City"),
                new Disease(resultSet.getString("MKBnumber")));
        jsonObject.put("ID", patient.getId());
        jsonObject.put("Name", patient.getName());
        jsonObject.put("Surname", patient.getSurname());
        jsonObject.put("SecondSurname", patient.getSecondSurname());
        jsonObject.put("DateOfBirth", patient.getDateOfBirth());
        jsonObject.put("Gender", patient.getGender());
        jsonObject.put("Country", patient.getCountry());
        jsonObject.put("City", patient.getCity());
        jsonObject.put("MKBnumber", patient.getMKBnumber().getICDcode());
        return jsonObject;
    }

    public static JSONArray GetAllMKB() throws SQLException, UnsupportedEncodingException {
        statement = connection.createStatement();
        resultSet = statement.executeQuery("SELECT * FROM \"MKB_directory\"");
        JSONArray jsonArray = new JSONArray();
        while(resultSet.next()) {
            jsonArray.put(formResultToJSONdisease(resultSet));
        }
        return jsonArray;
    }

    public static JSONArray GetAllPatients() throws SQLException, UnsupportedEncodingException {
        statement = connection.createStatement();
        resultSet = statement.executeQuery("SELECT * FROM \"Patients\"");
        JSONArray jsonArray = new JSONArray();
        while(resultSet.next()) {
            jsonArray.put(formResultToJSONpatient(resultSet));
        }
        return jsonArray;
    }

    public static JSONObject GetPatientByID(String id) throws SQLException, UnsupportedEncodingException {
        statement = connection.createStatement();
        ResultSet resultSetId = statement.executeQuery("SELECT * FROM \"Patients\" WHERE \"ID\"=" + Integer.parseInt(id) + ";");
        if (resultSetId.next()) {
            return formResultToJSONpatient(resultSetId);
        } else {
            return null;
        }
    }

    public static void PatchPatient(String id, Patient patient) throws SQLException {
        String sql_start = "UPDATE \"Patients\" SET ";
        String sql_mid = "";
        int f = 0;
        if(patient.getName() != null){
            f = 1;
            sql_mid += "\"Name\" = \"" + patient.getName() + "\", ";
        }
        if (patient.getSurname() != null){
            f = 1;
            sql_mid += "\"Surname\" = \"" + patient.getSurname() + "\", ";
        }
        if (patient.getSecondSurname() != null){
            f = 1;
            sql_mid += "\"SecondSurname\" = \"" + patient.getSecondSurname() + "\", ";
        }
        if (patient.getDateOfBirth() != null){
            f = 1;
            DateFormat format = new SimpleDateFormat("yyyy-MM-dd");
            sql_mid += "\"DateOfBirth\" = \"" + patient.getDateOfBirth().getTime()  + "\", ";
        }
        if (patient.getCountry() != null){
            f = 1;
            sql_mid += "\"Country\" = \"" + patient.getCountry() + "\", ";
        }
        if (patient.getCity() != null){
            f = 1;
            sql_mid += "\"City\" = \"" + patient.getCity() + "\", ";
        }
        if (patient.getMKBnumber() != null){
            f = 1;
            sql_mid += "\"MKBnumber\" = \"" + patient.getMKBnumber().getICDcode() + "\", ";
        }
        if (patient.getGender() != 3){
            f = 1;
            sql_mid += "\"Gender\" = \"" + patient.getGender() + "\" ";
        }
        String sql_finish = "WHERE \"ID\"=\"" + id + "\";";
        System.out.println(sql_start + sql_mid + sql_finish);
        if(f == 1){
            statement.execute(sql_start + sql_mid + sql_finish);
        }
    }

    public static int WritePatient(Patient patient) {
        try {
            String sql = "INSERT INTO \"Patients\" ('Name', 'Surname', 'SecondSurname', 'DateOfBirth', 'MKBnumber', 'City', 'Country', 'Gender') " +
                    "VALUES (\"" + patient.getName() + "\",\"" + patient.getSurname() + "\",\"" + patient.getSecondSurname() + "\",\"" +
                    patient.getDateOfBirth().getTime() + "\",\"" + patient.getMKBnumber().getICDcode() + "\",\"" + patient.getCity() + "\",\"" +
                    patient.getCountry() + "\",\"" + patient.getGender() + "\");";
            statement.execute(sql);
            return statement.getGeneratedKeys().getInt(1);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void DeletePatient(int id) {
        try {
            String sql = "DELETE FROM \"Patients\"" + "WHERE \"ID\"=\"" + id + "\";";
            statement.execute(sql);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void CloseDB() {
        try {
            connection.close();
            statement.close();
            resultSet.close();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
