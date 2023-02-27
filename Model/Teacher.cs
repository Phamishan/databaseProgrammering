public class Teacher
{
    public string name { get; set; }
    public int id { get; set; }
    public List<Student> students { get; set; }

    public Teacher() 
    { 
        this.students = new List<Student>();  
    }
}