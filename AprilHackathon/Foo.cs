namespace AprilHackathon
{
    public class Foo
    {
        public string ReturnHelloWorld()
        {
            var a = "Hello";
            var b = "World";
            return $"{a} {b}";
        }

        public int ReturnTwo()
        {
            return 2;
        }

        public int Fibbonacci(int number)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;

            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed  
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }

            return n3;
        }
    }
}
