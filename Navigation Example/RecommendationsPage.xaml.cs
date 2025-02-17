namespace Navigation_Example;

public partial class RecommendationsPage : ContentPage
{
	public RecommendationsPage(double CheckBMI, string selection)
	{
		InitializeComponent();
		string choice = selection;
		double BMI = CheckBMI;


        if (BMI < 18.5 && choice == "Male")
        {
            RecommendationLabel.Text="Your BMI is:" + "_" + BMI + ", which is underweight. Increase calorie intak with nutrient-rich foods. Inorporate strength training to build muscle mass. Consult a nutritionist if needed.";
        }

        if (24 > BMI && BMI >= 18.5 && choice == "Male")
        {
           RecommendationLabel.Text= "Your BMI is:" + "_" + BMI + ", which is normal weight. Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of excercise per week. Keep regular check ups to monitor overall health.";
        }

        if (29 > BMI && BMI >= 24 && choice == "Male")
        {
            RecommendationLabel.Text="Your BMI is:" + "_" + BMI + ", which is overweight. Reduce processed foods and focus on portion control. Engage in regular physical exercise and strength training. Drink plenty of water and track your progress.";
        }

        if (BMI >= 29 && choice == "Male")
        {
            RecommendationLabel.Text="Your BMI is:" + "_" + BMI + ", which is obese. Consult a doctor for personalized guidance. Start with low-impact exercises. Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
        }

        if (BMI < 18 && choice == "Female")
        {
            RecommendationLabel.Text="Your BMI is:" + " " + BMI + ", which is underweight. Increase calorie intak with nutrient-rich foods. Inorporate strength training to build muscle mass. Consult a nutritionist if needed.";
        }


        if (BMI > 24 && BMI >= 18 && choice == "Female") { RecommendationLabel.Text="Your BMI is:" + "_" + BMI + ", which is normal weight. Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of excercise per week. Keep regular check ups to monitor overall health."; }


        if (BMI >= 24 && BMI < 29 && choice == "Female") { RecommendationLabel.Text="Your BMI is:" + "_" + BMI + ", which is overweight. Reduce processed foods and focus on portion control. Engage in regular physical exercise and strength training. Drink plenty of water and track your progress."; }


        if (BMI >= 29 && choice == "Female") { RecommendationLabel.Text="Your BMI is:" + "_" + BMI + ", which is obese. Consult a doctor for personalized guidance. Start with low-impact exercises. Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule."; }

    }


    void RecommendationBackBtn_Clicked(object sender, EventArgs e)
    { Navigation.PopAsync(); }

    void RecommendationHomeBtn_Clicked(object sender, EventArgs e)
    { Navigation.PopToRootAsync(); }
}