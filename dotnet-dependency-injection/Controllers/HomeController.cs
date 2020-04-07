using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_dependency_injection.Models;
using dotnet_dependency_injection.ViewModels;
using dotnet_dependency_injection.Services;
using dotnet_dependency_injection.Configuration;
using Microsoft.Extensions.Options;

namespace dotnet_dependency_injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherForecaster _weatherForecaster;
        private readonly GuidService _guidService;
        private readonly ILogger<HomeController> _logger;
        private readonly FeaturesConfiguration _featuresConfiguration;

        public HomeController(IWeatherForecaster weatherForecaster, GuidService guidService, ILogger<HomeController> logger, IOptions<FeaturesConfiguration> options)
        {
            _weatherForecaster = weatherForecaster;
            _guidService = guidService;
            _logger = logger;
            _featuresConfiguration = options.Value;
        }

        public IActionResult Index()
        {
            var logMessage = $"Controller: The GUID from GuidService is {_guidService.GetGuid()}";

            _logger.LogInformation(logMessage);

            var viewModel = new HomeViewModel();           
            var currentWeather = _weatherForecaster.GetCurrentWeather();

            if (_featuresConfiguration.EnableWeatherForecast)
            {
                switch (currentWeather.WeatherCondition)
                {
                    case WeatherCondition.Sun:
                        viewModel.WeatherDescription = "It's sunny right now. " +
                                                       "A great day for tennis.";
                        break;
                    case WeatherCondition.Rain:
                        viewModel.WeatherDescription = "We're sorry but it's raining " +
                                                       "here. No outdoor courts in use.";
                        break;
                    default:
                        viewModel.WeatherDescription = "We don't have the latest weather " +
                                                       "information right now, please check again later.";
                        break;
                }
            }

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
