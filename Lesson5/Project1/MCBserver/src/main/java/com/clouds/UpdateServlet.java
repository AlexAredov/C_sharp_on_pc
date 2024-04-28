package com.clouds;

import org.json.JSONObject;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;

@WebServlet("/update/*")
public class UpdateServlet extends HttpServlet {
    @Override
    protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String method = req.getMethod();
        if (!method.equals("PATCH")) {
            super.service(req, resp);
        }
        this.doPatch(req, resp);
    }

    protected void doPatch(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        //response.getWriter().print("PATCH");
        response.setCharacterEncoding("UTF-8");
        DateFormat format = new SimpleDateFormat("yyyy-MM-dd");
        try {
            DataBase.connect();
            String id = request.getPathInfo().substring(1);
            if (!id.isEmpty()) {
                if (DataBase.GetPatientByID(id) != null) {
                    Patient patient = new Patient(request.getParameter("name"),
                            request.getParameter("surname"),
                            request.getParameter("secondsurname"),
                            request.getParameter("country"),
                            request.getParameter("city"));
                    if(request.getParameter("dateofbirth") != null){
                        patient.setDateOfBirth(new SimpleDateFormat("yyyy-MM-dd").parse(request.getParameter("dateofbirth")));
                    }
                    if(request.getParameter("gender") != null){
                        patient.setGender(Integer.parseInt(request.getParameter("gender")));
                    }
                    if(request.getParameter("mkbnumber") != null){
                        patient.setMKBnumber(new Disease(request.getParameter("mkbnumber")));
                    }
                    DataBase.PatchPatient(id, patient);
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
            DataBase.CloseDB();
        } catch (SQLException | ClassNotFoundException e) {
            response.setStatus(HttpServletResponse.SC_INTERNAL_SERVER_ERROR);
            throw new RuntimeException(e);
        } catch (ParseException e) {
            throw new RuntimeException(e);
        }
    }
}
