namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Teachers t1 = new Teachers();
            Teachers t2 = new Teachers();
            Teachers t3 = new Teachers();
            Teachers t4 = new Teachers();   
            Teachers t5 = new Teachers();
            t1.subject("English");
            t2.subject("Russian");
            t3.subject("Maths");
            t4.subject("Programming");
            t5.subject("History");
        }
    }
}