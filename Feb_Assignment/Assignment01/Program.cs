namespace Assignment01
{
    public class Program
    {
        public static void Main()
        {
            //QuestionTwo q2 = new QuestionTwo();
            //Console.WriteLine("Pleas input a number as century: ");
            //uint x;
            //x = Convert.ToUInt32(Console.ReadLine());
            //q2.ConvertDate(x);


            //FizzBuzz fizzBuzz = new FizzBuzz();
            //fizzBuzz.Solution(5);


            //InfiniteLoop il = new InfiniteLoop();
            //il.Solution();
            //The max number of byte is 255, if we want to loop to 500, using byte will overflow,
            //it will start over from 0, thus the loop will never end
            //solution is that we should change byte to int

            //GuessNumber guessNumber = new GuessNumber();
            //guessNumber.Solution();

            //Pyramid pyramid = new Pyramid();
            //pyramid.Solution(5);

            //QuestionFour qf = new QuestionFour();
            //qf.Solution();

            //Question5 q5 = new Question5();
            //q5.Greetings();

            Question6 q6 = new Question6();
            q6.Solution(24);
        }
    }
}