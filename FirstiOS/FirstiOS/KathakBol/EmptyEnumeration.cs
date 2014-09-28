using System;
using System.Collections.Generic;
using MonoTouch.UIKit;
using System.Drawing;

namespace FirstiOS
{
	public enum EmptyEnumeration:int
	{
		Max = 4,
		Min = 1

	}
	public enum TablePlayers
	{
		UstadzakirHusain,
		PandityogeshSamsi, 
		Bikramghosh,
		UstadTarikhan,
		Anuradhapad
	}


	public static class Tukda
	{
	//add indexer here
		public static List<ButtonItem>  firstlist=new List<ButtonItem>(8);
		public static List<ButtonItem>  secondlist = new List<ButtonItem>(11) ;
		public static List<ButtonItem>  thirdlist= new List<ButtonItem>(3);
		 
		public static void AddAllButtons()
		{
			firstlist = new List<ButtonItem>(8);
			firstlist.Add (new ButtonItem(Tukda1().Boll,Tukda1().Title));
			firstlist.Add (new ButtonItem(Tukda2().Boll,Tukda2().Title));
			firstlist.Add (new ButtonItem(Tukda3().Boll,Tukda3().Title));
			firstlist.Add (new ButtonItem(Tukda4().Boll,Tukda4().Title));
			firstlist.Add (new ButtonItem(Tukda5().Boll,Tukda5().Title));
			firstlist.Add (new ButtonItem(Tukda6().Boll,Tukda6().Title));
			firstlist.Add (new ButtonItem(ChakradharTukda1().Boll,ChakradharTukda1().Title));
			firstlist.Add (new ButtonItem(ChakradharTukda2().Boll,ChakradharTukda2().Title));

			secondlist = new List<ButtonItem>(11);
			secondlist.Add (new ButtonItem(Tukda21().Boll,Tukda21().Title));
			secondlist.Add (new ButtonItem(Tukda22().Boll,Tukda22().Title));
			secondlist.Add(new ButtonItem(ChakradharTihai().Boll,ChakradharTihai().Title));
			secondlist.Add (new ButtonItem(Palta.Palta1().Boll,Palta.Palta1().Title));
			secondlist.Add (new ButtonItem(Palta.Palta2().Boll,Palta.Palta2().Title));
			secondlist.Add (new ButtonItem(Palta.Palta3().Boll,Palta.Palta3().Title));
			secondlist.Add (new ButtonItem(Palta.Palta4().Boll,Palta.Palta4().Title));
			secondlist.Add (new ButtonItem(Palta.Palta5().Boll,Palta.Palta5().Title));
			secondlist.Add (new ButtonItem(Palta.Palta6().Boll,Palta.Palta6().Title));
			secondlist.Add (new ButtonItem(Paran.Paran1().Boll,Paran.Paran1().Title));
			secondlist.Add (new ButtonItem(Paran.Paran2().Boll,Paran.Paran2().Title));

			thirdlist = new List<ButtonItem>(7);
			thirdlist.Add (new ButtonItem(Palta.Palta7().Boll,Palta.Palta7().Title));
			thirdlist.Add (new ButtonItem(Palta.Palta8().Boll,Palta.Palta8().Title));
			thirdlist.Add (new ButtonItem(Paran.ParanAamad().Boll,Paran.ParanAamad().Title));
			thirdlist.Add (new ButtonItem(Misc.GatBhaav().Boll,Misc.GatBhaav().Title));
			thirdlist.Add (new ButtonItem(Misc.Kavit().Boll,Misc.Kavit().Title));
			thirdlist.Add (new ButtonItem(Taal.JhapTaal().Boll,Taal.JhapTaal().Title));
			thirdlist.Add (new ButtonItem(ThirdYear.JhapTaalTihai1().Boll,ThirdYear.JhapTaalTihai1().Title));
		}
		public static ButtonItem GetFirstYearSyllabus(int index)
		{


			return firstlist[index];

		}
		public static ButtonItem GetSecondYearSyllabus(int index)
		{

			return secondlist[index];

		}
		public static ButtonItem GetThirdYearSyllabus(int index)
		{

			return thirdlist[index];

		}

		public static string TukdaFirstYear()
		{
			return Tukda1().Title + Tukda2().Title + Tukda3().Title + Tukda4().Title + Tukda5().Title + Tukda6().Title;
		}
		public static Bol Tukda1()
		{
			var title = "Tukda1";
			var str = "Tat tat tat tat Digada Dig Dig Thai x 3 \n Digada Dig Dig Thai x 3";
			return new Bol(str,title);

		}
		public static Bol Tukda2()
		{
			var title = "Tukda2";
			var str = "Tat Tat Tram Thai Digada Dig Dig Thai x 3\nDigada Dig Dig Thai x 3";
			return new Bol(str,title);

		}
		public static Bol Tukda3()
		{
			var title = "Tukda3";
			var str = "Tram Thai Tram Thai Digada Dig Dig Thai x 3\nDigada Dig Dig Thai x 3";
			return new Bol(str,title);

		}
		public static Bol Tukda4()
		{
			var title = "Tukda4";
			var str = "Tat Tat Digada Tat Digada Dig Dig Thai x 3\nDigada Dig Dig Thai x 3";
			return new Bol(str,title);

		}
		public static Bol Tukda5()
		{
			var title = "Tukda5";
			var str = "Tat Tat Thun Thun Digada Dig Dig Thai x 3\nDigada Dig Dig Thai x 3";
			return new Bol(str,title);

		}
		public static Bol Tukda6()
		{
			var title = "Tukda6";
			var str = "Tat Tat Thai Digada Dig Dig Thai x 3\nDigada Dig Dig Thai x 3\n";
			return new Bol(str,title);

		}
		public static Bol ChakradharTukda1()
		{
			var title = "Chakradhar Tukda 1";
			var str = "Tram Thai Tram Thai x 1\nDigada Dig Dig Thai Tram Thai x 3\nTram Thai Tram Thai x 1\n" +
				"Digada Dig Dig Thai Tram Thai x 3\nTram Thai Tram Thai x 1\nDigada Dig Dig Thai Tram Thai x 3";
			return new Bol(str,title);

		}
		public static Bol ChakradharTukda2()
		{
			var title = "Chakradhar Tukda 2";
			var str = "Tigada Tigada Thei Tigada Tigada Thei \nTa Thei Thei Tat Aa Thei Thei Tat Thei \nDigada Dig Dig Thei x 3 ";
			return new Bol(str,title);

		}
		public static Bol Tukda21()
		{
			var title = "Tukda 2 1";
			var str = "Ta Thai Thai Tat Aa Thai Thai Tat Thei x 3";
			return new Bol(str,title);

		}
		public static Bol Tukda22()
		{
			var title = "Tukda 2 2";
			var str = "Ta Thai Thai Tat Aa Thai Thai Tat Thei x 3";
			return new Bol(str,title);

		}
		public static Bol Tihai22()
		{
			var title = "Tihai 2 2";
			var str = "Ta Thai Thai Tat Aa Thai Thai Tat Thei x 3";
			return new Bol(str,title);

		}
		public static Bol ChakradharTihai()
		{

			var title = "Chakradhar Tihai";
			var str = "Tigada Tigada Thei Tigada Tigada Thei \nTa Thei Thei Tat Aa Thei Thei Tat Thei \nDigada Dig Dig Thei x 3 ";
			return new Bol(str,title);

		}

	}

	public class ButtonItem:UIButton
	{
		public ButtonItem(string b,string t)
		{
			var i = 1;
			Bol = b;
			SetTitle(t,UIControlState.Normal);

		}
		float h = 50.0f;
		float w = 50.0f;
		float padding = 10.0f;
		public UILabel display = new UILabel();
		public string Bol;
	}

	public class Bol
	{
		public Bol(string b,string t)
		{
			Title = t;
			Boll = b;
		}
		public string Title;
		public string Boll;
	}


	public class Tihai
	{
		public static Bol Tihai1Single()
		{
			var title = "Tihai Single";
			var str = "Ta Thai Thai Tat Aa Thai Thai Tat Thei x 3";
			return new Bol(str,title);

		}
		public static Bol Tihai2SingleDouble()
		{
			var title = "Tihai 2 Single Double ";
			var str = "Ta Thei  \tThei Tat \tAa Thei \tThei Tat\tThei Ta Thei\nTa TheiTheiTat \t\tAa Thei TheiTat \tTheita\t\tThei\n";
			return new Bol(str,title);

		}
		public static Bol ChakradharTihai21()
		{
			var title = "Chakradhar Tihai 2 1";
			var str = "Ta Thei Thei Tat Aa Thei Thei Tat Thai Ta Thei \n1 – Clap x 3";
			return new Bol(str,title);

		}
		public static Bol Tihai1JhapTaal()
		{
			var title = "JhapTaal Tihai 1";
			var str = "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei\n" +
					  "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei\n" +
					  "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei";
			return new Bol(str,title);
		}
		public static Bol Tihai2JhapTaal()
		{
			var title = "JhapTaal Tihai 2";
			var str = "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei SS Ta-Thei Clap Clap\n" +
					  "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei SS Ta-Thei Clap Clap\n" +
					  "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei SS Ta-Thei";
			return new Bol(str,title);

		}


	}

	public class Paran
	{
		public static string ParanSecondyr()
		{
			return Paran1 ().Title + Paran2 ().Title;
		}
		public static Bol Paran1()
		{
			var title = "Paran 1";
			var str = "Gadighina Nagetita\nTaagetirikita Taka\nDhikita Daana Dha \nGadigina Dha x3\nDhikita Daana Dha \nGadigina Dha x3\n" +
				"Dhikita Daana Dha \nGadigina Dha x3\n";
			return new Bol(str,title);

		}
		public static Bol Paran2()
		{
			var title = "Paran 2";
			var str = "Ghin Naka Ghin Naka x1\nDhumakita Dha x2\nKirdha titadha x2\nKa tita ghe ghe tita dhumakita \nKirdha tita x1\n" +
				"Ka ti ta dha, ka ta dha   (1,2,3 after 1st and 2nd) x 3\n";
			return new Bol(str,title);

		}
		public static Bol ParanAamad()
		{
			var title = "Paran Aamad";
			var str = "Dha taka tunga S\nDha ge Dhi ge Dha S\nDha tin ta S\nDhet ta Kirda Dha taka tunga\nTaki tita Ka S\nTiti Kata Gadigina\n" +
				"Ta thei tat tat thei\nAa thei tat tat thei\nThei ta thei ta thei thei thei\nTat tat ta";
			return new Bol(str,title);

		}

	}

	public class Misc
	{
		public static Bol Gat()
		{
			var title = "Gat";
			var str = "";
			return new Bol(str,title);

		}
		public static Bol RangmanchPranaam()
		{
			var title = "Rangmanch Pranaam";
			var str = "Tat tat\nTa Thei Thei Tat\nAa Thei Thei Tat\nTat tat Thei-e\nTat Tat Thei-e\nTat tat thei";
			return new Bol(str,title);
		}
		public static Bol Aamad()
		{
			var Def = "a way of arriving on stage\n";
			var title = "Aamad";
			var str = "Ta thei ta ta thei\nAa thei ta ta thei\nThei – ta thei-ta thei thei thei \nTat tat ta";
			return new Bol(str,title);
		}
		public static Bol GatBhaav()
		{
			var Def = "Story re-enacted to taal in which one dancer plays multiple characters. Starts & ends on sum. ";
			var title = "GatBhaav";
			var str = "";
			return new Bol(str,title);
		}
		public static Bol Kavit()
		{
			var Def = "a poem set to taal. Starts and ends on sum";
			var title = "Kavit";
			var str = "Neer Bharat jamuna that par, jab bhar bhar neera uthaye gagar\nTab dagar chalat, moh chedat langar\n" +
				"Hat jao ji kunwar, phuti jaat gagar\nMohe ched ched madhav, madhav, madhav - 1 2 3} x 3\n";

			return new Bol(str,title);
		}
	}
	public class Taal
	{
		public static  Bol TeenTaalBaraabarSingle()
		{
			var title = "";
			var str = "";
			return new Bol(str,title);		
		}
		public static Bol TeenTaalDhugunDouble()
		{
			var title = "Dhugun Double";
			var str = "DhaDhin\t\tDhinDha \t\tDhaDhin\t\tDhinDha\t|\n     1\t\t\t     2\t\t\t       3\t\t\t         4\n" +
				"DhaTin\t\t\tTinTa\t\t\tTaDhin\t\t\tDhinDha\t|\n    5\t\t\t    6 \t\t\t      7 \t\t\t       8\n" +
				"DhaDhin\t\tDhinDha\t\tDhinDha\t\tDhinDha\n     9 \t\t  \t     10\t\t    \t       11\t \t\t       12\t|\n" +
				"DhaTin\t\t\tTinta\t\t\tTaDhin\t\t\tDhinDha\t|\n    13\t\t\t   14\t\t\t     15\t\t\t       16\n";
			return new Bol(str,title);
		}
		public static Bol TeenTaalChaugunQuadruple()
		{
			var title = "Chaugun Quadruple";
			var str = "DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n     1\t\t\t     2\t\t\t       3\t\t\t         4\n" +
				"DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n    5\t\t\t    6 \t\t\t      7 \t\t\t       8\n" +
				"DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n     9 \t\t  \t     10\t\t    \t       11\t \t\t       12\t\n" +
				"DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n    13\t\t\t   14\t\t\t     15\t\t\t       16\n";
			return new Bol(str,title);

		}
		public static Bol JhapTaal()
		{
			var title = "Jhap Taal";
			var str = "DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n     1\t\t\t     2\t\t\t       3\t\t\t         4\n" +
				"DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n    5\t\t\t    6 \t\t\t      7 \t\t\t       8\n" +
				"DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n     9 \t\t  \t     10\t\t    \t       11\t \t\t       12\t\n" +
				"DhaDhinDhinDha \tDhaDhinDhinDha\tDhaTinTinTa\t\tTaDhinDhinDha \t|\n    13\t\t\t   14\t\t\t     15\t\t\t       16\n";
			return new Bol(str,title);

		}

	}
	public class Palta
	{
		public static string PaltaFirstYear()
		{
			return Palta1().Title + Palta2().Title + Palta3().Title + Palta4().Title + Palta5().Title + Palta6().Title;
		}
		public static string Def()
		{
			return "A Set of rhythmic pattern based around numbers";
		}
		public static Bol Palta1()
		{
			var title = "Palta1";
			var str = "12341234\nRLRLRLRL\n";
			return new Bol(str,title);

		}

		public static Bol Palta2()
		{
			var title = "Palta 2";
			var str = "121234\nRRRLRL\nLeft\n121234\nLLLRLR\n";
			return new Bol(str,title);

		}
		public static Bol Palta3()
		{
			var title = "Palta3";
			var str = "Right\n123 | 1234 | 12341 |\nRRRRLRLLRLRR\n12342 | 12343 | 1234\nRLRLLLRLRRRLRL\n";
			return new Bol(str,title);

		}
		public static Bol Palta4()
		{
			var title = "Palta 4";
			var str = "Right\n1234 1234 12341\nRRRRRLRLLRLRR\n12341 1234 1234\nRLRLLLRLRRLRL\n" +
				"Left\n1234 1234 12341\nLLLLLRLRRLRLL\n12341 1234 1234\nLRLRRRLRLLRLR\n";
			return new Bol(str,title);

		}
		public static Bol Palta5()
		{
			var title = "Palta5";
			var str = "Right\n12345 | Clap | 1234 | 2234 | 32345 | 4234 | 5234 \nRRRRR | RLRL | RLRL | RLRL | RLRL | RLRL\n";
			return new Bol(str,title);

		}
		public static Bol Palta6()
		{
			var title = "Palta 6";
			var str = "Right\nRRRRRR|RLRLL\n123456 | 12341 Clap | \nL RLRR Clap|\n 12341\nRLRL\n1234\n" +
				"Left – \nLLLLL|LRLRR CLAP|\n123456 | 12341\n\nRLRLL CLAP|LRLR\n12341            1234\n";
			return new Bol(str,title);

		}
		public static Bol Palta7()
		{
			var title = "Palta 7";
			var str = "1234567 12341 12341 12341 \n";
			return new Bol(str,title);

		}
		public static Bol Palta8()
		{
			var title = "Palta 8";
			var str = "12345678 12341 12341 1234 \n";
			return new Bol(str,title);

		}

	}
	public class ThirdYear
	{
		public static Bol JhapTaalTihai1()
		{
			var title = "Jhap Taal Tihai 1";
			var str = "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei x 3";
			return new Bol(str,title);

		}
		public static Bol JhapTaalTihai2()
		{
			var title = "Jhap Taal Tihai 2";
			var str = "Ta Thei Thei Tat Aa Thei Thei Tat Thei Ta Thei Ta – Thei x 3\n1(clap) 2(clap)";
			return new Bol(str,title);

		}

	}
	public class Definitions
	{
		public static string Notation()
		{
			return "Writing a composition in a way that shows how the bols in the composition fall on the matras in any rhythmic cycle.";
		}
		public static string Bedum()
		{
			return "Without any gaps or pauses. Eg.JhapTaal Tihai1.";
		}
	}
	public class Thaat
	{
		public static string Def = "How you stand on stage";
		public static Bol Thaat1()
		{
			var title = "Thaat";
			var str = "15-16-1 : Pose\n8 : Breath in \n8 : Down\n15- 16-1 : End";
			return new Bol(str,title);

		}
	}
	public class Gat
	{
		public static string Def="depiction of a gait of a character";
		public static Bol SidhiGat()
		{
			var title = "SidhiGat";
			var str = "Footwork – 16 beats\nPalta (4 circles) – 16 beats\nPose down – 4\n         up – 4\n" +
				"Walk (4 times) – 16 beats\nGo back – 16 beats\nPalta – 16 (end with pose)\nPose – 8 \nSideways – 16  - end\n";
			return new Bol(str,title);

		}
		public static Bol MathkiGat()
		{
			var title = "Mathki Gat";
			var str = "Footwork – 16 beats\nPalta (4 circles) – 16 beats\nPose down – 4\n         up – 4\n" +
				"Walk (4 times) – 16 beats\nGo back – 16 beats\nPalta – 16 (end with pose)\nPose – 8 \nSideways – 16  - end\n";
			return new Bol(str,title);

		}
		public static Bol BasuriGat()
		{
			var title = "Basuri Gat";
			var str = "Footwork – 16 beats\nPalta (4 circles) – 16 beats\nPose down – 4\n         up – 4\n" +
				"Walk (4 times) – 16 beats\nGo back – 16 beats\nPalta – 16 (end with pose)\nPose – 8 \nSideways – 16  - end\n";
			return new Bol(str,title);

		}

	}
	public class Mudras
	{
		public static string listofimages()
		{
			return"image path";
		}
		public static string listofvideos()
		{
			return"video path";
		}
	}

}

