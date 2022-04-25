using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectMarsCompetitionTask.ScreenShot
{
    public class TakeScreenShot
    {
        public static void ScreenShotMethod(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\mrudu\Desktop\Reshma\Industry Connect\INTERNSHIP\ProjectMars_CompetitionTask\ProjectMars_CompetitionTaskRepo\ProjectMarsCompetitionTask\ScreenShot" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);

        }

    }
}
