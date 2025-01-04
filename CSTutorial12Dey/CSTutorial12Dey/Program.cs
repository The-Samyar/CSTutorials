namespace CSTutorial12Dey
{
    public class Adder<T, U, V>
    {
        public T t; public U u;

        public Adder(T t, U u)
        {
            this.t = t;
            this.u = u;
        }

        public V Run()
        {
            dynamic? a = t;
            dynamic? b = u;
            V? res = (V)(a + b);
            return res;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var kambiz = new Adder<float, float, double>(5.1f, 4.2f);
            Console.WriteLine(kambiz.Run());

        }
    }

}
