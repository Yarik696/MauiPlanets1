namespace View;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
    {

		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
        {
			return;
        }

		var parentAnimation = new Animation();

		//PlanetsAnimation
		parentAnimation.Add(0, 0.2, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.1, 0.3, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.3, 0.5, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.4, 0.6, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.5, 0.7, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.6, 0.8, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0,7, 0.9, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));

        //intro Box
        parentAnimation.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);  
    }
}