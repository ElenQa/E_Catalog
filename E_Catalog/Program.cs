using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace E_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;

            // create dictionary with start data (how it must be). 

            Dictionary<string, string> MustBe = new Dictionary<string, string>();
            MustBe.Add("Мобильные", "Гаджеты");
            MustBe.Add("Планшеты", "Гаджеты");
            MustBe.Add("Приставки", "Гаджеты");
            MustBe.Add("Action камеры", "Гаджеты");
            MustBe.Add("Квадрокоптеры", "Гаджеты");
            MustBe.Add("Наушники", "Гаджеты");
            MustBe.Add("Умные часы и браслеты", "Гаджеты");
            MustBe.Add("Портативные колонки", "Гаджеты");
            MustBe.Add("Powerbank", "Авто");
            MustBe.Add("Карты памяти", "Гаджеты");

            MustBe.Add("Ноутбуки", "Компьютеры");
            //There are two "Планшеты" in different catecories. how to find both.
            //MustBe.Add("Планшеты", "Компьютеры");
            //MustBe.Add("Приставки", "Компьютеры");
            MustBe.Add("Мониторы", "Компьютеры");
            MustBe.Add("ПК", "Компьютеры");
            MustBe.Add("Комплектующие", "Компьютеры");
            MustBe.Add("МФУ", "Компьютеры");
            MustBe.Add("Wi-Fi", "Компьютеры");
            MustBe.Add("Клавиатуры и мышки", "Компьютеры");
            MustBe.Add("Флешки", "Компьютеры");

            //There are two "МФУ" in different catecories. how to find both.
            //MustBe.Add("МФУ", "Компьютеры");
            MustBe.Add("Принтеры", "Офис");
            MustBe.Add("Картриджи", "Офис");
            MustBe.Add("Бумага", "Офис");
            MustBe.Add("Канцелярия", "Офис");
            MustBe.Add("Блокноты", "Офис");
            MustBe.Add("Ежедневники", "Офис");
            MustBe.Add("Сейфы", "Офис");
            MustBe.Add("Проекторы", "Офис");

            MustBe.Add("Фотоаппараты", "Фото");
            MustBe.Add("Вспышки", "Фото");
            MustBe.Add("Объективы", "Фото");
            MustBe.Add("Action камеры", "Фото");
            //MustBe.Add("Карты памяти", "Фото");
            MustBe.Add("Штативы", "Фото");
            MustBe.Add("Стедикамы", "Фото");
            MustBe.Add("Аккумуляторы", "Фото");
            MustBe.Add("Студийный свет", "Фото");

            MustBe.Add("Телевизоры", "TV");
            //MustBe.Add("Мониторы", "TV");
            MustBe.Add("Крепления и тумбы", "TV");
            MustBe.Add("Медиаплееры", "TV");
            MustBe.Add("ТВ тюнеры", "TV");
            MustBe.Add("Проекторы", "TV");
            MustBe.Add("VR очки", "TV");
            MustBe.Add("Кабели", "TV");

            MustBe.Add("Наушники", "Аудио");
            MustBe.Add("Гарнитуры", "Аудио");
            MustBe.Add("Портативные колонки", "Аудио");
            MustBe.Add("Компьютерные колонки", "Аудио");
            MustBe.Add("Акустика", "Аудио");
            MustBe.Add("Hi-Fi/Hi-End", "Аудио");
            MustBe.Add("Кабели", "Аудио");
            MustBe.Add("Муз инструменты", "Аудио");

            MustBe.Add("Встраиваемая техника", "Бытовая техника");
            MustBe.Add("Мелкая бытовая", "Бытовая техника");
            MustBe.Add("Стиральные машины", "Бытовая техника");
            MustBe.Add("Холодильники", "Бытовая техника");
            MustBe.Add("Плиты", "Бытовая техника");
            MustBe.Add("Вытяжки", "Бытовая техника");
            MustBe.Add("Духовки", "Бытовая техника");
            MustBe.Add("Микроволновки", "Бытовая техника");
            MustBe.Add("Кухонные мойки", "Бытовая техника");

            MustBe.Add("Кондиционеры", "Климат");
            MustBe.Add("Вентиляторы", "Климат");
            MustBe.Add("Обогреватели", "Климат");
            MustBe.Add("Водонагреватели", "Климат");
            MustBe.Add("Котлы", "Климат");
            MustBe.Add("Радиаторы", "Климат");
            MustBe.Add("Увлажнители", "Климат");
            MustBe.Add("Насосы", "Климат");
            MustBe.Add("Камины", "Климат");

            MustBe.Add("Коляски", "Детские товары");
            MustBe.Add("Кроватки", "Детские товары");
            MustBe.Add("Пеленальные столики", "Детские товары");
            MustBe.Add("Стульчики для кормления", "Детские товары");
            MustBe.Add("Подгузники", "Детские товары");
            MustBe.Add("Автокресла", "Детские товары");
            MustBe.Add("Велосипеды", "Детские товары");
            MustBe.Add("Игрушки и развлечения", "Детские товары");
            MustBe.Add("РУ модели", "Детские товары");

            MustBe.Add("Шины", "Авто");
            MustBe.Add("Диски", "Авто");
            MustBe.Add("GPS", "Авто");
            MustBe.Add("Регистраторы", "Авто");
            MustBe.Add("Сигнализации", "Авто");
            MustBe.Add("Магнитолы", "Авто");
            MustBe.Add("Аккумуляторы", "Авто");
            MustBe.Add("Моторные масла", "Авто");

            MustBe.Add("Инструмент", "Инструмент и сад");
            MustBe.Add("Генераторы", "Инструмент и сад");
            MustBe.Add("Сварочные аппараты", "Инструмент и сад");
            MustBe.Add("Строительство", "Инструмент и сад");
            MustBe.Add("Ручной инструмент", "Инструмент и сад");
            MustBe.Add("Садовая техника", "Инструмент и сад");
            MustBe.Add("Садовый инструмент", "Инструмент и сад");
            MustBe.Add("Лестницы", "Инструмент и сад");

            MustBe.Add("Палатки", "Туризм");
            MustBe.Add("Спальники", "Туризм");
            MustBe.Add("Горелки", "Туризм");
            MustBe.Add("Фонирики", "Туризм");
            MustBe.Add("Термосы", "Туризм");
            MustBe.Add("Палатки", "Туризм");
            MustBe.Add("Рыбалка", "Туризм");
            MustBe.Add("Рюкзаки", "Туризм");
            MustBe.Add("Чемоданы", "Туризм");
            MustBe.Add("Мангалы", "Туризм");

            MustBe.Add("Велосипеды", "Спорт");
            MustBe.Add("Роликовые коньки", "Спорт");
            MustBe.Add("Скейтюорды", "Спорт");
            MustBe.Add("Тренажеры", "Спорт");
            MustBe.Add("Лижы", "Спорт");
            //MustBe.Add("Action камеры", "Спорт");
            MustBe.Add("Спортивное питание", "Спорт");

            MustBe.Add("Сантехника", "Дом");
            MustBe.Add("Ремонт", "Дом");
            MustBe.Add("Посуда", "Дом");
            MustBe.Add("Мебель", "Дом");
            MustBe.Add("Матрасы", "Дом");
            MustBe.Add("Декор", "Дом");
            MustBe.Add("Лампочки", "Дом");
            MustBe.Add("Охрана и умный дом", "Дом");
            MustBe.Add("Зоотовары", "Дом");



            driver = new ChromeDriver();


            driver.Url = "https://ek.ua/";


            Console.WriteLine("Enter the name of subcategory");
            string search1 = Console.ReadLine();

            bool contains = MustBe.ContainsKey(search1);
            string currentCategoryName;

            if (contains == true)
            {
                string ExpectedCategoryName = MustBe[search1];

                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        string part1 = $"/html/body/div[3]/div/ul/li[{i}]";
                        IWebElement category = driver.FindElement(By.XPath(part1 + "/a"));
                        currentCategoryName = category.Text;

                        for (int j = 1; j < 10; j++)
                        {

                            string final = $"{part1}/div/div/a[{j}]";
                            IWebElement sub_category = driver.FindElement(By.XPath(final));
                            string sub_cat = sub_category.GetAttribute("textContent");


                            if (sub_cat.Contains(search1) && currentCategoryName == ExpectedCategoryName)
                            {

                                Console.WriteLine($"'{search1}' находится в категории {currentCategoryName}'");
                                driver.Close();
                                Console.ReadLine();
                                break;

                            }

                            else if (currentCategoryName != ExpectedCategoryName)
                            {
                                Console.WriteLine($"'{search1}' находится в категории '{currentCategoryName}, а должно в '{ExpectedCategoryName}''");
                                driver.Close();
                                break;
                                
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

            else
            {
                Console.WriteLine($"'{search1}' нет ни в одной категории. Проверьте правильность ввода.");
                driver.Close();
                
            }
        }
    }
}


      
    


