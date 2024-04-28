package com.clouds;

import org.json.JSONArray;
import org.json.JSONObject;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet("/MKB/*")
public class MKBservlet extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            DataBase.connect();
            response.setCharacterEncoding("UTF-8");
            String code = request.getPathInfo().substring(1);
            if(code.equals("all")){
                JSONArray jsonArray = DataBase.GetAllMKB();
                response.getWriter().print(jsonArray);
            }
            else{
                if (!code.isEmpty()) {
                    if (DataBase.GetByCode(code) != null) {
                        JSONObject jsonObject = DataBase.GetByCode(code);
                        response.getWriter().print(jsonObject);
                    } else {
                        response.setStatus(HttpServletResponse.SC_NOT_FOUND);
                        response.getWriter().print("Disease not found");
                    }
                } else {
                    response.setStatus(HttpServletResponse.SC_BAD_REQUEST);
                    response.getWriter().print("The MKB disease code is not in the address");
                }
            }
            DataBase.CloseDB();
        } catch (SQLException | ClassNotFoundException e) {
            response.setStatus(HttpServletResponse.SC_INTERNAL_SERVER_ERROR);
            throw new RuntimeException(e);
        }
    }
}
