class Person
{
    private string nimi = "N/A";
    private int ika = 0;

    private string favRestaurant = "Dennis";

    // Declare a Name property of type string:
    public string Name
    {
        get
        {
            return nimi;
        }
        set
        {
            nimi = value;
        }
    }

    public string Restaurant
    {
        get
        {
            return favRestaurant;
        }
        set
        {
            favRestaurant = value;
        }
    }


    // Declare an Age property of type int:
    public int Age
    {
        get
        {
            return ika;
        }
        set
        {
            ika = value;
        }
    }

    public override string ToString()
    {
        return "Nimi = " + Name + ", Ikä = " + Age + " Lempiravintola: " + Restaurant;
    }
}

public class Wrapper
{
    private string nimi = "N/A";
    public string favRestaurant = "Boneless";
    public string Name
    {
        get
        {
            return nimi;
        }
        private set
        {
            nimi = value;
        }
    }

        public string Restaurant
    {
        get
        {
            return favRestaurant;
        }
        private set
        {
            favRestaurant = value;
        }
    }


}


