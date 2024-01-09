/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/05/2023
 * Time: 13:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace CodiceFiscale
{
	/// <summary>
	/// Description of CifraControllo.
	/// </summary>
	public static class CifraControllo
	{
		private static Hashtable cifre_dispari = new Hashtable() {
			{"0" , 1},
			{"1", 0},
			{"2", 5},
			{"3", 7},
			{"4", 9 },
			{"5", 13},
			{"6", 15},
			{"7", 17},
			{"8", 19},
			{"9", 21},
			{"A", 1},
			{"B", 0},
			{"C", 5},
			{"D", 7},
			{"E", 9},
			{"F", 13},
			{"G", 15},
			{"H", 17},
			{"I", 19},
			{"J", 21},
			{"K", 2 },
			{"L", 4 },
			{"M", 18},
			{"N", 20},
			{"O", 11},
			{"P" , 3 },
			{"Q", 6},
			{"R", 8 },
			{"S", 12 },
			{"T", 14},
			{"U", 16},
			{"V", 10},
			{"W", 22 },
			{"X", 25 },
			{"Y", 24 },
			{"Z", 23 }
		};
  		static String alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  		
  		private static List<char> caratteri_dispari(string cf) {
  			int index = 0;
  			List<char> dispari = new List<char>();
  			foreach(var carattere in cf) {
  				if(index % 2 != 0)
  					dispari.Add(carattere);
  			}
  			return dispari;
  		}
  		
  		  		private static List<char> caratteri_pari(string cf) {
  			int index = 0;
  			List<char> pari = new List<char>();
  			foreach(var carattere in cf) {
  				if(index % 2 == 0)
  					pari.Add(carattere);
  			}
  			return pari;
  		}
  		public static char CodiceControllo(string cf) {
  			var dispari = caratteri_dispari(cf);
  			var pari = caratteri_pari(cf);
  			var sum = 0;
  			foreach(var carattere in dispari) {
  				sum += int.Parse(cifre_dispari[carattere].ToString());
  			}
  			
  			foreach(var carattere in pari) {
  				try{
  					sum += int.Parse(carattere.ToString());
  				}catch(Exception){
  					sum += alfabeto.IndexOf(carattere);
  				}
  			}
  			float cifra = sum/26;
  			var cifra_approx = cifra - Math.Truncate(cifra);
  			int lettera = 0;
  			if(cifra_approx > 0.5){
  				lettera = int.Parse(cifra.ToString()) + 1;
  			}else {
  				lettera = int.Parse(cifra.ToString()) + 1;
  			}
  			return alfabeto[lettera];
  			
  		}
	}
}
