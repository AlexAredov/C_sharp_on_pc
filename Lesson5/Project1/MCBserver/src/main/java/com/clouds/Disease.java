package com.clouds;

public class Disease {
    private String DiseaseName;
    private String ICDcode;

    public Disease(String diseaseName, String iCDcode) {
        DiseaseName = diseaseName;
        ICDcode = iCDcode;
    }

    public Disease(String iCDcode) {
        ICDcode = iCDcode;
    }

    public String getICDcode() {
        return ICDcode;
    }
    public void setICDcode(String ICDcode) {
        this.ICDcode = ICDcode;
    }

    public String getDiseaseName() {
        return DiseaseName;
    }
    public void setDiseaseName(String diseaseName) {
        DiseaseName = diseaseName;
    }
}
