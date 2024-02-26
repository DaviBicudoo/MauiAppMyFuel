namespace MauiAppMyFuel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double gasoline = Convert.ToDouble(txt_gasoline.Text);
            double ethanol = Convert.ToDouble(txt_ethanol.Text);

            string message = $"The best option in this case is ";

            if (ethanol > (gasoline * 0.7))
            {
                message += "gasoline.";
            } else
            {
                message += "ethanol.";
            }

            DisplayAlert("Result", message, "Close");
        }
    }
}
