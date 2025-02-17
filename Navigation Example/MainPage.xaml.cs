namespace Navigation_Example
{
    public partial class MainPage : ContentPage
    {
        double BMI = 0;
        double weight = 0;
        double height = 0;
        string selection = "blank";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            height = HeightSlider.Value;
            weight = WeightSlider.Value;
            double BMI = (weight * 703) / (height * height);
            Navigation.PushAsync(new ResultPage(weight, height, selection));

        }
        private void TapMale_Tapped(object sender, TappedEventArgs e)
        {
            selection = "Male";
            FrameMale.BorderColor = Color.FromArgb("#0a0e29");
            FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
        }

        private void TapFemale_Tapped(object sender, TappedEventArgs e)
        {
            selection = "Female";
            FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
            FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
        }

    }
}
