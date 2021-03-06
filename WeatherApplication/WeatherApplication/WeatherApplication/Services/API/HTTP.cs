﻿using System;
using System.Threading.Tasks;
using Prism.Navigation;
using WeatherApplication.Services.API;
using WeatherObjects;

namespace WeatherApplication.ViewModels
{
    public class WeatherOverviewViewModel : ViewModelBase
    {
        public WeatherOverviewViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            LoadData();
        }

        public async Task LoadData()
        {
            var x = await WeatherAPI.GetWeather();
        }
    }
}
