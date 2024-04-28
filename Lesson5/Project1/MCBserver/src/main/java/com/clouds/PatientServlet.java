package com.clouds;

import org.json.JSONArray;
import org.json.JSONObject;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.sql.Date;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Locale;

@WebServlet("/patient/*")
public class PatientServlet extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            DataBase.connect();
            response.setCharacterEncoding("UTF-8");
            String id = request.getPathInfo().substring(1);
            if(id.equals("all")){
                JSONArray jsonArray = DataBase.GetAllPatients();
                response.getWriter().print(jsonArray);
            }
            else{
                if (!id.isEmpty()) {
                    if (DataBase.GetPatientByID(id) != null) {
                        JSONObject jsonObject = DataBase.GetPatientByID(id);
                        response.getWriter().print(jsonObject);
                    } else {
                        response.setStatus(HttpServletResponse.SC_NOT_FOUND);
                        response.getWriter().print("Patient not found");
                    }
                } else {
                    response.setStatus(HttpServletResponse.SC_BAD_REQUEST);
                    response.getWriter().print("The id is not in the address");
                }
            }
            DataBase.CloseDB();
        } catch (SQLException | ClassNotFoundException e) {
            response.setStatus(HttpServletResponse.SC_INTERNAL_SERVER_ERROR);
            throw new RuntimeException(e);
        }
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            DataBase.connect();
            if (request.getParameter("name") != null &&
                    request.getParameter("surname") != null &&
                    request.getParameter("secondsurname") != null &&
                    request.getParameter("country") != null &&
                    request.getParameter("city") != null &&
                    request.getParameter("dateofbirth") != null &&
                    request.getParameter("gender") != null &&
                    request.getParameter("mkbnumber") != null) {
                Patient patient = new Patient(request.getParameter("name"),
                        request.getParameter("surname"),
                        request.getParameter("secondsurname"),
                        request.getParameter("country"),
                        request.getParameter("city"));
                if(request.getParameter("dateofbirth") != null){
                    patient.setDateOfBirth(new SimpleDateFormat("yyyy-MM-dd").parse(request.getParameter("dateofbirth")));
                }
                patient.setGender(Integer.parseInt(request.getParameter("gender")));
                patient.setMKBnumber(new Disease(request.getParameter("mkbnumber")));
                response.setStatus(HttpServletResponse.SC_OK);
                int id = DataBase.WritePatient(patient);
                response.getWriter().print(id);
            } else {
                response.setStatus(HttpServletResponse.SC_BAD_REQUEST);
                response.getWriter().print("Required form field is missing");
            }
            DataBase.CloseDB();
        } catch (ClassNotFoundException | SQLException e) {
            response.setStatus(HttpServletResponse.SC_INTERNAL_SERVER_ERROR);
            throw new RuntimeException(e);
        } catch (ParseException e) {
            throw new RuntimeException(e);
        }
    }


}
