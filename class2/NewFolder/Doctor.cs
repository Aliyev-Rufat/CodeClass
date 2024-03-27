class Doctor : Human
{
    public string Speciality { get; set; }
    private int experience;

    public int Experience
    {
        get { return experience; }
        set
        {
            if (value >= 0)
            {
                experience = value;
            }
            else
            {
                Console.WriteLine(".");
                experience = 0;
            }
        }
    }

    public Doctor(string name, string surname, string gender, int age, string speciality, int experience) : base(name, surname, gender, age)
    {
        Speciality = speciality;
        Experience = experience;
    }

    public new string GetInfo()
    {
        return $"{base.GetInfo()}, Speciality: {Speciality}, Experience: {Experience}";
    }

    public new void ShowInfo()
    {
        Console.WriteLine(GetInfo());
    }
}