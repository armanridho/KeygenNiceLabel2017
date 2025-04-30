using System;

namespace Nice.Label._017.Keygen
{
	public sealed class GClass8
	{
		private static string[] string_0 = new string[3] { "1BB92ABD18A6C9C475C41FEB4D3C7F", "BF8CBD4428715CD28FFCC360109", "4B604C3B94C54A6AC30454A11DF" };

		private static string[] string_1 = new string[3] { "1523A993178AD245A9927527AE1759", "29D086D4FEEF256BE12423FC8C7", "4260F9C47F85D2E661937B6697D" };

		private static string[] string_2 = new string[3] { "16976890C5FA20736096CEAA231BF1", "BE861D44266D5C8C8DFC7F60007", "4354F699BE89343A1E7842A5D55" };

		[NonSerialized]
		private string string_3 = "32";

		private static Struct0[] struct0_0 = new Struct0[3]
		{
			new Struct0(59, 1, 24),
			new Struct0(54, 2, 22),
			new Struct0(54, 2, 22)
		};

		private GClass8()
		{
		}

		public static int smethod_0(KeyNumberVersion keyNumberVersion_0)
		{
			return struct0_0[(int)(keyNumberVersion_0 - 1)].method_2();
		}

		public static int smethod_1(KeyNumberVersion keyNumberVersion_0)
		{
			return struct0_0[(int)(keyNumberVersion_0 - 1)].method_0();
		}

		public static int smethod_2(KeyNumberVersion keyNumberVersion_0)
		{
			return struct0_0[(int)(keyNumberVersion_0 - 1)].method_1();
		}

		public static string smethod_3(KeyNumberVersion keyNumberVersion_0)
		{
			return string_0[(int)(keyNumberVersion_0 - 1)];
		}

		public static string smethod_4(KeyNumberVersion keyNumberVersion_0)
		{
			return string_1[(int)(keyNumberVersion_0 - 1)];
		}

		public static string smethod_5(KeyNumberVersion keyNumberVersion_0)
		{
			return string_2[(int)(keyNumberVersion_0 - 1)];
		}
	}
}
