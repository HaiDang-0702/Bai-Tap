using System;
using System.Diagnostics.CodeAnalysis;
using System.Timers;

namespace Bai_Tap
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Bài 1:
			/*
			Console.Write("Nhap so nguyen n = ");
			int n = int.Parse(Console.ReadLine());

			if (n % 3 == 0)
			{
				Console.WriteLine("n là số chia hết cho 3");
			}
			else
			{
				Console.WriteLine(" n là số không chia hết cho 3 ");
			}
			Console.ReadKey();
			*/

			//Bài 2:
			/*
			Console.Write("Nhap vao so nguyen = ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Bang cuu chuong thu {i}:");
				for(int j = 1; j <= 10; j++) 
				{
					Console.WriteLine($"{i} * {j} = {i * j}");
				}
			}
			*/

			//Bài 3: 
			/*
			Console.Write("Nhap so nguyen n = ");
			int n = int.Parse(Console.ReadLine());
			int mul = 1;
			for(var i = 1; i <= n; i++)
			{
				mul *= i;
			}
			Console.WriteLine($"Ket qua cua {n}! la {mul}");
			*/

			//Bài 4:

			/*
			Console.Write("\nNhap vao so nguyen n: ");
			int n = int.Parse(Console.ReadLine());
			int sqrt = (int)Math.Sqrt(n);
			if (sqrt * sqrt == n)
			{
				Console.WriteLine($"{n} la so chinh phuong");
			}
			else
			{
				Console.WriteLine($"{n} khong phai la so chinh phuong");
			}
			*/

			//Bài 5:
			/*
			Console.Write("Nhap vao thang: ");
			int month = int.Parse(Console.ReadLine());

			switch(month)
			{
				case 1: case 3: case 5: case 7: case 8: case 10: case 12:
					Console.WriteLine($"Thang {month} co 31 ngay");
					break;

				case 4: case 6: case 9: case 11:
					Console.WriteLine($"Thang {month} co 30 ngay");
					break;

				case 2:
					Console.WriteLine($"Thang {month} co 28 hoac 29 ngay");
					break;

				default:
					Console.WriteLine("Thang khong hop le");
					break;
			}
			*/

			//Bài 6:

			/*
			Console.Write("Nhap so nguyen n = ");
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				sum += (int)Math.Pow(i, i);
			}
			Console.WriteLine(sum);
			*/

			//Bài 7:
			/*
			Console.Write("Nhap vao so nguyen n = ");
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			var str = "";
			for (int i = 1; i <= n; i += 2)			
			{
				sum += i;	
				
				if( i == n)
				{
					str = str + $"{i} = {sum}";
				}
				else
				{
					str = str + $"{i} + "; 
				}
			}
			
			Console.WriteLine($"Tong cac so le tu 1 den {n} la : {str}");
			*/

			// Bài 8:

			//Console.Write("\nNhap vao so nguyen n: ");
			//int n = int.Parse(Console.ReadLine());

			//if (n < 2)
			//{
			//	Console.WriteLine("Khong co so nguyen to nao");
			//	return;
			//}
			//for (int i = 2; i <= n; i++)
			//{
			//	bool isPrime = true;
			//	for (int j = 2; j <= Math.Sqrt(i); j++)
			//	{
			//		if (i % j == 0)
			//		{
			//			isPrime = false;
			//			break;
			//		}
			//	}
			//	if (isPrime)
			//	{

			//		Console.Write($"{i} ");
			//	}
			//}

			// Bài 9:

			//Console.Write("Nhap vao so hang: ");
			//int n = int.Parse(Console.ReadLine());
			//for (int i = 1; i <= n; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//tam giac xoay nguoc
			//for (int i = n; i >= 1; i--)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			// Bài 10: 
			Console.Write("Nhap vao so nguyen: ");
			int n = int.Parse(Console.ReadLine());
			if (n < 0) return;
			int n1 = 0, n2 = 1, n3;
			Console.Write($"Day Fibonacci tu 1 den {n} la: ");
			Console.Write(n1 + " " + n2 + " ");

			for (int i = 2; i < n; i++)
			{
				n3 = n1 + n2;
				Console.Write(n3 + " ");
				n1 = n2;
				n2 = n3;
			}
			Console.WriteLine();








		}
	}
}
