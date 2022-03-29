/*
 * Created by SharpDevelop.
 * User: Liam Moss
 * Date: 09/11/2021
 * Time: 09:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PayrollApp
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Liam's Payroll app");
			Console.WriteLine("Enter your hours:");
			decimal hour = Convert.ToDecimal(Console.ReadLine());
			
			
			Console.WriteLine("Enter your rate:");
			decimal rate = Convert.ToDecimal(Console.ReadLine());
			
			
			//Setup an Payrool object
			//Object initiated wiht the default constructor
			Payroll LiamPayroll = new Payroll();
			
			LiamPayroll.CalclateGross(hour,rate);
			LiamPayroll.CalculatePRSI();
			Console.WriteLine("Are you: \n1] Single \n2]Married");
			int statrel = Convert.ToInt32(Console.ReadLine()); //Status of Relationship
			LiamPayroll.CalculatePAYE(statrel);
			LiamPayroll.CalculateUSC();
			LiamPayroll.CalculateNetPay();
			LiamPayroll.DisplayPaySlip();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}