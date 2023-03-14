using MauiPopup;

namespace MauiApp1;

public partial class MainPage : ContentPage


{
	int count = 0;
	
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		/*count++;
		
		if (count == 1)
		
			counterBtn.Text = $"Clicked {count} time";
		
		else
			counterBtn.Text = $"Clicked {count} times";
       

     SemanticScreenReader.Announce(counterBtn.Text); */
		
    }
    private void OnCounterCClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)

            CCounterBtn.Text = $"Clicked {count} time";

        else
            CCounterBtn.Text = $"Clicked {count} times";


        SemanticScreenReader.Announce(CCounterBtn.Text);

    }
    private void OnPeekClicked(object sender,EventArgs e)
	{
		count++;
		if (count == 1)
			CCountertop.Text = $"picked {count} boo";

		else
		 countertop.Text = $"picked {count} boo";
		
		SemanticScreenReader.Announce(CCountertop.Text);

	}

    private void OnPeekCClicked(object sender, EventArgs e)
    {
        /*count++;
        if (count == 1) CCountertop.Text = $"picked {count} boo";

        else
            CCountertop.Text = $"picked {count} boo";

        SemanticScreenReader.Announce(CCountertop.Text);*/
        PopupAction.DisplayPopup(new Popup());
    }
}

