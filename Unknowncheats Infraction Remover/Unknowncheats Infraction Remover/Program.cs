using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

//using System.Windows.Navigation;

namespace Unknowncheats_Infraction_Remover
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UIRForm());
        }
    }    
}

namespace LocalUtilities
{
    public class HandleBrowser
    {
        public readonly string script2 = "document.documentElement.innerHTML = 'adasdasd'";
        private readonly string script =    "htmlpage = document.documentElement.innerHTML;                                                      "+
                                            "infractionoffset = htmlpage.search('Latest Infractions Received');                                  "+
                                            "startindex = htmlpage.lastIndexOf('<table', infractionoffset);                                      "+
                                            "endindex = htmlpage.indexOf('</table>', infractionoffset) + 8;                                      "+
                                            "stringtoremove = htmlpage.substr(startindex, endindex-startindex);                                  "+
                                            "document.documentElement.innerHTML = document.documentElement.innerHTML.replace(stringtoremove, '');";
        private IWebDriver driver;
        private string pageSource;
        public void GetRightBrowser()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArguments(new List<string>() { "headless" });
            driver = new FirefoxDriver(firefoxOptions);
            driver.Navigate().GoToUrl("https://www.unknowncheats.me/forum/usercp.php");
            pageSource = driver.PageSource;
            while (pageSource.IndexOf("Your Control Panel") == -1)
            {
                //waiting for user to log in
                //totally not some spyware 
                pageSource = driver.PageSource;
                System.Threading.Thread.Sleep(5000);
            }
            //will go out loop when found
            InjectAndExcecute(script);
            //driver.Close();

        }
        public IWebDriver GetDriver()
        {
            return null;
        }
        public void InjectAndExcecute(string arg)
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteAsyncScript(arg);
        }
    }
}
