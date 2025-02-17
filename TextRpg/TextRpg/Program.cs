﻿class Program
{
    //기본 정보
    static int attackPower = 10;
    static int defensePower = 5;
    static int health = 100;
    static int gold = 1500;
    static List<string> inventory = new List<string>(); //인벤토리 리스트
    static Dictionary<string, (int attack, int defense, int price)> shopItems = new Dictionary<string, (int, int, int)> //상점 아이템 리스트 디렉토리
    {
        { "수련자 갑옷", (0, 5, 1000) },
        { "무쇠갑옷", (0, 9, 0) },
        { "스파르타의 갑옷", (0, 15, 3500) },
        { "낡은 검", (2, 0, 600) },
        { "청동 도끼", (5, 0, 1500) },
        { "스파르타의 창", (7, 0, 0) },
        { "개발자의 눈물", (20,20,15000) }
    };
    static List<string> equippedItems = new List<string>(); //아이템 관리

    static void Main()
    {
        while (true) //게임 시작
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 휴식하기");
            Console.Write("원하시는 행동을 입력해주세요: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": ShowStatus(); break;
                case "2": ShowInventory(); break;
                case "3": OpenShop(); break;
                case "4": RestMenu(); break;
                default: Console.WriteLine("잘못된 입력입니다."); Console.ReadKey(); break;
            }
        }
    }

    static void ShowStatus() //상태 보기
    {
        Console.Clear();
        Console.WriteLine("상태 보기");
        Console.WriteLine("Lv. 01");
        Console.WriteLine("Chad ( 전사 )");
        int totalAttack = attackPower;
        int totalDefense = defensePower;
        foreach (var item in equippedItems)
        {
            totalAttack += shopItems[item].attack;
            totalDefense += shopItems[item].defense;
        }
        Console.WriteLine($"공격력 : {totalAttack}");
        Console.WriteLine($"방어력 : {totalDefense}");
        Console.WriteLine($"체 력 : {health}");
        Console.WriteLine($"Gold : {gold} G");
        Console.WriteLine("0. 나가기");
        Console.ReadKey();
    }

    static void ShowInventory()
    {
        Console.Clear();
        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine("[아이템 목록]");

        for (int i = 0; i < inventory.Count; i++)
        {
            string equipped = equippedItems.Contains(inventory[i]) ? "[E] " : ""; //아이템이 장착 되어있는지 확인 할 수 있도록.
            Console.WriteLine($"- {i + 1} {equipped}{inventory[i]}");
        }

        Console.WriteLine("1. 장착 관리");
        Console.WriteLine("0. 나가기");
        Console.Write("원하시는 행동을 입력해주세요: ");

        string input = Console.ReadLine();
        if (input == "1")
            EquipmentManagement();
    }

    static void EquipmentManagement()//장비 관리 클래스
    {
        Console.Clear();
        Console.WriteLine("인벤토리 - 장착 관리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

        for (int i = 0; i < inventory.Count; i++)
        {
            string equipped = equippedItems.Contains(inventory[i]) ? "[E] " : "";
            Console.WriteLine($"- {i + 1} {equipped}{inventory[i]}");
        }

        Console.WriteLine("0. 나가기");
        Console.Write("장착할 아이템 번호를 입력해주세요: ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= inventory.Count)
        {
            string selectedItem = inventory[choice - 1]; //배열은 0부터 이므로, 인덱스 조정.

            if (equippedItems.Contains(selectedItem))
            {
                equippedItems.Remove(selectedItem);
                Console.WriteLine($"{selectedItem}의 장착을 해제했습니다.");
            }
            else
            {
                equippedItems.Add(selectedItem);
                Console.WriteLine($"{selectedItem}을(를) 장착했습니다.");
            }
        }
        else if (choice != 0)
        {
            Console.WriteLine("잘못된 입력입니다.");
        }

        Console.ReadKey();
    }


    static void OpenShop() //상점 클래스
    {
        Console.Clear();
        Console.WriteLine("상점");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
        Console.WriteLine($"[보유 골드] {gold} G");
        Console.WriteLine("[아이템 목록]");
        int index = 1;
        foreach (var item in shopItems)
        {
            string status = inventory.Contains(item.Key) ? "구매완료" : $"{item.Value.price} G";
            Console.WriteLine($"- {index}. {item.Key} | 공격력 +{item.Value.attack} | 방어력 +{item.Value.defense} | {status}");
            index++;
        }
        Console.WriteLine("1. 아이템 구매");
        Console.WriteLine("0. 나가기");
        Console.Write("원하시는 행동을 입력해주세요: ");
        string choice = Console.ReadLine();
        if (choice == "1") BuyItem();
    }

    static void BuyItem()
    {
        Console.Clear();
        Console.WriteLine("아이템 구매");
        Console.WriteLine("구매 가능한 아이템을 선택하세요.");
        int index = 1;
        foreach (var item in shopItems)
        {
            string status = inventory.Contains(item.Key) ? "구매완료" : $"{item.Value.price} G";
            Console.WriteLine($"- {index}. {item.Key} | 공격력 +{item.Value.attack} | 방어력 +{item.Value.defense} | {status}");
            index++;
        }
        Console.Write("구매할 아이템 번호를 입력하세요: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= shopItems.Count)
        {
            string selectedItem = new List<string>(shopItems.Keys)[choice - 1];
            if (inventory.Contains(selectedItem))
            {
                Console.WriteLine("이미 구매한 아이템입니다.");
            }
            else if (gold >= shopItems[selectedItem].price)
            {
                gold -= shopItems[selectedItem].price;
                inventory.Add(selectedItem);
                Console.WriteLine("구매를 완료했습니다.");
            }
            else
            {
                Console.WriteLine("Gold 가 부족합니다.");
            }
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다.");
        }
        Console.ReadKey();
    }

    static void RestMenu() //휴식 메뉴
    {
        Console.Clear();
        Console.WriteLine($"500 G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {gold} G)");
        Console.WriteLine();
        Console.WriteLine("1. 휴식하기");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("원하시는 행동을 입력해주세요: ");
        
        string input = Console.ReadLine();

        switch (input)
        {
            case "1": Rest(); break;
            case "0": return;
            default: Console.WriteLine("잘못된 입력입니다."); Console.ReadKey(); break;
        }

    }
    static void Rest()
    {
        if (gold >= 500)
        {
            gold -= 500;
            health = 100;
            Console.WriteLine("휴식을 완료했습니다.");
        }
        else
        {
            Console.WriteLine("Gold 가 부족합니다.");
        }
    }
}
