using System;
using System.Text;

namespace Nice.Label._017.Keygen
{
	public class GClass7
	{
		public const int int_0 = 25;

		private bool bool_0;

		private int int_1;

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		[NonSerialized]
		private string string_4 = "32";

		public GClass7(string code)
		{
			string_0 = GClass1.smethod_0(code);
			if (method_7())
			{
				string_2 = smethod_0(code);
				bool_0 = true;
			}
		}

		public string method_0()
		{
			return string_0;
		}

		public string method_1()
		{
			if (string_1 == null)
			{
				string_1 = GClass1.smethod_1(string_0);
			}
			return string_1;
		}

		public string method_2()
		{
			return string_2;
		}

		public int method_3()
		{
			if (int_1 == 0)
			{
				if (!(string_2.Substring(string_2.Length - 2) == "XX") && !(string_2.Substring(string_2.Length - 2) == "XY"))
				{
					int_1 = method_6(string_2.Substring(0, string_2.Length - 2));
				}
				else
				{
					int_1 = method_6(string_2.Substring(0, string_2.Length - 6));
				}
			}
			return int_1;
		}

		public string method_4()
		{
			if (string_3 == null)
			{
				if (!(string_2.Substring(string_2.Length - 2) == "XX") && !(string_2.Substring(string_2.Length - 2) == "XY"))
				{
					string_3 = string_2.Substring(string_2.Length - 2, 2);
				}
				else
				{
					string_3 = string_2.Substring(string_2.Length - 6, 2);
				}
			}
			return string_3;
		}

		public bool method_5()
		{
			return bool_0;
		}

		private int method_6(string machineCode)
		{
			if (machineCode == null)
			{
				throw new ArgumentNullException("machineCode");
			}
			GClass2 gClass = new GClass2();
			gClass.method_14(machineCode);
			return (int)gClass.method_1()[0];
		}

		private bool method_7()
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (GClass2.smethod_2().IndexOf(string_0[i]) == -1)
				{
					return false;
				}
			}
			return true;
		}

		public static string Reverse(string s)
		{
			char[] array = s.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}

		public static string smethod_0_Reverse(bool reverse_order, string to_bethere)
		{
			int num = 23;
			string text = "F" + to_bethere;
			string text2 = new string('g', num - text.Length);
			text += text2;
			int index = 1;
			int length = text.Length;
			char c = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7"[index];
			char c2 = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7"[length];
			return text + c + c2;
		}

		public static string smethod_0(string registrationNumber)
		{
			if (registrationNumber.Length != 25)
			{
				return null;
			}
			char[] array = registrationNumber.ToCharArray();
			int num = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".IndexOf(array[23]) + 1;
			if (num == 0)
			{
				return null;
			}
			int num2 = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".IndexOf(array[24]) + 1;
			if (num2 == 0)
			{
				return null;
			}
			num2 = ((num2 <= num) ? (num2 - (num - "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length + 2)) : (num2 - (num + 1)));
			num %= 22;
			StringBuilder stringBuilder = new StringBuilder(num2);
			if (num + num2 > 23)
			{
				if (num - num2 < 0)
				{
					return null;
				}
				for (int num3 = num; num3 > num - num2; num3--)
				{
					stringBuilder.Append(array[num3]);
				}
			}
			else
			{
				for (int i = num; i < num + num2; i++)
				{
					stringBuilder.Append(array[i]);
				}
			}
			return stringBuilder.ToString();
		}

		public static string smethod_1(string name, string company, string computerName)
		{
			string text = GClass1.smethod_3(computerName) + GClass1.smethod_3(name + company);
			GClass2 gClass = new GClass2();
			gClass.method_1()[0] = (ulong)new Random().Next(256);
			return text + gClass.method_13(2) + "XY";
		}

		public static string smethod_2(string domainName)
		{
			string text = GClass1.smethod_3(domainName);
			GClass2 gClass = new GClass2();
			gClass.method_1()[0] = (ulong)new Random().Next(256);
			return text + gClass.method_13(2) + "XY";
		}

		public static bool smethod_3(string string_5, string string_6, string string_7, string string_8)
		{
			string text = GClass1.smethod_3(string_8);
			text += GClass1.smethod_3(string_6 + string_7);
			string text2 = new GClass7(string_5).method_2();
			if (!(text2.Substring(text2.Length - 2) == "XX") && !(text2.Substring(text2.Length - 2) == "XY"))
			{
				return text2 == text;
			}
			return text2.Substring(0, text2.Length - 4) == text;
		}

		public static bool smethod_4(string regNumber, string domainName)
		{
			GClass7 gclass7_ = new GClass7(regNumber);
			string string_ = GClass1.smethod_3(domainName);
			if (smethod_7(gclass7_, string_))
			{
				return true;
			}
			string_ = GClass1.smethod_3(domainName.ToUpperInvariant());
			if (smethod_7(gclass7_, string_))
			{
				return true;
			}
			string_ = GClass1.smethod_3(domainName.ToLowerInvariant());
			return smethod_7(gclass7_, string_);
		}

		public static string smethod_5(string name, string company, string computerName)
		{
			return GClass1.smethod_2(smethod_1(name, company, computerName));
		}

		public static string smethod_6(string domainName)
		{
			return GClass1.smethod_2(smethod_2(domainName));
		}

		private static bool smethod_7(GClass7 gclass7_0, string string_5)
		{
			string text = gclass7_0.method_2();
			if (!(text.Substring(text.Length - 2) == "XX") && !(text.Substring(text.Length - 2) == "XY"))
			{
				return text == string_5;
			}
			return text.Substring(0, text.Length - 4) == string_5;
		}
	}
}
