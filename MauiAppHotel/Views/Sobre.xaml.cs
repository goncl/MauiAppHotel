namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PopAsync();
        }

        catch (Exception ex)
        {
            await DisplayAlert("OPS", ex.Message, "OK");
        }
    }
}