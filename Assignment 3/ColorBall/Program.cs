namespace ColorBall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ball b1 = new Ball(12, 22, 32, 50,10);
            b1.Throw();
            b1.Throw();
            b1.Throw();
            b1.Throw();
            b1.Pop();
            b1.PrintCount();
        }
    }
}