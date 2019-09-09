using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMillion
{
    internal class Questions
    {
        public static void Quest1()
        {
            string Answer;
            bool answer;

            List<string> quest1 = new List<string>(); //Вопросы
            quest1.Add("Что является символом власти Папы Римского?"); //1
            quest1.Add("Для кого придуман девиз: «Быстрее, выше, сильнее»?"); //2
            quest1.Add("Как правильно назвать литературоведа- специалиста по творчеству Данта?"); //3
            quest1.Add("Какая фамилия не входит в ставшую притчей во языцех троицу?"); //4
            quest1.Add("Как звали любимого коня Александра Македонского?"); //5
            quest1.Add("Как называются люди, которые стараются обратить других в свою религию?"); //6
            quest1.Add("Как называлась Венгерская республика при социализме?"); //7
            quest1.Add("Как звали известного греческого магната - судовладельца Онассиса?"); //8
            quest1.Add("Какая из этих стран не является монархией?"); //9
            quest1.Add("Что держит в руке богиня правосудия Фемида?"); //10
            quest1.Add("Что из этого не является материальным объектом?"); //11
            quest1.Add("За что нельзя получить гонорар ?"); //12
            quest1.Add("Под каким названием известна симфония №41 до мажор В. А. Моцарта?"); //13
            quest1.Add("Какой актер сыграл Гарри Поттера?"); //14
            quest1.Add("Что такое циклахена?"); //15

            //Ответы к вопросам
            List<string> AnswerOPtions1 = new List<string>(); //1
            AnswerOPtions1.Add("A: Серьга кузнеца");
            AnswerOPtions1.Add("B: Кольцо рыбака");
            AnswerOPtions1.Add("C: Кулон пастуха");
            AnswerOPtions1.Add("D: Браслет плотника");

            List<string> AnswerOPtions2 = new List<string>(); //2
            AnswerOPtions2.Add("A: Для пожарных");
            AnswerOPtions2.Add("B: Для спортсменов");
            AnswerOPtions2.Add("C: Для балерин");
            AnswerOPtions2.Add("D: Для фотомоделей");

            List<string> AnswerOPtions3 = new List<string>(); //3
            AnswerOPtions3.Add("A: Дантист");
            AnswerOPtions3.Add("B: Дантовед");
            AnswerOPtions3.Add("C: Дантовец");
            AnswerOPtions3.Add("D: Дантовик");

            List<string> AnswerOPtions4 = new List<string>();
            AnswerOPtions4.Add("A: Кузнецов");
            AnswerOPtions4.Add("B: Иванов");
            AnswerOPtions4.Add("C: Сидоров");
            AnswerOPtions4.Add("D: Петров");

            List<string> AnswerOPtions5 = new List<string>();
            AnswerOPtions5.Add("A: Россинат");
            AnswerOPtions5.Add("B: Буцефал");
            AnswerOPtions5.Add("C: Савраска");
            AnswerOPtions5.Add("D: Иппократ");

            List<string> AnswerOPtions6 = new List<string>();
            AnswerOPtions6.Add("A: Еретики");
            AnswerOPtions6.Add("B: Набобы");
            AnswerOPtions6.Add("C: Религисты");
            AnswerOPtions6.Add("D: Миссионеры");

            List<string> AnswerOPtions7 = new List<string>();
            AnswerOPtions7.Add("A: Социалистическая");
            AnswerOPtions7.Add("B: Народная");
            AnswerOPtions7.Add("C: Народно-демократическая");
            AnswerOPtions7.Add("D: Демократическая");

            List<string> AnswerOPtions8 = new List<string>();
            AnswerOPtions8.Add("A: Плутарх");
            AnswerOPtions8.Add("B: Платон");
            AnswerOPtions8.Add("C: Аристотель");
            AnswerOPtions8.Add("D: Сократ");

            List<string> AnswerOPtions9 = new List<string>();
            AnswerOPtions9.Add("A: Норвегия");
            AnswerOPtions9.Add("B: Бельгия");
            AnswerOPtions9.Add("C: Финляндия");
            AnswerOPtions9.Add("D: Нидерланды");

            List<string> AnswerOPtions10 = new List<string>();
            AnswerOPtions10.Add("A: Весы");
            AnswerOPtions10.Add("B: Щит");
            AnswerOPtions10.Add("C: Бубен");
            AnswerOPtions10.Add("D: Знамя");

            List<string> AnswerOPtions11 = new List<string>();
            AnswerOPtions11.Add("A: Воздух");
            AnswerOPtions11.Add("B: Небо");
            AnswerOPtions11.Add("C: Земля");
            AnswerOPtions11.Add("D: Солнце");

            List<string> AnswerOPtions12 = new List<string>();
            AnswerOPtions12.Add("A: За статью");
            AnswerOPtions12.Add("B: За очерк");
            AnswerOPtions12.Add("C: За роман");
            AnswerOPtions12.Add("D: За анонимку");

            List<string> AnswerOPtions13 = new List<string>();
            AnswerOPtions13.Add("А: \"Венера\"");
            AnswerOPtions13.Add("В: \"Юпитер\"");
            AnswerOPtions13.Add("С: \"Сатурн\"");
            AnswerOPtions13.Add("D: \"Нептун\"");

            List<string> AnswerOPtions14 = new List<string>();
            AnswerOPtions14.Add("А: Джет Мейсон");
            AnswerOPtions14.Add("В: Дэниел Рэдклифф");
            AnswerOPtions14.Add("С: Кью Денонс");
            AnswerOPtions14.Add("D: Руперт Гринт");

            List<string> AnswerOPtions15 = new List<string>();
            AnswerOPtions15.Add("A: Собрание аxеян");
            AnswerOPtions15.Add("B: Присадка к бензину");
            AnswerOPtions15.Add("C: Растение");
            AnswerOPtions15.Add("D: Вид глистов");

            int quest = 0;

            while (quest < quest1.Count)
            { 
                if (quest == 0)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions1.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions1[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 0; }
                }
                
                if (quest == 1)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions2.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions2[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 0; }
                }
                
                if (quest == 2)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions3.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions3[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 0; }
                }
                
                if (quest == 3)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions4.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions4[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "A";

                    if (answer) { quest++; }
                    else { quest = 0; }
                }
                
                if (quest == 4)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions5.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions5[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 0; }
                }
                
                if (quest == 5)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions6.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions6[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "D";

                    if (answer) { quest++; }
                    else { quest = 4; }
                }

                if (quest == 6)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions7.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions7[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 4; }
                }

                if (quest == 7)
                {
                    Console.WriteLine($"Вопрос номер({quest+1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions8.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions8[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "C";

                    if (answer) { quest++; }
                    else { quest = 4; }
                }

                if (quest == 8)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions9.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions9[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "C";

                    if (answer) { quest++; }
                    else { quest = 4; }
                }

                if (quest == 9)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions10.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions10[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "A";

                    if (answer) { quest++; }
                    else { quest = 4; }
                }

                if (quest == 10)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions11.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions11[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 9; }
                }

                if (quest == 11)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions12.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions12[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "D";

                    if (answer) { quest++; }
                    else { quest = 9; }
                }

                if (quest == 12)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions13.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions13[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 9; }
                }

                if (quest == 13)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions14.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions14[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "B";

                    if (answer) { quest++; }
                    else { quest = 9; }
                }

                if (quest == 14)
                {
                    Console.WriteLine($"Вопрос номер({quest + 1}):\n" + quest1[quest]);
                    for (int i = 0; i < AnswerOPtions15.Count; i++)
                    {
                        Console.WriteLine(AnswerOPtions15[i]);
                    }
                    Answer = Console.ReadLine();
                    answer = Answer == "C";

                    if (answer) { quest++; }
                    else { quest = 9; }
                }
            }




        }
        


    }
}
