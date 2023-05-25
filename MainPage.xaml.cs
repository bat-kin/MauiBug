namespace MauiBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        MessageBack.Text = $"Swiped {e.Direction.ToString().ToUpper()}. Try again.";
        BotImage.Rotation += 90;
    }
}

