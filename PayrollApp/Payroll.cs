/*
 * Created by SharpDevelop.
 * User: student
 * Date: 09/11/2021
 * Time: 09:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PayrollApp
{
	/// <summary>
	/// Description of Payroll:
	/// We input into all calculation here nad this class will handle it
	/// </summary>
	public class Payroll
	{
		private decimal Gross, paye, usc, prsi, netpay;
		private const decimal LowerTaxRate=0.2m;
		private decimal taxCredit=0m;
		private decimal higherTaxRate=0.4m;
		private decimal singleTax = 63.57m;
		private decimal marriedTax = 95.119m;
		private decimal prsiRate = 0.04m;
		
		
		public Payroll(){
			//default constructor
		}
		
		public decimal CalclateGross(decimal h, decimal r){
			return Gross = h*r;
		}
		
		public decimal CalculatePRSI(){
			return prsi = Gross*prsiRate;
		}
		
		
		public void DisplayPaySlip(){
			Console.WriteLine("\t=========== Weekly Earnings ===========");
			Console.WriteLine("\tYour Gross income is \t\t" + Gross.ToString("f"));
			Console.WriteLine("\tYour Paye is \t\t" + paye.ToString("f"));
			Console.WriteLine("\tYour PRSI is \t\t" + prsi.ToString("f"));
			Console.WriteLine("\tYour USC is \t\t" + usc.ToString("f"));
			Console.WriteLine("\tYour Net pay is \t\t" + netpay.ToString("f"));
			
		}
		
		public decimal CalculatePAYE(int s){
			
			if(s==1)
			{
				taxCredit=singleTax;
			}
			else
			{
				taxCredit=marriedTax;
			}
			
			if ((Gross-taxCredit>taxCredit)&&(Gross<=678.85m))
			{
				paye = (Gross*LowerTaxRate)-taxCredit;
			}
			else if (Gross>678.85m)
			{
				paye = 135.77m + ((Gross-678.85m)*higherTaxRate)-taxCredit;
			}
			else
			{
				paye=0m;
			}
			return paye;
		}
		
		public decimal CalculateUSC (){
			if((Gross > 250) && (Gross <= 382))
			{	
				usc = (Gross-231) * 0.02m+1.16m;
			}
			else if ((Gross > 382) && (Gross <1347))
			{
				usc = (Gross - 382) * 0.045m + (1.16m + 3.02m);
			}
			else 
			{
				usc = ((Gross-1347) * 0.08m) + 1.16m +3.02m + 43.42m;
			}
			return usc;
		}
		
		public decimal CalculateNetPay(){
			
			return netpay = Gross - prsi - paye - usc;
			
		}
		
		
	}
}
