namespace prep4;

public class Quiz
{
    private List<IQuestion> questions;

    private Random random = new Random();
    
    public Quiz(List<IQuestion> questions)
    {
        this.questions = questions;
    }

    private IQuestion currentQuestion;

    public void AskNextQuestion()
    {
        currentQuestion = questions[random.Next(questions.Count)];
        Console.WriteLine("Next question: ");
        Console.WriteLine(currentQuestion.Text);
    }

    public void TryAnswer(string userAnswer)
    {
        if (currentQuestion.CheckAnswer(userAnswer))
        {
            Console.WriteLine("You're right!");
        }
        else
        {
            Console.WriteLine("Sorry, it is wrong :(");
        }
    }
}