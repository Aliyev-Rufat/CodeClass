

static void Main(string[] args)
{
    Human human = new Human("Rufat", "Aliyev", "Male", 20);
    human.ShowInfo();

    Doctor doctor = new Doctor("Leyla", "Ferecli", "Female", 20, "dentist", 13);
    doctor.ShowInfo();
}