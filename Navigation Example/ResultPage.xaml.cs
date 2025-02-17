namespace Navigation_Example;

public partial class ResultPage : ContentPage
{
	public ResultPage(double weight, double height, string selection)
	{	

		InitializeComponent();
		double BMI = (weight * 703) / (height * height);
		string Selection = selection;

		BMILabel.Text = "Your BMI is" + " " + BMI + " ";

		  void ResultNextBtn_Clicked(object sender, EventArgs e)
		{ Navigation.PushAsync(new RecommendationsPage(BMI, Selection)); }

		void ResultHomeBtn_Clicked(object sender, EventArgs e)
		{ Navigation.PopToRootAsync(); }


    }


}