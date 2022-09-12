using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_try1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hero = 0;
            int hero_life = 100;
            int post_hero_life = 0;
            int hero_abil = 0;
            int hero_exp = 0;
            int hero_level = 0;
            
            int level = 0;
            
            int stren = 0;
            int agil = 0;
            int intell = 0;
            int characteristics = 0;
            
            int reputation = 0;
            int damage_hero = 1;

            int loot = 0;
            int loot_hero_damage = 0;
            int stick = 0;

            string tavern = " ";

            int monsters = 0;
            int monsters_damages = 0;
            int loot_monster = 0;
            int bestiary = 0;

            int travel = 0;

            bool lvl1 = false;
            string lvl = " ";
            bool town = false;
            bool city = false;
            bool End_Game = false;
            string New_Game = " ";
            while (New_Game != "Закончить игру")
            {
                if (!End_Game)//true
                {
                    Console.WriteLine("Начать игру");
                    Console.WriteLine("Закончить игру");
                }
                else//false
                {
                    Console.WriteLine("Начало приключения");
                    Console.WriteLine("Продолжить приключение");
                    Console.WriteLine("Персонаж");
                    Console.WriteLine("Инвентарь");
                    Console.WriteLine("Бестиарий");
                    Console.WriteLine("Выйти из игры");
                }
                New_Game = Console.ReadLine();
                switch (New_Game)
                {
                    case "Начать игру":
                        if ("Начать игру" == "Начать игру")
                        {
                            Console.WriteLine("Начнем приключение!");
                            End_Game = true;
                        }
                        else
                        {
                            Console.WriteLine("Вы вышли из игры");
                        }
                        break;
                    case "Персонаж":
                        while (lvl != "Вернуться в предыдущее меню")
                        {
                            if (!lvl1)//true
                            {
                                Console.WriteLine("Вызвать меню персонажа");
                                Console.WriteLine("Вернуться в предыдущее меню");
                            }
                            else//false
                            {
                                Console.WriteLine($"На {level} уровне вам доступно:");
                                Console.WriteLine("Распределить характеристики");
                                Console.WriteLine("Посмотреть умения");
                                Console.WriteLine("Инвентарь");
                                Console.WriteLine("Посмотреть статистику");
                                Console.WriteLine("Вернуться в предыдущее меню");
                            }
                            lvl = Console.ReadLine();
                            switch (lvl)
                            {
                                case "Вызвать меню персонажа":
                                    if ("Вызвать меню персонажа" == "Вызвать меню персонажа")
                                    {
                                        lvl1 = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы вернулись в предыдущее меню");
                                        lvl1 = false;
                                    }
                                    break;
                                case "Распределение характеристик":
                                    if (characteristics > 0)
                                    {
                                        Console.WriteLine("У вас есть нераспределенные очки характеристик");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас нет доступных очков характеристик");
                                    }
                                    break;
                                case "Посмотреть умения":
                                    if (level > 1)
                                    {
                                        Console.WriteLine("Вам доступны следующие умения:");
                                        Console.WriteLine("123");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас нет доступных умений");
                                    }
                                    break;
                                case "Инвентарь":
                                    Console.WriteLine("Здесь вы можете посмотреть свои предметы");
                                    break;
                                case "Посмотреть статистику":
                                    Console.WriteLine("У вас есть следующие пункты");
                                    break;
                                case "Вернуться в предыдущее меню":
                                    lvl1 = false;
                                    break;
                            }
                        }
                        break;
                    case "Инвентарь":
                        Console.WriteLine("Здесь вы можете посмотреть свои предметы");
                        Console.WriteLine("На данный момент у вас есть:");
                        Console.WriteLine(loot_hero_damage);
                        break;
                    case "Бестиарий":
                        Console.WriteLine("Здесь содержится информация о побежденных протиниках");
                        Console.WriteLine(bestiary);
                        break;
                    case "Начало приключения":
                        Random monster_damage = new Random();
                        Random hero_damage = new Random();
                        Random rnd_item = new Random();
                        Random lvl_hero = new Random();
                        Random rnd_travel = new Random();
                        int kaban_health = 50;
                        Console.WriteLine("Вы очнулись без памяти, не помня ничего о своем прошлом на берегу моря");
                        Console.WriteLine("Вы осматриваетесь, пытаясь найти зацепки о своем прошлом, но ничего не выходит.");
                        Console.WriteLine("Бесцельно шатаясь по округе вы замечаете что-то странное...");
                        travel = rnd_travel.Next(1, 5);
                        if (travel == 1)
                        {
                            
                            Console.WriteLine("Вы видите перед собой стаю диких кабанов");
                            Console.WriteLine("Рядом вы находите с собой старую дубину");
                            Console.WriteLine("С дубиной вы выглядите как Шварцнеггер. Получите + 2 к урону");
                            loot_hero_damage = stick;
                            stick = damage_hero;
                            damage_hero = +2;
                            Console.WriteLine("Один из кабанов рассматривает вас в качестве вечернй закуски");
                            Console.WriteLine("Но у вас другие планы. Сжимая дубину в руках, вы готовитесь к бою");

                            while (kaban_health > 1)
                            {
                                damage_hero = hero_damage.Next(1, 4);
                                monsters_damages = monster_damage.Next(2, 3);
                                Console.WriteLine($"Вы наносите урон монстру - {damage_hero}");
                                kaban_health--;
                                Console.WriteLine($"У монстра осталось -  жизней");
                                Console.WriteLine($"Монстр наносит по вам - {monsters_damages}");
                                hero_life = hero_life - monsters_damages;
                                Console.WriteLine($"У вас осталось - {hero_life} жизней");

                            }

                            if (hero_life > 0)
                            {
                                loot_monster = rnd_item.Next(1, 10);
                                if (loot_monster == 10)
                                {
                                    Console.WriteLine($"Вы получили предмет - шкура кабана!");
                                }
                                hero_exp = lvl_hero.Next(10, 20);
                                if (hero_exp > 10)
                                {
                                    Console.WriteLine($"Вы получили {hero_exp} опыта, осталось {100 - hero_exp} для получения нового уровня");
                                    level = hero_exp;
                                }
                                Console.WriteLine($"Вы победили монстра, у вас осталось {hero_life} жизней");
                            }
                            else
                            {
                                Console.WriteLine("Вы потерпели поражение от кабана...");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы продолжаете бесцельно шататься по округе");
                        }
                        if (travel == 2)
                        {
                            Console.WriteLine("Идя по дороге вы спотыкаетесь и попадаете в глубокую яму");
                            Console.WriteLine("Вы в панике пытаетесь найти выход");
                            Console.WriteLine("Спустя час вы смиряетесь со своей судьбой, но вдруг замечаете некоторые детали");
                            Console.WriteLine("На стене ямы написаны нечетковыраженные буквы");
                            Console.WriteLine("щ у в х о ы И и и н д з в");
                            Console.WriteLine("Что за слова записаны на стене?");
                            string secret = Console.ReadLine();
                            if (secret == "Ищи выход внизу")
                            {
                                Console.WriteLine("Как только вы произнесли вслух фарзу целиком, вам открылась новая картина");
                                Console.WriteLine("Вы замечаете труп вашего предшественника");
                                Console.WriteLine("Осмотреть труп?");
                                Console.WriteLine("Да");
                                Console.WriteLine("Нет");
                                string dead_man = Console.ReadLine();
                                if (dead_man == "Да")
                                {
                                    Console.WriteLine("Вы шаритесь по карманам у иссушенного трупа, от него исходит удушающий аромат смерти, и вам кажется, что он смотрет вам в душу");
                                    Console.WriteLine("Пред вашим взором открываются вещи");
                                    Console.WriteLine("1. Неизвестный ключ");
                                    Console.WriteLine("2. Перстень с какой-то символикой");
                                    Console.WriteLine("3. Ржавый меч");
                                    Console.WriteLine("Что вы заберете с собой?");
                                    string dead_man_loot = Console.ReadLine();
                                    if (dead_man_loot == "ключ")
                                    {
                                        Console.WriteLine("Вы прячете ключ в свой карман, и перед вами возникает дверь");
                                        Console.WriteLine("Вы вставляете ключ в скважину, и дверь открывается");
                                        Console.WriteLine("Вы входите в дверь, и оказываетесь в открытом поле без памяти и вещей...");
                                        End_Game = false;
                                    }
                                    else if (dead_man_loot == "Перстень")
                                    {
                                        Console.WriteLine("Необычный с виду перстень реагирует на ваше прикосновение и начинает светиться");
                                        Console.WriteLine("Вы примеряете кольцо на палец и возникает портал");
                                        Console.WriteLine("Зайдя в него вы оказываетесь в замке короля");
                                        Console.WriteLine("Стража хватается за оружие, и спрашивает у вас - Как ты тут оказался? Ты кто?");
                                        Console.WriteLine("Не находя ответов на вопросы стражники режут вас как свинью.");
                                        Console.WriteLine("Вы умираете, так и не найдя ответов на то, кто вы, и зачем вы в этом мире");
                                        End_Game = false;
                                    }
                                    else if (dead_man_loot == "Меч")
                                    {
                                        Console.WriteLine("Вы подбираете ржавый меч, и ножны");
                                        Console.WriteLine("Осматривая его вы ненаходите ничего необычного");
                                        Console.WriteLine("Вы догадываетесь, что можно выбраться из ямы при помощи меча");
                                        Console.WriteLine("Вы берете его в руки, и начинаете карабкаться");
                                        Console.WriteLine("Спустя целую вечность вы выбираетесь из ямы.");
                                        int sword = damage_hero + 10;
                                        loot += sword;
                                    }
                                    else if (dead_man_loot == "Все")
                                    {
                                        Random rnd_dead_man_attacked = new Random();
                                        Random rnd_hero_attacked = new Random();
                                        int health_dead_man = 1000;
                                        Console.WriteLine("Вы жадно забираете все предметы, надеваете на себя кольцо, крепите ножны к поясу");
                                        Console.WriteLine("Как только вы кладете в карман ключ, мертвец неожиданно оживает и медленными шагами идет к вам");
                                        Console.WriteLine("Мертвец начал преобразовываться, обрастая мерзкой броней. В руках у него появились 2 некротических кинжала, а глаза загорелись алыми огнями.");
                                        
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы умираете в яме от обезвоживания, потому что побоялись узнать что-то новое");
                            }    
                        }  
                        if (travel == 3)
                        {
                            Console.WriteLine("После долгой прогулки вы сели возле большого дерева");
                            Console.WriteLine("Вы звдремали...вы смотрите прекрасный сон, в котором видите следующее");
                            Console.WriteLine("Перед вами стоит человек в черной мантии, силуэт окутывает тьма, и воздух становится тяжелее");
                            Console.WriteLine("")
                        }
                        break;
                    case "Продолжить приключение":
                        Console.WriteLine("После победы над кабаном, вы видите лес");
                        Console.WriteLine("Интуиция подсказывает вам, что в лесу вас ждет что-то интересное...");
                        Console.WriteLine("Подойдя ближе к лесу вы замечаете стража леса");
                        break;

                }
            }
        }
    }
}