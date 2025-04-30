using System;
using System.Text;

namespace Nice.Label._017.Keygen
{
	public sealed class GClass1
	{
		public const int int_0 = 25;

		private string string_0 = "32";

		private GClass1()
		{
		}

		public static string smethod_0(string code)
		{
			if (code != null)
			{
				return code.Trim().Replace("-", string.Empty).ToUpper();
			}
			return null;
		}

		public static string smethod_1(string code)
		{
			if (code.Length != 25)
			{
				throw new ArgumentException("This Key Number lenght is not valid!");
			}
			StringBuilder stringBuilder = new StringBuilder(29);
			for (int i = 0; i < 25; i++)
			{
				stringBuilder.Append(code[i]);
				if (i % 5 == 4 && i != 24)
				{
					stringBuilder.Append('-');
				}
			}
			return stringBuilder.ToString();
		}

		public static string smethod_2(string code)
		{
			if (code == null)
			{
				throw new ArgumentNullException("code");
			}
			if (string.IsNullOrEmpty(code))
			{
				throw new ArgumentException("Parameter \"code\" can not be empty!", "code");
			}
			if (code.Length > 21)
			{
				throw new ArgumentException("The lenght of the parameter \"code\" is to big!", "code");
			}
			char[] array = new char[25];
			Random random = new Random();
			for (int i = 0; i < 23; i++)
			{
				array[i] = GClass2.smethod_2()[random.Next(GClass2.smethod_2().Length)];
			}
			int num = random.Next(GClass2.smethod_2().Length) + 1;
			while (num % 22 + code.Length > 21 && num % 22 - code.Length < 1)
			{
				num = random.Next(GClass2.smethod_2().Length) + 1;
			}
			array[23] = GClass2.smethod_2()[num - 1];
			array[24] = GClass2.smethod_2()[(num + code.Length) % (GClass2.smethod_2().Length - 1)];
			num %= 22;
			if (num + code.Length > 23)
			{
				for (int num2 = num; num2 > num - code.Length; num2--)
				{
					array[num2] = code[num - num2];
				}
			}
			else
			{
				for (int j = num; j < num + code.Length; j++)
				{
					array[j] = code[j - num];
				}
			}
			return new string(array);
		}

		public static string smethod_3(string code)
		{
			long num = 0L;
			for (int i = 0; i < code.Length; i++)
			{
				if (code[i] >= '0' && code[i] <= 'z')
				{
					num += code[i];
				}
			}
			long num2 = num % 262;
			string string_ = new string(new char[2]
			{
				(char)(num2 / 16 + 65),
				(char)(num2 % 16 + 65)
			});
			GClass2 gClass = new GClass2();
			gClass.method_12(string_);
			return gClass.method_13(0);
		}
	}
}
