namespace prep4;

class Program
{
    static void Main(string[] args)
    {
        var kitchen = new Kitchen([new Mixer(), new Stove()]);
        kitchen.EndShift();

        var quiz = new Quiz([new TextInputQuestion("How many days are there in the week?", "7")]);
        
    }
}