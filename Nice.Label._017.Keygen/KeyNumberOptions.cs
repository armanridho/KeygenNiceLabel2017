using System;

namespace Nice.Label._017.Keygen
{
	[Flags]
	public enum KeyNumberOptions
	{
		Unknown = 0,
		Demo = 1,
		Runtime = 2,
		DealerDemo = 8,
		SingleUser = 0x10,
		Dongle = 0x20,
		SoftwareKey = 0x40,
		MultiSeat = 0x100,
		Trial = 0x1000,
		MaxCutOnly = 0x4000,
		DesignerFree = 0x1000000,
		DesignerExpress = 0x3000000,
		DesignerPro = 0x7000000,
		PowerForms = 0xF000000,
		AutomationEasy = 0x100000,
		AutomationPro = 0x300000,
		AutomationEnterprise = 0x700000,
		ControlCenterProV7 = 0x10000,
		ControlCenterEnterprise = 0x30000,
		NonProduction = 0x80000,
		PrintOnly = 2,
		Sdk = 4,
		PocketDesigner = 0x10,
		PocketEnabled = 0x20,
		HL7Enabled = 0x40,
		PrintersLimited = 0x80,
		NetworkLicense = 0x100,
		Offline = 0x200,
		OfflineForced = 0x400,
		OfflineEnabled = 0x800,
		Integrations = 0x2000,
		Master = int.MinValue,
		SapEnabled = 0x4000,
		PrinterCountLimit5 = 0x10,
		PrinterCountLimit3 = 0x20,
		PrinterCountLimit10 = 0x30,
		AutomationErp = 0x40,
		AutomationErpPro = 0x4000,
		ControlCenterPro = 0x4000
	}
}
