namespace prep4;

public class TextInputQuestion : IQuestion
{
    public string Text { get; }

    private string answer;
    
    public TextInputQuestion(string text, string answer)
    {
        Text = text;
        this.answer = answer;
    }
    public bool CheckAnswer(string userAnswer)
    {
        return string.Equals(userAnswer, answer, StringComparison.InvariantCultureIgnoreCase);
    }
}