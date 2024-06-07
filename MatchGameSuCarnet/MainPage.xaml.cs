namespace MatchGameSuCarnet;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        SetUpGame();
    }

    private void SetUpGame()
    {
        List<string> animalEmoji = new List<string>()
        {
        "🐶","🐶",
        "🙈","🙈",
        "🦑","🦑",
        "🐘","🐘",
        "🦓","🦓",
        "🦒","🦒",
        "🐍","🐍",
        "🐬","🐬",
        };
        Random random = new Random();
        //Recorre el grid asignando un emoji Francisco
        foreach (Label view in Grid1.Children)
        {

            int index = random.Next(animalEmoji.Count);
            string nextEmoji = animalEmoji[index];
            view.Text = nextEmoji;
            animalEmoji.RemoveAt(index);

        }
    }
}

