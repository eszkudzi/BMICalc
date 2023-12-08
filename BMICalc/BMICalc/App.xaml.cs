﻿using BMICalc.View;

namespace BMICalc;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new BMICalculatorPage());
    }
}

