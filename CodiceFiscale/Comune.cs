/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/05/2023
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace CodiceFiscale
{
	/// <summary>
	/// Description of Comune.
	/// </summary>
	public static class Comune
	{
		private static readonly string cod_catasto_path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"cod_catasto.txt");
		
		private static List<String> read_file() {
			return File.ReadAllLines(cod_catasto_path).ToList();
		}
		public static string GetCodiceCatastale(string comune) {
			var cod_catast_lines = read_file();

			return cod_catast_lines.Where(line => line.Split(';')[1] == comune).ElementAt(0).Split(';')[0];
		}
		
		public static string GetComune(string codice) {
			var cod_catast_lines = read_file();

			return cod_catast_lines.Where(line => line.Split(';')[0] == codice).FirstOrDefault().Split(';')[1];
		}
	}
}
