namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private string _pin;
	private string _password;
	private bool _enter;
	public string Pin { get => _pin; set => _pin = value; }
    public string Password { get => _password; set => _password = value; }
	public bool Enter { get => _enter; set => _enter = value; }
    public MainPage()
	{
		InitializeComponent();
		Pin = "";
		Enter = true;
		Password = "1234";
		
	}
    public void DigitClicked(object sender, EventArgs e)
	{
		if (Enter == true)
		{
			Pin += (sender as Button).Text;
			DisplayLabel.Text = Pin;
		}
	}

	public void ConfirmationClicked(object sensder, EventArgs e)
	{
		Enter = false;
	}
	public void ClearClicked(object sender, EventArgs e)
	{
		Pin = "";
        DisplayLabel.Text = Pin;
    }
}

