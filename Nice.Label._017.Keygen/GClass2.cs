using System;

namespace Nice.Label._017.Keygen
{
	public class GClass2
	{
		private const string string_0 = "0123456789ABCDEF";

		private const string string_1 = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7";

		private bool bool_0;

		[NonSerialized]
		private string string_2 = "32";

		private ulong[] ulong_0;

		public GClass2()
		{
			ulong_0 = new ulong[smethod_0()];
			method_6(0L);
		}

		public GClass2(long long_0)
		{
			ulong_0 = new ulong[smethod_0()];
			method_6(long_0);
		}

		public GClass2(GClass2 gclass2_0)
		{
			ulong_0 = new ulong[smethod_0()];
			method_7(gclass2_0);
		}

		public override bool Equals(object object_0)
		{
			return true;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool method_0()
		{
			int i;
			for (i = 0; i < smethod_0() && ulong_0[i] == 0; i++)
			{
			}
			return i >= smethod_0();
		}

		public ulong[] method_1()
		{
			return ulong_0;
		}

		public byte method_10(int int_0)
		{
			GClass2 gClass = new GClass2(this);
			int_0 = ((int_0 % 8 > 0) ? (int_0 / 8 + 1) : (int_0 / 8));
			byte byte_ = byte.MaxValue;
			while (int_0 > 0)
			{
				byte byte_2 = (byte)gClass.method_16(8);
				method_20(ref byte_, byte_2);
				int_0--;
			}
			return byte_;
		}

		public string method_11(int int_0)
		{
			return method_18(int_0, smethod_1());
		}

		public void method_12(string string_3)
		{
			method_19(string_3, smethod_1());
		}

		public string method_13(int int_0)
		{
			return method_18(int_0, smethod_2());
		}

		public void method_14(string string_3)
		{
			method_19(string_3, "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7");
		}

		public void method_15(ulong ulong_1, int int_0)
		{
			ulong num = (ulong)(1L << int_0);
			num--;
			smethod_21(this, int_0);
			ulong_0[0] |= ulong_1 & num;
		}

		public ulong method_16(int recLen)
		{
			ulong num = (ulong)(1L << recLen);
			num--;
			ulong result = ulong_0[0] & num;
			smethod_20(this, recLen);
			return result;
		}

		private int method_17(string codeStr)
		{
			int num = 1;
			int num2 = 2;
			while (num2 < codeStr.Length)
			{
				num2 *= 2;
				num++;
			}
			return num;
		}

		private string method_18(int int_0, string string_3)
		{
			GClass2 gClass = new GClass2(this);
			int num = method_17(string_3);
			int num2 = method_5() / num;
			if (method_5() % num > 0)
			{
				num2++;
			}
			if (num2 == 0)
			{
				num2 = 1;
			}
			if (int_0 > num2)
			{
				num2 = int_0;
			}
			ulong num3 = (ulong)((1 << num) - 1);
			string text = string.Empty;
			for (int i = 0; i < num2; i++)
			{
				int index = (int)(gClass.ulong_0[0] & num3);
				text = string_3[index] + text;
				gClass = smethod_20(gClass, num);
			}
			if (bool_0)
			{
				text = "-" + text;
			}
			return text;
		}

		private void method_19(string string_3, string codeStr)
		{
			GClass2 gClass = new GClass2(0L);
			int int_ = method_17(codeStr);
			for (int i = 0; i < string_3.Length; i++)
			{
				if (string_3[i] == '-')
				{
					bool_0 = true;
					continue;
				}
				int j;
				for (j = 0; j < codeStr.Length && string_3[i] != codeStr[j]; j++)
				{
				}
				if (j >= codeStr.Length)
				{
					j = 0;
				}
				gClass = smethod_21(gClass, int_);
				gClass.ulong_0[0] = gClass.ulong_0[0] + (ulong)j;
			}
			method_7(gClass);
		}

		public void method_2(ulong[] ulong_1)
		{
			ulong_0 = ulong_1;
		}

		private void method_20(ref byte byte_0, byte byte_1)
		{
			byte b = byte_1;
			for (int i = 0; i < 8; i++)
			{
				byte_1 = (byte)(byte_0 ^ b);
				byte_0 <<= 1;
				if ((byte_1 & 0x80) > 0)
				{
					byte_0 ^= 105;
				}
				b <<= 1;
			}
		}

		public bool method_3()
		{
			return bool_0;
		}

		public void method_4(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public int method_5()
		{
			int num = smethod_0() - 1;
			while (num >= 0 && ulong_0[num] == 0)
			{
				num--;
			}
			if (num < 0)
			{
				return 0;
			}
			int num2 = 0;
			ulong num3 = ulong_0[num];
			while (num3 != 0)
			{
				num3 >>= 1;
				num2++;
			}
			return num2 + num * 8 * 8;
		}

		public void method_6(long long_0)
		{
			for (int i = 0; i < smethod_0(); i++)
			{
				ulong_0[i] = 0uL;
			}
			bool_0 = long_0 < 0;
			ulong_0[0] = (ulong)((long_0 < 0) ? (-long_0) : long_0);
		}

		public void method_7(GClass2 gclass2_0)
		{
			for (int i = 0; i < smethod_0(); i++)
			{
				ulong_0[i] = gclass2_0.ulong_0[i];
			}
			bool_0 = gclass2_0.bool_0;
		}

		public bool method_8()
		{
			return (ulong_0[0] & 1) == 0;
		}

		public bool method_9()
		{
			return (ulong_0[0] & 1) != 0;
		}

		public static int smethod_0()
		{
			return 32;
		}

		public static string smethod_1()
		{
			return "0123456789ABCDEF";
		}

		public static bool smethod_10(GClass2 gclass2_0, long long_0)
		{
			return !smethod_9(gclass2_0, long_0);
		}

		public static bool smethod_11(GClass2 gclass2_0, long long_0)
		{
			GClass2 gclass2_1 = new GClass2(long_0);
			return smethod_5(gclass2_0, gclass2_1);
		}

		public static bool smethod_12(GClass2 gclass2_0, long long_0)
		{
			GClass2 gclass2_1 = new GClass2(long_0);
			return smethod_6(gclass2_0, gclass2_1);
		}

		public static bool smethod_13(GClass2 gclass2_0, long long_0)
		{
			return !smethod_12(gclass2_0, long_0);
		}

		public static bool smethod_14(GClass2 gclass2_0, long long_0)
		{
			return !smethod_11(gclass2_0, long_0);
		}

		public static GClass2 smethod_15(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 gclass2_2;
			if (gclass2_0.bool_0 == gclass2_1.bool_0)
			{
				smethod_30(out gclass2_2, gclass2_0, gclass2_1);
				gclass2_2.bool_0 = gclass2_0.bool_0;
			}
			else
			{
				if (smethod_28(gclass2_0, gclass2_1))
				{
					return new GClass2();
				}
				if (smethod_29(gclass2_0, gclass2_1))
				{
					smethod_31(out gclass2_2, gclass2_0, gclass2_1);
					gclass2_2.bool_0 = !gclass2_0.bool_0;
				}
				else
				{
					smethod_31(out gclass2_2, gclass2_0, gclass2_1);
					gclass2_2.bool_0 = gclass2_0.bool_0;
				}
			}
			return gclass2_2;
		}

		public static GClass2 smethod_16(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			gclass2_1.bool_0 = !gclass2_1.bool_0;
			return smethod_15(gclass2_0, gclass2_1);
		}

		public static GClass2 smethod_17(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 gclass2_2;
			smethod_32(out gclass2_2, gclass2_0, gclass2_1);
			gclass2_2.bool_0 = gclass2_0.bool_0 != gclass2_1.bool_0;
			return gclass2_2;
		}

		public static GClass2 smethod_18(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 gclass2_2;
			GClass2 gclass2_3;
			smethod_33(out gclass2_2, out gclass2_3, gclass2_0, gclass2_1);
			gclass2_2.bool_0 = gclass2_0.bool_0 != gclass2_1.bool_0;
			return gclass2_2;
		}

		public static GClass2 smethod_19(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 gclass2_2;
			GClass2 gclass2_3;
			smethod_33(out gclass2_2, out gclass2_3, gclass2_0, gclass2_1);
			return gclass2_3;
		}

		public static string smethod_2()
		{
			return "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7";
		}

		public static GClass2 smethod_20(GClass2 gclass2_0, int int_0)
		{
			while (int_0-- > 0)
			{
				smethod_35(ref gclass2_0);
			}
			return gclass2_0;
		}

		public static GClass2 smethod_21(GClass2 gclass2_0, int int_0)
		{
			while (int_0-- > 0)
			{
				smethod_34(ref gclass2_0);
			}
			return gclass2_0;
		}

		public static GClass2 smethod_22(GClass2 gclass2_0, GClass2 gclass2_1, GClass2 gclass2_2)
		{
			int num = 0;
			GClass2 gclass2_3 = smethod_19(gclass2_0, gclass2_2);
			GClass2 gClass = new GClass2();
			while (smethod_10(gclass2_1, 0L))
			{
				gClass = smethod_21(gClass, 1);
				if (gclass2_1.method_8())
				{
					gClass.ulong_0[0] |= 1uL;
				}
				gclass2_1 = smethod_20(gclass2_1, 1);
				num++;
			}
			GClass2 gClass2 = new GClass2(1L);
			while (num > 1)
			{
				if (gClass.method_8())
				{
					gClass2 = smethod_19(smethod_17(gclass2_3, gClass2), gclass2_2);
				}
				gClass2 = smethod_19(smethod_17(gClass2, gClass2), gclass2_2);
				gClass = smethod_20(gClass, 1);
				num--;
			}
			return smethod_19(smethod_17(gclass2_3, gClass2), gclass2_2);
		}

		public static void smethod_23(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 gclass2_2 = new GClass2(gclass2_0);
			gclass2_0.method_7(gclass2_1);
			gclass2_1.method_7(gclass2_2);
		}

		public static GClass2 smethod_24(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 result = new GClass2();
			gclass2_0.bool_0 = false;
			gclass2_1.bool_0 = false;
			if (!smethod_9(gclass2_0, 0L) && !smethod_9(gclass2_1, 0L))
			{
				result = gclass2_1;
				while (smethod_12(gclass2_0, 0L))
				{
					result = gclass2_0;
					gclass2_0 = smethod_19(gclass2_1, gclass2_0);
					gclass2_1 = result;
				}
				return result;
			}
			return result;
		}

		public static bool smethod_25(GClass2 gclass2_0, GClass2 gclass2_1, GClass2 gclass2_2)
		{
			GClass2 gclass2_3;
			GClass2 gclass2_4;
			GClass2 gclass2_5;
			smethod_27(gclass2_1, gclass2_2, out gclass2_3, out gclass2_4, out gclass2_5);
			if (smethod_10(gclass2_5, 1L))
			{
				return false;
			}
			gclass2_0 = smethod_16(gclass2_1, gclass2_4);
			return true;
		}

		public static bool smethod_26(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			GClass2 gclass2_2 = new GClass2(1L);
			if (gclass2_0.method_8())
			{
				return false;
			}
			GClass2 gClass = smethod_16(gclass2_0, gclass2_2);
			int num = 0;
			while (gClass.method_8() && num < smethod_0() * 8 * 4)
			{
				gClass = smethod_20(gClass, 1);
				num++;
			}
			int num2 = 0;
			GClass2 gClass2 = smethod_22(gclass2_1, gClass, gclass2_0);
			if (!smethod_9(gClass2, 1L) && !smethod_3(gClass2, smethod_16(gclass2_0, gclass2_2)))
			{
				while (num2 <= 0 || !smethod_3(gClass2, gclass2_2))
				{
					num2++;
					bool flag;
					if (flag = num2 < num && smethod_4(gClass2, smethod_16(gclass2_0, gclass2_2)))
					{
						gClass2 = smethod_19(smethod_17(gClass2, gClass2), gclass2_0);
					}
					if (!flag)
					{
						return smethod_3(gClass2, smethod_16(gclass2_0, gclass2_2));
					}
				}
				return false;
			}
			return true;
		}

		private static void smethod_27(GClass2 gclass2_0, GClass2 gclass2_1, out GClass2 gclass2_2, out GClass2 gclass2_3, out GClass2 gclass2_4)
		{
			if (smethod_5(gclass2_0, gclass2_1))
			{
				smethod_23(gclass2_0, gclass2_1);
			}
			int num = 0;
			while (gclass2_0.method_8() && gclass2_1.method_8())
			{
				gclass2_0 = smethod_20(gclass2_0, 1);
				gclass2_1 = smethod_20(gclass2_1, 1);
				num++;
			}
			gclass2_2 = new GClass2(1L);
			gclass2_3 = new GClass2(0L);
			gclass2_4 = new GClass2(gclass2_0);
			GClass2 gclass2_5 = new GClass2(gclass2_1);
			GClass2 gclass2_6 = new GClass2(1L);
			gclass2_6 = smethod_16(gclass2_0, gclass2_6);
			GClass2 gClass = new GClass2(gclass2_1);
			while (true)
			{
				bool flag = true;
				if (gclass2_4.method_8())
				{
					if (gclass2_2.method_9() || gclass2_3.method_9())
					{
						gclass2_2 = smethod_15(gclass2_2, gclass2_1);
						gclass2_3 = smethod_15(gclass2_3, gclass2_0);
					}
					gclass2_2 = smethod_20(gclass2_2, 1);
					gclass2_3 = smethod_20(gclass2_3, 1);
					gclass2_4 = smethod_20(gclass2_4, 1);
				}
				if (gClass.method_8() || smethod_5(gclass2_4, gClass))
				{
					smethod_23(gclass2_2, gclass2_5);
					smethod_23(gclass2_3, gclass2_6);
					smethod_23(gclass2_4, gClass);
				}
				if (!gclass2_4.method_8())
				{
					while (smethod_5(gclass2_2, gclass2_5) || smethod_5(gclass2_3, gclass2_6))
					{
						gclass2_2 = smethod_15(gclass2_2, gclass2_1);
						gclass2_3 = smethod_15(gclass2_3, gclass2_0);
					}
					gclass2_2 = smethod_16(gclass2_2, gclass2_5);
					gclass2_3 = smethod_16(gclass2_3, gclass2_6);
					gclass2_4 = smethod_16(gclass2_4, gClass);
					if (!smethod_12(gClass, 0L))
					{
						break;
					}
				}
			}
			while (smethod_8(gclass2_2, gclass2_1) && smethod_8(gclass2_3, gclass2_0))
			{
				gclass2_2 = smethod_16(gclass2_2, gclass2_1);
				gclass2_3 = smethod_16(gclass2_3, gclass2_0);
			}
			gclass2_0 = smethod_21(gclass2_0, num);
			gclass2_1 = smethod_21(gclass2_1, num);
			gclass2_4 = smethod_21(gclass2_4, num);
		}

		private static bool smethod_28(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			int i;
			for (i = 0; i < smethod_0() && gclass2_0.ulong_0[i] == gclass2_1.ulong_0[i]; i++)
			{
			}
			return i >= smethod_0();
		}

		private static bool smethod_29(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			int num = smethod_0() - 1;
			while (num >= 0 && gclass2_0.ulong_0[num] == gclass2_1.ulong_0[num])
			{
				num--;
			}
			return num >= 0 && gclass2_0.ulong_0[num] < gclass2_1.ulong_0[num];
		}

		public static bool smethod_3(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			return gclass2_0.bool_0 == gclass2_1.bool_0 && smethod_28(gclass2_0, gclass2_1);
		}

		private static bool smethod_30(out GClass2 gclass2_0, GClass2 gclass2_1, GClass2 gclass2_2)
		{
			gclass2_0 = new GClass2();
			bool flag = false;
			for (int i = 0; i < smethod_0(); i++)
			{
				gclass2_0.ulong_0[i] = gclass2_1.ulong_0[i] + gclass2_2.ulong_0[i];
				bool flag2 = gclass2_0.ulong_0[i] < gclass2_1.ulong_0[i] || gclass2_0.ulong_0[i] < gclass2_2.ulong_0[i];
				bool flag3;
				if (!flag)
				{
					flag3 = false;
				}
				else
				{
					gclass2_0.ulong_0[i]++;
					flag3 = gclass2_0.ulong_0[i] == 0;
				}
				flag = flag2 || flag3;
			}
			return flag;
		}

		private static bool smethod_31(out GClass2 gclass2_0, GClass2 gclass2_1, GClass2 gclass2_2)
		{
			bool flag = false;
			gclass2_0 = new GClass2();
			for (int i = 0; i < smethod_0(); i++)
			{
				if (flag)
				{
					gclass2_2.ulong_0[i]++;
					flag = gclass2_2.ulong_0[i] == 0;
				}
				if (gclass2_2.ulong_0[i] != 0)
				{
					flag = gclass2_1.ulong_0[i] < gclass2_2.ulong_0[i];
				}
				gclass2_0.ulong_0[i] = gclass2_1.ulong_0[i] - gclass2_2.ulong_0[i];
			}
			return flag;
		}

		private static bool smethod_32(out GClass2 gclass2_0, GClass2 gclass2_1, GClass2 gclass2_2)
		{
			bool flag = false;
			gclass2_0 = new GClass2();
			GClass2 gclass2_3;
			GClass2 gclass2_4;
			if (smethod_5(gclass2_1, gclass2_2))
			{
				gclass2_3 = new GClass2(gclass2_1);
				gclass2_4 = new GClass2(gclass2_2);
			}
			else
			{
				gclass2_3 = new GClass2(gclass2_2);
				gclass2_4 = new GClass2(gclass2_1);
			}
			while (!gclass2_3.method_0())
			{
				if (smethod_35(ref gclass2_3))
				{
					smethod_30(out gclass2_0, gclass2_0, gclass2_4);
				}
				flag |= smethod_34(ref gclass2_4);
			}
			return flag;
		}

		private static bool smethod_33(out GClass2 gclass2_0, out GClass2 gclass2_1, GClass2 gclass2_2, GClass2 gclass2_3)
		{
			bool flag = false;
			gclass2_0 = new GClass2();
			gclass2_1 = new GClass2();
			GClass2 gClass = new GClass2();
			bool flag2 = gclass2_2.bool_0 ^ gclass2_3.bool_0;
			bool flag3 = gclass2_3.bool_0;
			gclass2_2.bool_0 = false;
			gclass2_3.bool_0 = false;
			if (smethod_29(gclass2_2, gclass2_3))
			{
				gclass2_0.method_6(0L);
				gclass2_1.method_7(gclass2_2);
				flag = true;
			}
			if (!flag && smethod_28(gclass2_2, gclass2_3))
			{
				gclass2_0.method_6(1L);
				gclass2_1.method_6(0L);
				flag = true;
			}
			if (!flag)
			{
				GClass2 gClass2 = new GClass2(gclass2_2);
				GClass2 gClass3 = new GClass2(gclass2_3);
				int num = gClass2.method_5();
				int num2 = gClass3.method_5();
				gClass.method_6(1L);
				int num3 = num - num2;
				if (num3 > 0)
				{
					gClass3 = smethod_21(gClass3, num3);
					gClass = smethod_21(gClass, num3);
				}
				gclass2_0.method_6(0L);
				gclass2_1.method_6(0L);
				while (!gClass.method_0())
				{
					if (smethod_7(smethod_15(gclass2_1, gClass3), gClass2))
					{
						gclass2_0 = smethod_15(gclass2_0, gClass);
						gclass2_1 = smethod_15(gclass2_1, gClass3);
					}
					gClass3 = smethod_20(gClass3, 1);
					gClass = smethod_20(gClass, 1);
				}
				gclass2_0.method_7(gclass2_0);
				gclass2_1 = smethod_16(gClass2, gclass2_1);
			}
			gclass2_0.bool_0 = flag2;
			gclass2_1.bool_0 = flag3;
			return false;
		}

		private static bool smethod_34(ref GClass2 gclass2_0)
		{
			bool flag = false;
			for (int i = 0; i < smethod_0(); i++)
			{
				ulong num = gclass2_0.ulong_0[i];
				gclass2_0.ulong_0[i] <<= 1;
				bool flag2 = gclass2_0.ulong_0[i] < num;
				if (flag)
				{
					gclass2_0.ulong_0[i]++;
				}
				flag = flag2;
			}
			return flag;
		}

		private static bool smethod_35(ref GClass2 gclass2_0)
		{
			bool flag = false;
			for (int num = smethod_0() - 1; num >= 0; num--)
			{
				bool flag2 = (gclass2_0.ulong_0[num] & 1) != 0;
				gclass2_0.ulong_0[num] >>= 1;
				if (flag)
				{
					gclass2_0.ulong_0[num] |= 9223372036854775808uL;
				}
				flag = flag2;
			}
			return flag;
		}

		public static bool smethod_4(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			return !smethod_3(gclass2_0, gclass2_1);
		}

		public static bool smethod_5(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			if (gclass2_0.bool_0 && !gclass2_1.bool_0)
			{
				return true;
			}
			if (gclass2_0.bool_0)
			{
				return smethod_29(gclass2_1, gclass2_0);
			}
			return smethod_29(gclass2_0, gclass2_1);
		}

		public static bool smethod_6(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			return smethod_5(gclass2_1, gclass2_0);
		}

		public static bool smethod_7(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			return !smethod_6(gclass2_0, gclass2_1);
		}

		public static bool smethod_8(GClass2 gclass2_0, GClass2 gclass2_1)
		{
			return !smethod_5(gclass2_0, gclass2_1);
		}

		public static bool smethod_9(GClass2 gclass2_0, long long_0)
		{
			GClass2 gclass2_1 = new GClass2(long_0);
			return smethod_3(gclass2_0, gclass2_1);
		}
	}
}
