using NUnit.Framework;
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
		// Create a reference for Chrome browser
		IWebDriver driver = new ChromeDriver();

		static void Main( string[] args )
		{
			
			
		}

		[SetUp]
		public void Initialize()
		{
			// Go to Google Webpage
			driver.Navigate().GoToUrl( "https://www.google.com" );
		}


		[Test]
		public void ExecuteTheTest()
		{

			Initialize();

			//Full screen browser
			driver.Manage().Window.Maximize();

			// Find the elements
			IWebElement searchBox = driver.FindElement( By.Name( "q" ) );

			// Enter something into the search bar
			searchBox.SendKeys( "Automation practice - Selenium Sample" );

		}

		[TearDown]
		public void CloseTest()
		{
			//Close the browser
			driver.Quit();
		}
	}
}
