// See https://aka.ms/new-console-template for more information


class MyTetris
{
    // class members
    private string i = "i-tetrimono";
    private string j = "j-block";
    private string l = "l-block";
    private string o = "o-block";
    private string s = "s-block";
    private string t = "t-block";
    private string z = "z-block";
    private int tetrominoes = 6;

    public void allPieces()
    {
        Console.WriteLine("There are a total of six pieces that make up the game Tetris.");
    }
}

class MyTetris
{
    private string tetris = "2D game";
    private int diffPieces = 7;
}

static void Main(string[] args)
{
    MyTetris myObj = new MyTetris();
    Console.WriteLine(MyTetris.tetris);
    Console.WriteLine(MyTetris.diffPieces);
}

class secondTetris
{
    public string mode;
    public string color;
    public int lines;
}

static void Main(string[] args)
{
    secondTetris firstMode = new secondTetris();
    secondTetris.mode = "Marathon";
    secondTetris.color = "blue";
    secondTetris.lines = 600;

    secondTetris secondMode = new secondTetris();
    secondTetris.mode = "40 Lines";
    secondTetris.color = "Yellow";
    secondTetris.lines = 40;
    
    Console.WriteLine(firstMode.mode);
    Console.WriteLine(secondMode.mode);
}