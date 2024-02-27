class AlfredosAiQuizbot
{
    static void Main()
    {
        //question
        string[] questions =
        {
            " what animal is pregnant for 2 years?",
            " how old is elon musk? ",
            " who created javascript "
        };

        //create answers
        string[] answers =
        {
            "A. duck \nB. eagle \nC. elephant ",
            "A. 57 \nB. 52 \nC. 59 ",
            "A. kelly \nB. thomas ederson \nC. ocules ",
        };

        //correct answers 
        int[] correctAnswers = { 1,2,0};

        int playerScore = 0;

        Console.WriteLine("Welcome to alfredo's quiz");
        for (int i = 0; i < questions.Length; i++) 
        {
            Console.WriteLine("Question" + (i+1));
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]);
            Console.Write("Please enter your answer ('A' , 'B' , or , 'C ')");
            string playerAnswer = Console.ReadLine();

            //validating answers
            if (string.Equals(playerAnswer, "A",StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
            {
                Console.WriteLine("got it nice"); playerScore++;
                 }else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
               {
                 Console.WriteLine("nope"); playerScore++;
                }else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
                {
                 Console.WriteLine("nope"); playerScore++;
                 }
            
         
                };
        Console.WriteLine("All done");
        Console.WriteLine("Your score is: " + playerScore + "/" + questions.Length);
    }
}