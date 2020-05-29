using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Automation
{
	class Program
	{
		static void Main( string[] args )
		{
			// Create a reference for Chrome browser
			IWebDriver driver = new ChromeDriver();

			// Go to Google Webpage
			driver.Navigate().GoToUrl( "https://www.google.com" );

			//Full screen browser
			driver.Manage().Window.Maximize();

			// Find the elements
			IWebElement searchBox = driver.FindElement( By.Name( "q" ) );

			// Enter something into the search bar
			searchBox.SendKeys( "Automation practice - Selenium Sample" );

			//Close the browser
			driver.Quit();


		}
	}
}
