using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace E_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;

            // create dictionary with start data (how it must be). 
            driver = new ChromeDriver();
           

            driver.Url = "https://ek.ua/";


            Console.WriteLine("Enter the name of subcategory");
            string search1 = Console.ReadLine();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    string part1 = $"/html/body/div[3]/div/ul/li[{i}]";
                    IWebElement category = driver.FindElement(By.XPath(part1 +"/a"));
                    
                    for (int j = 1; j < 10; j++)
                    {

                            string final = $"{part1}/div/div/a[{j}]";
                            IWebElement sub_category = driver.FindElement(By.XPath(final));
                            string sub_cat = sub_category.GetAttribute("textContent");

                        if (sub_cat.Contains(search1))
                        {
                            Console.WriteLine($"'{search1}' находится в категории '{category.Text}'");
                            driver.Close();
                            Console.ReadLine();
                           
                        }
                        else
                        {
                            Console.WriteLine($"'{search1}' нет ни в одной категории. Проверьте правильность ввода.");
                            driver.Close();
                        }
                    }
                    
                }
                catch (NoSuchElementException)
                {
                    continue;
                }
                catch (WebDriverException)
                {

                    break;
                }
            }
           

          }
          }  
        }

      
    


