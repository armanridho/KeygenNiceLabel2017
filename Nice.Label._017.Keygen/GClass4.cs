using System;
using System.Globalization;
using System.Text;

namespace Nice.Label._017.Keygen
{
	public class GClass4 : GInterface0
	{
		private bool bool_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private KeyNumberOptions keyNumberOptions_0;

		private KeyNumberType keyNumberType_0;

		private KeyNumberVersion keyNumberVersion_0;

		private LicenseType licenseType_0;

		private OemType oemType_0;

		private SoftwareType softwareType_0;

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;

		private string string_6;

		[NonSerialized]
		private string string_7 = "32";

		private VersionType versionType_0;

		public GClass4(string code)
		{
			if (code == null)
			{
				throw new ArgumentNullException("code");
			}
			method_2(code);
			method_4();
		}

		public GClass4(GStruct0 gstruct0_0)
		{
			method_1(gstruct0_0);
			method_3();
		}

		public string imethod_0()
		{
			return string_0;
		}

		public string imethod_1()
		{
			if (string_1 == null)
			{
				string_1 = GClass1.smethod_1(string_0);
			}
			return string_1;
		}

		public KeyNumberOptions imethod_10()
		{
			return keyNumberOptions_0;
		}

		public int imethod_11()
		{
			return int_2;
		}

		public int imethod_12()
		{
			return int_3;
		}

		public bool imethod_13()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.Demo) == KeyNumberOptions.Demo;
		}

		public bool imethod_14()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.Runtime) == KeyNumberOptions.Runtime;
		}

		public bool imethod_15()
		{
			if (keyNumberVersion_0 == KeyNumberVersion.V3)
			{
				return softwareType_0 == SoftwareType.SDK;
			}
			return (keyNumberOptions_0 & KeyNumberOptions.Sdk) == KeyNumberOptions.Sdk;
		}

		public bool imethod_16()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.DealerDemo) == KeyNumberOptions.DealerDemo;
		}

		public bool imethod_17()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.SingleUser) == KeyNumberOptions.SingleUser;
		}

		public bool imethod_18()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.Dongle) == KeyNumberOptions.Dongle;
		}

		public bool imethod_19()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.SoftwareKey) == KeyNumberOptions.SoftwareKey;
		}

		public KeyNumberVersion imethod_2()
		{
			return keyNumberVersion_0;
		}

		public bool imethod_20()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.MaxCutOnly) == KeyNumberOptions.MaxCutOnly;
		}

		public bool imethod_21()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.SoftwareKey) == KeyNumberOptions.SoftwareKey;
		}

		public bool imethod_22()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.MaxCutOnly) == KeyNumberOptions.MaxCutOnly;
		}

		public bool imethod_23()
		{
			return true;
		}

		public bool imethod_24()
		{
			return true;
		}

		public bool imethod_25()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.PrintersLimited) == KeyNumberOptions.PrintersLimited;
		}

		public bool imethod_26()
		{
			return (keyNumberOptions_0 & KeyNumberOptions.Trial) == KeyNumberOptions.Trial;
		}

		public bool imethod_27()
		{
			return bool_0;
		}

		public string imethod_28()
		{
			if (string_6 == null)
			{
				if (!imethod_27())
				{
					throw new InvalidOperationException("Key Number is not in valid state!");
				}
				string_6 = GClass1.smethod_3(string_0);
			}
			return string_6;
		}

		public KeyNumberType imethod_3()
		{
			return keyNumberType_0;
		}

		public OemType imethod_4()
		{
			return oemType_0;
		}

		public SoftwareType imethod_5()
		{
			return softwareType_0;
		}

		public LicenseType imethod_6()
		{
			return licenseType_0;
		}

		public int imethod_7()
		{
			return int_0;
		}

		public VersionType imethod_8()
		{
			return versionType_0;
		}

		public int imethod_9()
		{
			return int_1;
		}

		public int method_0()
		{
			if ((keyNumberOptions_0 & KeyNumberOptions.PrinterCountLimit10) == KeyNumberOptions.PrinterCountLimit10)
			{
				return 10;
			}
			if ((keyNumberOptions_0 & KeyNumberOptions.Dongle) == KeyNumberOptions.Dongle)
			{
				return 3;
			}
			if ((keyNumberOptions_0 & KeyNumberOptions.SingleUser) == KeyNumberOptions.SingleUser)
			{
				return 5;
			}
			return 0;
		}

		private void method_1(GStruct0 gstruct0_0)
		{
			keyNumberVersion_0 = gstruct0_0.method_0();
			keyNumberType_0 = gstruct0_0.method_2();
			oemType_0 = gstruct0_0.method_4();
			softwareType_0 = gstruct0_0.method_6();
			licenseType_0 = gstruct0_0.method_8();
			int_0 = gstruct0_0.method_10();
			versionType_0 = gstruct0_0.method_12();
			int_1 = gstruct0_0.method_14();
			keyNumberOptions_0 = gstruct0_0.method_16();
			int_2 = gstruct0_0.method_18();
			int_3 = gstruct0_0.method_20();
			string_5 = gstruct0_0.method_22();
		}

		private string method_10(string keyNumberCode)
		{
			string_5 = method_12();
			if (string_5.Length == 2 && method_11())
			{
				int num = GClass2.smethod_2().IndexOf(string_5[0]);
				if (num == -1)
				{
					throw new ArgumentException("Prefix error!");
				}
				num = (int)(num - keyNumberVersion_0);
				if (num < 0)
				{
					num += GClass2.smethod_2().Length;
				}
				return string_5[0].ToString() + string_5[1] + keyNumberCode + GClass2.smethod_2()[num];
			}
			Random random = new Random();
			int num2 = random.Next(GClass2.smethod_2().Length);
			keyNumberCode += GClass2.smethod_2()[num2];
			num2 = (int)(num2 + keyNumberVersion_0);
			if (num2 > GClass2.smethod_2().Length)
			{
				num2 -= GClass2.smethod_2().Length;
			}
			return GClass2.smethod_2()[num2] + GClass2.smethod_2()[random.Next(GClass2.smethod_2().Length)] + keyNumberCode;
		}

		private bool method_11()
		{
			for (int i = 0; i < string_5.Length; i++)
			{
				if (GClass2.smethod_2().IndexOf(string_5[i]) == -1)
				{
					return false;
				}
			}
			return true;
		}

		private string method_12()
		{
			char c;
			char c2;
			if (keyNumberVersion_0 == KeyNumberVersion.V3)
			{
				if (string_5 != null && method_11())
				{
					return string_5;
				}
				c = 'V';
				c2 = '7';
			}
			else
			{
				switch (oemType_0)
				{
				case OemType.Nice:
					c = method_13();
					break;
				case OemType.Tyco:
					c = method_15();
					break;
				case OemType.Bsi:
					c = method_16();
					break;
				case OemType.Avery:
					c = method_14();
					break;
				default:
					throw new NotImplementedException("Prefix for this OEMType is not implemented!");
				}
				if (keyNumberType_0 != KeyNumberType.UpgradeLicense)
				{
					if (licenseType_0 != LicenseType.Network && keyNumberType_0 != KeyNumberType.LicensePack)
					{
						c2 = 'F';
						if (imethod_14())
						{
							c2 = 'P';
						}
						else if (imethod_17())
						{
							c2 = 'W';
						}
						else if (imethod_16())
						{
							c2 = 'D';
						}
						else if (imethod_26())
						{
							c2 = 'T';
						}
					}
					else
					{
						switch (int_1)
						{
						case 5:
							c2 = '5';
							break;
						case 10:
							c2 = '6';
							break;
						case 20:
							c2 = '7';
							break;
						case 50:
							c2 = '8';
							break;
						case 9999:
							c2 = '9';
							break;
						default:
							throw new NotImplementedException("Prefix for this number of licenses is not implemented!");
						}
					}
				}
				else
				{
					c2 = 'U';
				}
			}
			char[] value = new char[2] { c, c2 };
			return new string(value);
		}

		private char method_13()
		{
			if (keyNumberType_0 == KeyNumberType.LicensePack)
			{
				return 'L';
			}
			switch (softwareType_0)
			{
			case SoftwareType.Express:
				return 'E';
			case SoftwareType.Pro:
				return 'P';
			case SoftwareType.Suite:
			case SoftwareType.PowerForms:
				return 'S';
			default:
				throw new NotImplementedException("Nice prefix for this SWType is not implemented!");
			}
		}

		private char method_14()
		{
			if (keyNumberType_0 == KeyNumberType.LicensePack)
			{
				return 'U';
			}
			switch (softwareType_0)
			{
			case SoftwareType.Express:
				return 'K';
			case SoftwareType.Pro:
				return 'R';
			case SoftwareType.Suite:
			case SoftwareType.PowerForms:
				return 'G';
			default:
				throw new NotImplementedException("Avrey prefix for this SWType is not implemented!");
			}
		}

		private char method_15()
		{
			if (keyNumberType_0 == KeyNumberType.LicensePack)
			{
				return 'F';
			}
			switch (softwareType_0)
			{
			case SoftwareType.Express:
				return 'C';
			case SoftwareType.Pro:
				return 'Q';
			case SoftwareType.Suite:
			case SoftwareType.PowerForms:
				return 'T';
			default:
				throw new NotImplementedException("Tyco prefix for this SWType is not implemented!");
			}
		}

		private char method_16()
		{
			if (keyNumberType_0 == KeyNumberType.LicensePack)
			{
				return 'F';
			}
			switch (softwareType_0)
			{
			case SoftwareType.Express:
				return 'C';
			case SoftwareType.Pro:
				return 'Q';
			case SoftwareType.Suite:
			case SoftwareType.PowerForms:
				return 'T';
			default:
				throw new NotImplementedException("QLS prefix for this SWType is not implemented!");
			}
		}

		private void method_2(string code)
		{
			string_0 = GClass1.smethod_0(code);
			if (string_0.Length != 25)
			{
				bool_0 = false;
			}
			else
			{
				string_1 = GClass1.smethod_1(string_0);
			}
		}

		private void method_3()
		{
			string_2 = GClass8.smethod_3(keyNumberVersion_0);
			string_3 = GClass8.smethod_4(keyNumberVersion_0);
			string_4 = GClass8.smethod_5(keyNumberVersion_0);
			int num = int_3 & 0xF;
			int num2 = (int_3 & 0xF0) >> 4;
			if (!string.IsNullOrEmpty(string_2) && !string.IsNullOrEmpty(string_4))
			{
				StringBuilder stringBuilder = new StringBuilder();
				if (keyNumberVersion_0 == KeyNumberVersion.V3)
				{
					stringBuilder.AppendFormat("{0:X1}", (int)keyNumberType_0);
					stringBuilder.AppendFormat("{0:X2}", (int)oemType_0);
					stringBuilder.AppendFormat("{0:X1}", (int)versionType_0);
					stringBuilder.AppendFormat("{0:X2}", int_3);
					stringBuilder.AppendFormat("{0:X7}", (int)keyNumberOptions_0);
					stringBuilder.AppendFormat("{0:X1}", int_2);
					stringBuilder.AppendFormat("{0:X5}", int_0);
					stringBuilder.AppendFormat("{0:X4}", int_1);
				}
				else
				{
					stringBuilder.AppendFormat("{0:X1}", (int)keyNumberType_0);
					stringBuilder.AppendFormat("{0:X2}", (int)oemType_0);
					stringBuilder.AppendFormat("{0:X1}", num2);
					stringBuilder.AppendFormat("{0:X1}", (int)softwareType_0);
					stringBuilder.AppendFormat("{0:X1}", num);
					stringBuilder.AppendFormat("{0:X1}", (int)licenseType_0);
					stringBuilder.AppendFormat("{0:X1}", int_2);
					stringBuilder.AppendFormat("{0:X5}", int_0);
					stringBuilder.AppendFormat("{0:X2}", (int)versionType_0);
					stringBuilder.AppendFormat("{0:X4}", int_1);
					stringBuilder.AppendFormat("{0:X4}", (int)keyNumberOptions_0);
				}
				stringBuilder.Append(method_5(stringBuilder.ToString()));
				GClass2 gClass = new GClass2();
				GClass2 gClass2 = new GClass2();
				GClass2 gClass3 = new GClass2();
				gClass.method_12(string_2);
				gClass2.method_12(string_4);
				gClass3.method_12(stringBuilder.ToString());
				GClass2 gClass4 = GClass2.smethod_22(gClass3, gClass2, gClass);
				string_0 = method_8(gClass4.method_13(GClass8.smethod_0(keyNumberVersion_0)));
				bool_0 = true;
				return;
			}
			throw new InvalidOperationException("Can't get RSA keys!");
		}

		private void method_4()
		{
			if (string_0.Length != 25)
			{
				return;
			}
			KeyNumberVersion keyNumberVersion;
			try
			{
				keyNumberVersion = smethod_0(string_0);
			}
			catch (ArgumentException)
			{
				return;
			}
			if (keyNumberVersion == KeyNumberVersion.Unknown)
			{
				return;
			}
			string_2 = GClass8.smethod_3(keyNumberVersion);
			string_3 = GClass8.smethod_4(keyNumberVersion);
			string_4 = GClass8.smethod_5(keyNumberVersion);
			if (string.IsNullOrEmpty(string_2) || string.IsNullOrEmpty(string_3))
			{
				throw new InvalidOperationException("Can't get RSA keys!");
			}
			string text = string_0.Substring(GClass8.smethod_2(keyNumberVersion), GClass8.smethod_0(keyNumberVersion));
			GClass2 gClass = new GClass2();
			GClass2 gClass2 = new GClass2();
			GClass2 gClass3 = new GClass2();
			gClass.method_12(string_2);
			gClass2.method_12(string_3);
			gClass3.method_14(text);
			text = GClass2.smethod_22(gClass3, gClass2, gClass).method_11(0);
			if (!string.IsNullOrEmpty(text) && text.Length == 27 && !(method_5(text.Substring(0, 23)) != text.Substring(23, 4)))
			{
				keyNumberVersion_0 = keyNumberVersion;
				if (keyNumberVersion_0 == KeyNumberVersion.V3)
				{
					keyNumberType_0 = (KeyNumberType)int.Parse(text.Substring(0, 1), NumberStyles.HexNumber);
					oemType_0 = (OemType)int.Parse(text.Substring(1, 2), NumberStyles.HexNumber);
					versionType_0 = (VersionType)int.Parse(text.Substring(3, 1), NumberStyles.HexNumber);
					int_3 = int.Parse(text.Substring(4, 2), NumberStyles.HexNumber);
					keyNumberOptions_0 = (KeyNumberOptions)int.Parse(text.Substring(6, 7), NumberStyles.HexNumber);
					int_2 = int.Parse(text.Substring(13, 1), NumberStyles.HexNumber);
					int_0 = int.Parse(text.Substring(14, 5), NumberStyles.HexNumber);
					int_1 = int.Parse(text.Substring(19, 4), NumberStyles.HexNumber);
					softwareType_0 = SoftwareType.LMS;
				}
				else
				{
					keyNumberType_0 = (KeyNumberType)int.Parse(text.Substring(0, 1), NumberStyles.HexNumber);
					oemType_0 = (OemType)int.Parse(text.Substring(1, 2), NumberStyles.HexNumber);
					int num = int.Parse(text.Substring(3, 1), NumberStyles.HexNumber);
					softwareType_0 = (SoftwareType)int.Parse(text.Substring(4, 1), NumberStyles.HexNumber);
					int num2 = int.Parse(text.Substring(5, 1), NumberStyles.HexNumber);
					licenseType_0 = (LicenseType)int.Parse(text.Substring(6, 1), NumberStyles.HexNumber);
					int_2 = int.Parse(text.Substring(7, 1), NumberStyles.HexNumber);
					int_0 = int.Parse(text.Substring(8, 5), NumberStyles.HexNumber);
					versionType_0 = (VersionType)int.Parse(text.Substring(13, 2), NumberStyles.HexNumber);
					int_1 = int.Parse(text.Substring(15, 4), NumberStyles.HexNumber);
					keyNumberOptions_0 = (KeyNumberOptions)int.Parse(text.Substring(19, 4), NumberStyles.HexNumber);
					int_3 = (num << 4) | num2;
				}
				bool_0 = true;
			}
		}

		private string method_5(string keyNumberCode)
		{
			return string.Format("{0:X4}", method_6(keyNumberCode));
		}

		private int method_6(string keyNumberCode)
		{
			int num = 0;
			for (int i = 0; i < keyNumberCode.Length; i++)
			{
				num = method_7((byte)keyNumberCode[i], num);
			}
			return num;
		}

		private int method_7(byte byte_0, int int_4)
		{
			for (int i = 0; i < 8; i++)
			{
				if (((byte_0 & 1) ^ (int_4 & 1)) != 0)
				{
					int_4 >>= 1;
					int_4 ^= 0xA001;
				}
				else
				{
					int_4 >>= 1;
				}
				byte_0 >>= 1;
			}
			return int_4;
		}

		private string method_8(string keyNumberCode)
		{
			switch (keyNumberVersion_0)
			{
			case KeyNumberVersion.V1:
				return method_9(keyNumberCode);
			case KeyNumberVersion.V2:
			case KeyNumberVersion.V3:
				return method_10(keyNumberCode);
			default:
				throw new NotImplementedException("AddKeyNumberVersion is not implemented for this Key Number Version!");
			}
		}

		private string method_9(string keyNumberCode)
		{
			int num = GClass2.smethod_2().IndexOf(keyNumberCode[keyNumberCode.Length - 1]);
			if (num == -1)
			{
				throw new ArgumentException("Prefix error!");
			}
			num = (int)(num + keyNumberVersion_0);
			if (num > GClass2.smethod_2().Length)
			{
				num -= GClass2.smethod_2().Length;
			}
			return GClass2.smethod_2()[num] + keyNumberCode;
		}

		public static KeyNumberVersion smethod_0(string keyNumberCode)
		{
			int num = GClass2.smethod_2().IndexOf(keyNumberCode[keyNumberCode.Length - 1]);
			if (num == -1)
			{
				throw new ArgumentException("This Key Number Code is not valid!");
			}
			int num2 = GClass2.smethod_2().IndexOf(keyNumberCode[0]);
			if (num2 == -1)
			{
				throw new ArgumentException("This Key Number Code is not valid!");
			}
			KeyNumberVersion keyNumberVersion = (KeyNumberVersion)((num2 < num) ? (num2 + GClass2.smethod_2().Length - num) : (num2 - num));
			if (!Enum.IsDefined(typeof(KeyNumberVersion), keyNumberVersion))
			{
				throw new ArgumentException("This Key Number Code is not valid!");
			}
			return keyNumberVersion;
		}
	}
}
