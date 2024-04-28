package com.clouds;

import javax.xml.crypto.Data;
import java.util.Date;

public class Patient {
    private int id;
    private String name;
    private String surname;
    private String secondSurname;
    private Date dateOfBirth = null;
    private int gender = 3;
    private String country;
    private String city;
    private Disease MKBnumber = null;

    public Patient(int id, String name, String surname, String secondSurname, Date dateOfBirth, int gender, String country, String city, Disease MKBnumber) {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.secondSurname = secondSurname;
        this.dateOfBirth = dateOfBirth;
        this.gender = gender;
        this.country = country;
        this.city = city;
        this.MKBnumber = MKBnumber;
    }

    public Patient(String name, String surname, String secondSurname, String country, String city) {
        this.name = name;
        this.surname = surname;
        this.secondSurname = secondSurname;
        this.country = country;
        this.city = city;
    }

    public int getId() {
        return id;
    }

    public String getSecondSurname() {
        return secondSurname;
    }
    public void setSecondSurname(String secondSurname) {
        this.secondSurname = secondSurname;
    }

    public Date getDateOfBirth() {
        return dateOfBirth;
    }
    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public int getGender() {
        return gender;
    }
    public void setGender(int gender) {
        this.gender = gender;
    }

    public String getCity() {
        return city;
    }
    public void setCity(String city) {
        this.city = city;
    }

    public Disease getMKBnumber() {
        return MKBnumber;
    }
    public void setMKBnumber(Disease MKBnumber) {
        this.MKBnumber = MKBnumber;
    }

    public String getSurname() {
        return surname;
    }
    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getCountry() {
        return country;
    }
    public void setCountry(String country) {
        this.country = country;
    }

    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
}
