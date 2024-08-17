using OpenQA.Selenium;

namespace IdeaCenterPOM.Pages
{
    public class CreateIdeaPage : BasePage
    {
        public CreateIdeaPage(IWebDriver driver): base(driver) 
        {
            
        }

        public string Url = BaseUrl + "/Ideas/Create";
        public IWebElement TitleInput => driver.FindElement(By.XPath("//input[@name='Title']"));
        public IWebElement ImageInput => driver.FindElement(By.XPath("//input[@name='Url']"));
        public IWebElement DescriptionInput => driver.FindElement(By.XPath
            ("//textarea[@name='Description']"));
        public IWebElement CreateButton => driver.FindElement(By.XPath
           ("//button[@class='btn btn-primary btn-lg']"));
        public IWebElement MainMesage => driver.FindElement(By.XPath
           ("//li[contains(.,'Unable to create new Idea!')]"));
        public IWebElement TitleErrorMesage => driver.FindElement(By.XPath
   ("//span[@class='text-danger field-validation-error'][contains(.,'The Title field is required.')]"));
        public IWebElement DescriptionErrorMesage => driver.FindElement(By.XPath
   ("//span[@class='text-danger field-validation-error'][contains(.,'The Description field is required.')]"));

        public void CreateIdea(string title, string ImageUrl, string description)
        {
            TitleInput.SendKeys(title);
            ImageInput.SendKeys(ImageUrl);
            DescriptionInput.SendKeys(description);
            CreateButton.Click();
        }

        public void AssertErrorMesages()
        {
            Assert.True(MainMesage.Text.Equals("Unable to create new Idea!"), "Main message is not as expected");
            Assert.True(TitleErrorMesage.Text.Equals("The Title field is required."), "Title message is not as expected");
            Assert.True(DescriptionErrorMesage.Text.Equals("The Description field is required."), "Description message is not as expected");

        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
