/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/05/2023
 * Time: 12:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodiceFiscale
{
	/// <summary>
	/// Description of Mesi.
	/// </summary>
	public class Mesi
	{
		private readonly Dictionary<string, char> mesi = new Dictionary<string, char>();
		public void Init() {
			mesi.Add("gennaio", 'A');
			mesi.Add("febbraio", 'B');
			mesi.Add("marzo", 'C');
			mesi.Add("aprile", 'D');
			mesi.Add("maggio", 'E');
			mesi.Add("giugno", 'H');
			mesi.Add("luglio", 'L');
			mesi.Add("agosto", 'M');
			mesi.Add("settembre", 'P');
			mesi.Add("ottobre", 'R');
			mesi.Add("novembre", 'S');
			mesi.Add("dicembre", 'T');
		}
		
		private readonly Dictionary<string, int> mesi_number = new Dictionary<string, int> () {
			{"gennaio", 1},
			{"febbraio", 2},
			{"marzo", 3 },
			{"aprile", 4},
			{"maggio", 5 },
			{"giugno", 6 },
			{"luglio", 7 },
			{"agosto", 8 },
			{"settembre", 9},
			{"ottobre", 10 },
			{"novembre", 11 },
			{"dicembre", 12 }
		};
		
		public bool IsEmpty() {
			try{
				return (mesi["gennaio"] == null);	
			}catch(Exception) {
				return true;
			}

		}
		public string Get_Mese_Code(string mese) {
			return mesi[mese].ToString();
		}
		
		public string Get_Mese_From_Code(char mese_char) {
			return mesi.Where(mese_from_dictionary => mese_from_dictionary.Value == mese_char).ElementAt(0).Key;
		}
		
		public int GetMeseNumber(string mese) {
			return mesi_number[mese];
		}
	}
}
