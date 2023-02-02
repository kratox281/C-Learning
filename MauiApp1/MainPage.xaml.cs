namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        total.TextChanged += (s, e) => CalculateTip(false, false);
        roundDown.Clicked += (s, e) => CalculateTip(false, true);
        roundUp.Clicked += (s, e) => CalculateTip(true, false);

        sliderPorcentaje.ValueChanged += (s, e) =>
        {
            double pct = Math.Round(e.NewValue);
           pPorcentaje.Text = pct + "%";
            CalculateTip(false, false);
        };
    }

    void CalculateTip(bool roundUp, bool roundDown)
    {
        double t;
        if (Double.TryParse(total.Text, out t) && t > 0)
        {
            double pct = Math.Round(sliderPorcentaje.Value);
            double tip = Math.Round(t * (pct / 100.0), 2);

            double final = t + tip;

            if (roundUp)
            {
                final = Math.Ceiling(final);
                tip = final - t;
            }
            else if (roundDown)
            {
                final = Math.Floor(final);
                tip = final - t;
            }

           Propina.Text = tip.ToString("C");
            Total.Text = final.ToString("C");
        }
    }

    void OnNormalTip(object sender, EventArgs e) { sliderPorcentaje.Value = 15; }
    void OnGenerousTip(object sender, EventArgs e) { sliderPorcentaje.Value = 20; }

    private void roundUp_Clicked(object sender, EventArgs e)
    {

    }
}

