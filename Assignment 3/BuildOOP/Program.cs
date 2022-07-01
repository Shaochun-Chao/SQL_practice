namespace BuildOOP
{
    public class Program
    {
        public static void Main(String[] args)
        {

           Student student = new Student();
            student.Name = "bod";
            student.Totalcourse = 5;

            student.coursesName((int)student.Totalcourse);
        }

   
    }

}
