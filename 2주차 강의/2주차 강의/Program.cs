﻿namespace _2주차_강의
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if문
            int playerScore = 80;

            if (playerScore >= 70)
            {
                Console.WriteLine("플레이어의 점수는 70점 이상입니다. 합격입니다!");
            }
            Console.WriteLine("프로그램이 종료됩니다.");

            //else문
            int itemCount = 5;
            string itemName = "HP 포션";

            if (itemCount > 0)
            {
                Console.WriteLine($"보유한 {itemName}의 수량: {itemCount}");
            }
            else
            {
                Console.WriteLine($"보유한 {itemName}이 없습니다.");
            }

            //elseif문
            // int playerScore = 100;
            string playerRank = "";

            if (playerScore >= 90)
            {
                playerRank = "Diamond";
            }
            else if (playerScore >= 80)
            {
                playerRank = "Platinum";
            }
            else if (playerScore >= 70)
            {
                playerRank = "Gold";
            }
            else if (playerScore >= 60)
            {
                playerRank = "Silver";
            }
            else
            {
                playerRank = "Bronze";
            }

            Console.WriteLine("플레이어의 등급은 " + playerRank + "입니다.");

            //중첩 조건문
            int itemLevel = 3; // 아이템 레벨
            string itemType = "Weapon"; // 아이템 종류

            if (itemType == "Weapon")
            {
                if (itemLevel == 1)
                {
                    // 레벨 1 무기 효과
                    Console.WriteLine("공격력이 10 증가했습니다.");
                }
                else if (itemLevel == 2)
                {
                    // 레벨 2 무기 효과
                    Console.WriteLine("공격력이 20 증가했습니다.");
                }
                else
                {
                    // 그 외 무기 레벨
                    Console.WriteLine("잘못된 아이템 레벨입니다.");
                }
            }
            else if (itemType == "Armor")
            {
                if (itemLevel == 1)
                {
                    // 레벨 1 방어구 효과
                    Console.WriteLine("방어력이 10 증가했습니다.");
                }
                else if (itemLevel == 2)
                {
                    // 레벨 2 방어구 효과
                    Console.WriteLine("방어력이 20 증가했습니다.");
                }
                else
                {
                    // 그 외 방어구 레벨
                    Console.WriteLine("잘못된 아이템 레벨입니다.");
                }
            }
            else
            {
                // 그 외 아이템 종류
                Console.WriteLine("잘못된 아이템 종류입니다.");
            }

            //switch문
            Console.WriteLine("게임을 시작합니다.");
            Console.WriteLine("1: 전사 / 2: 마법사 / 3: 궁수");
            Console.Write("직업을 선택하세요: ");
            string job = Console.ReadLine();

            switch (job)
            {
                case "1":
                    Console.WriteLine("전사를 선택하셨습니다.");
                    break;
                case "2":
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    break;
                case "3":
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    break;
                default:
                    Console.WriteLine("올바른 값을 입력해주세요.");
                    break;
            }

            Console.WriteLine("게임을 종료합니다.");

            //삼항연산자
            int currentExp = 1200;
            int requiredExp = 2000;

            string result = (currentExp >= requiredExp) ? "레벨업 가능" : "레벨업 불가능";
            Console.WriteLine(result);

            if (currentExp >= requiredExp)
            {
                Console.WriteLine("레벨업 가능");
            }
            else
            {
                Console.WriteLine("레벨업 불가능");
            }
        }
    }
}
