namespace CSTutorial15Dey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation
            var patient1 = new Patient();
            patient1.StayDays = 3;
            Console.WriteLine("Patient 1 bill "+ patient1.Bill);

            var patient2 = new Patient();
            patient2.StayDays = 5;
            Console.WriteLine("Patient 2 bill " + patient2.Bill);


        }
    }
}
