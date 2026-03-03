namespace prep4;

public interface IQuestion
{
    string Text { get; }

    bool CheckAnswer(string answer);
}