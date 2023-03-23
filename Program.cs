using constructor5;

public static class programm
{

    public static void Main()
    {
        doctor doctor1= new doctor();
        
        doctor doctor2 = new doctor(11, "swapnil","mbbs");
        doctor doctor3 = new doctor(12, " arjun", "bds");
        doctor doctor4 = new doctor(doctor3);

        doctor1.showdeta();
        doctor2.showdeta();
        doctor3.showdeta();
        doctor4.showdeta();
       

    }
}