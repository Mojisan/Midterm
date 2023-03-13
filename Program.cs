using System;
    class Program {
        static void Main(string[] args)
        {
            Test1();
            //Test2();
        }

        static void Test1() {
            int x1,y1,w1,h1,x2,y2,w2,h2; //ค่าแรกเริ่ม
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

            int plx1,prx1,poy1,puy1,hx1,hy1;
            hx1 = w1/2;
            hy1 = h1/2;
            plx1 = x1 - hx1;
            prx1 = x1 + hx1;
            poy1 = y1 + hy1;
            puy1 = y1 - hy1;

            int plx2,prx2,poy2,puy2,hx2,hy2;
            hx2 = w2/2;
            hy2 = h2/2;
            plx2 = x2 - hx2;
            prx2 = x2 + hx2;
            poy2 = y2 + hy2;
            puy2 = y2 - hy2;

            if (prx1 > plx2 && poy1 > puy2) {
                Console.WriteLine("abc");
            }
            if (plx1 < prx2 && puy1 < poy2) {
                Console.WriteLine("abc");
            }
            if (prx1 > plx2 && poy1 > puy2) {
                Console.WriteLine("abc");
            }
            if (prx1 < plx2 && puy1 < poy2) {
                Console.WriteLine("abc");
            }
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


    
