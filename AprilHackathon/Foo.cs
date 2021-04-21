namespace AprilHackathon
{
    public class Foo
    {
        public string ReturnHelloWorld()
        {
            var a = "Hello";
            var b = "World";
            return $"{a} {b}";

            //old implementation return "Hello World"
        }

        public int ReturnTwo()
        {
            return 2;
        }

        public int ReturnFibonacci(int number)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;

            for (int i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }

            return n3;
        }
    }
}
