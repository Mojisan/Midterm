using System;
    class Program {
        static void Main(string[] args)
        {
            Test1();
            //Test2();
        }

        static void Test1() {
            int x1,y1,w1,h1,x2,y2,w2,h2, a1,a2, px1,px2,py1,py2, tub;
            Console.Write("Input x1 : ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Input y1 : ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Input w1 : ");
            w1 = int.Parse(Console.ReadLine());
            Console.Write("Input h1 : ");
            h1 = int.Parse(Console.ReadLine());
            Console.Write("Input x2 : ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Input y2 : ");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("Input w2 : ");
            w2 = int.Parse(Console.ReadLine());
            Console.Write("Input h2 : ");
            h2 = int.Parse(Console.ReadLine());

            a1 = w1 * h2;
            a2 = w2 * h2;
            px1 = w1/2 + x1;
            py1 = h1/2 + y1;
            px2 = w2/2 + x2;
            py2 = h2/2 + x2;

            

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(px1);
            Console.WriteLine(py1);
            Console.WriteLine(px2);
            Console.WriteLine(py2);
        }
        static void Test2() {
            int time, bf = 6, ws = 3, cof = 4;
            bool food = true;
            string day, menu = "";
            Console.Write("Input day : ");
            day = Console.ReadLine();
            Console.Write("Input time : ");
            time = int.Parse(Console.ReadLine());
            switch (day) {
                case "1": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf <= -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf++;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "2": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf == -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf = -1;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "3": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf == -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf = -1;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "4": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf == -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf = -1;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "5": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf == -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf = -1;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "6": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf == -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf = -1;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            ws--;
                            if (ws <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "7": {
                    Console.Write("Input menu : ");
                    menu = Console.ReadLine();
                    while(menu != "End") {
                        if (menu == "Breakfast Set") {
                            if (time >= 11 || bf == -1) {
                                Console.WriteLine("Sorry your order is not available");
                                bf = -1;
                            }
                            bf--;
                            if (bf == 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Weekend Set") {
                            ws--;
                            if (ws <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        if (menu == "Coffee") {
                            cof--;
                            if (cof <= 0) {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        else {
                            Console.WriteLine("Please enter a valid menu");
                        }
                        Console.Write("Input menu : ");
                        menu = Console.ReadLine();
                    }
                }
                break;
                case "End":
                break;
                default :
                break;
            }
        }
    }


    
