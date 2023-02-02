using CommunityToolkit.Maui.Views;

namespace MauiAppToolKit;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Close();
    }
}