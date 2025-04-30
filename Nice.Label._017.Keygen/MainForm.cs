using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nice.Label._017.Keygen
{
	public class MainForm : Form
	{
		private GClass7 gclass7_0 = null;

		private string string_0;

		private string string_1;

		private string string_2;

		private int int_1;

		private int int_2;

		private DateTime dateTime_0;

		private GClass4 gclass4_0;

		private bool bool_0;

		private IContainer components = null;

		private System.Windows.Forms.Label label3;

		private TextBox textBox3;

		private TextBox textBox2;

		private Button button1;

		private TextBox textBox1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label1;

		public MainForm()
		{
			InitializeComponent();
		}

		private void TextBox2TextChanged(object sender, EventArgs e)
		{
		}

		private void Button1Click(object sender, EventArgs e)
		{
			string code = method_10(textBox3.Text, textBox1.Text);
			textBox2.Text = code;
			string fromActivationCode = GetFromActivationCode(code);
		}

		private string GetFromActivationCode(string code)
		{
			StringBuilder stringBuilder = new StringBuilder(code.Length);
			for (int i = 0; i < code.Length; i++)
			{
				int num = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".IndexOf(code[i]);
				if (num == -1)
				{
					throw new ArgumentException("Activation Code is not valid!");
				}
				num -= code.Length + i + 1;
				num %= "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length;
				if (num < 0)
				{
					num += "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length;
				}
				stringBuilder.Append("CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7"[num]);
			}
			return stringBuilder.ToString();
		}

		public DateTime method_4()
		{
			return dateTime_0;
		}

		private string method_10()
		{
			if (gclass7_0 == null)
			{
				try
				{
					gclass7_0 = new GClass7(string_1);
				}
				catch (ArgumentException)
				{
					throw;
				}
			}
			if (!gclass7_0.method_5())
			{
				throw new ArgumentException("Registration Number is not valid!");
			}
			string text = gclass7_0.method_2();
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentException("Registration Number is not valid!");
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (text.Substring(text.Length - 2) == "XY")
			{
				GClass2 gClass = new GClass2();
				gClass.method_14(text.Substring(text.Length - 4, 2));
				uint num = (uint)gClass.method_1()[0];
				num = num * 123 % 256;
				gClass.method_1()[0] = num;
				stringBuilder.Append(text.Substring(0, text.Length - 4));
				stringBuilder.Append(gClass.method_13(2));
				stringBuilder.Append("XY");
			}
			else
			{
				stringBuilder.Append(gclass7_0.method_2());
			}
			text = stringBuilder.ToString();
			if (dateTime_0 != DateTime.MinValue)
			{
				GClass2 gClass2 = new GClass2(long.Parse(method_4().ToString("yyyyMMdd")));
				stringBuilder.Append(gClass2.method_13(0));
			}
			else if (int_2 != 0)
			{
				GClass2 gClass3 = new GClass2(long.Parse(new DateTime(2072, 4, 2).AddDays(int_2).ToString("yyyyMMdd")));
				stringBuilder.Append(gClass3.method_13(0));
			}
			else if (!string.IsNullOrEmpty(string_2))
			{
				if (gclass4_0 == null)
				{
					gclass4_0 = new GClass4(string_0);
				}
				string text2 = string.Empty;
				for (int i = 0; i < string_2.Length; i++)
				{
					int j;
					for (j = GClass2.smethod_2().IndexOf(string_2[i]) - string_2.Length - i; j < 1; j += GClass2.smethod_2().Length)
					{
					}
					text2 += GClass2.smethod_2()[j - 1];
				}
				text2 = GClass7.smethod_0(text2);
				if (text2 == null)
				{
					throw new ArgumentException("Registration Number is not valid!");
				}
				string text3 = string.Empty;
				if (text2.IndexOf(text, StringComparison.Ordinal) > -1)
				{
					text3 = text2.Substring(text.Length, text2.Length - text.Length);
					text3 = text3.Substring(0, text3.Length - gclass4_0.imethod_28().Length);
				}
				GClass2 gClass4 = new GClass2();
				int num2;
				try
				{
					gClass4.method_14(text3);
					string text4 = gClass4.method_1()[0].ToString();
					int day = int.Parse(text4.Substring(6, 2));
					int month = int.Parse(text4.Substring(4, 2));
					num2 = new DateTime(int.Parse(text4.Substring(0, 4)), month, day).Subtract(DateTime.Today).Days;
				}
				catch
				{
					num2 = 9999;
				}
				if (gclass4_0.imethod_26())
				{
					int_1 = num2;
				}
				else if (num2 > 0)
				{
					int_2 = num2 - new DateTime(2072, 4, 2).Subtract(DateTime.Today).Days;
				}
				stringBuilder.Append(text3);
			}
			stringBuilder.Append((gclass4_0 == null) ? GClass1.smethod_3(string_0) : gclass4_0.imethod_28());
			return stringBuilder.ToString();
		}

		private void method_8()
		{
			string code;
			try
			{
				code = method_10();
			}
			catch (ArgumentException)
			{
				return;
			}
			code = GClass1.smethod_2(code);
			code = method_12(code);
			string_2 = code;
			bool_0 = true;
		}

		private string method_12(string regNumber)
		{
			StringBuilder stringBuilder = new StringBuilder(regNumber.Length);
			for (int i = 0; i < regNumber.Length; i++)
			{
				int num = GClass2.smethod_2().IndexOf(regNumber[i]);
				if (num == -1)
				{
					throw new ArgumentException("Registration Number Code is not valid!");
				}
				num += regNumber.Length + i + 1;
				num %= GClass2.smethod_2().Length;
				stringBuilder.Append(GClass2.smethod_2()[num]);
			}
			return stringBuilder.ToString();
		}

		public string ReverseNumberOne(string input_str)
		{
			string text = "";
			for (int i = 0; i < input_str.Length; i++)
			{
				int num = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".IndexOf(input_str[i]);
				num++;
				num -= "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length;
				num = num + input_str.Length + i;
				while ((num < 0 || num >= "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length) && num != -1)
				{
					num -= "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length;
				}
				text = ((num < 0 || num >= "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length) ? (text + "I") : (text + "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7"[num]));
			}
			return text;
		}

		private string method_10(string string_5, string string_6)
		{
			if (string.IsNullOrEmpty(string_5))
			{
				throw new ArgumentNullException("keyNumberCode");
			}
			if (string.IsNullOrEmpty(string_6))
			{
				string_6 = "6XM54-XY768-QMAYA-LTBM5-JYVLV";
			}
			string text = GClass7.smethod_0(GClass1.smethod_0(string_6));
			StringBuilder stringBuilder = new StringBuilder();
			if (text.Substring(text.Length - 2) == "XY")
			{
				GClass2 gClass = new GClass2();
				gClass.method_14(text.Substring(text.Length - 4, 2));
				uint num = (uint)gClass.method_1()[0];
				num = num * 123 % 256;
				gClass.method_1()[0] = num;
				stringBuilder.Append(text.Substring(0, text.Length - 4));
				stringBuilder.Append(gClass.method_13(2));
				stringBuilder.Append("XY");
			}
			else
			{
				stringBuilder.Append(gclass7_0.method_2());
			}
			text = stringBuilder.ToString();
			string text2 = GClass7.smethod_0_Reverse(true, text);
			string text3 = GClass7.smethod_0(text2);
			string_2 = GClass1.smethod_0(ReverseNumberOne(text2));
			string_0 = GClass1.smethod_0(string_5);
			string_1 = GClass1.smethod_0(string_6);
			dateTime_0 = DateTime.MinValue;
			method_8();
			try
			{
				gclass7_0 = new GClass7(string_1);
			}
			catch (ArgumentException)
			{
				throw;
			}
			if (!gclass7_0.method_5())
			{
				throw new ArgumentException("Registration Number is not valid!");
			}
			string text4 = gclass7_0.method_2();
			if (string.IsNullOrEmpty(text4))
			{
				throw new ArgumentException("Registration Number is not valid!");
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			if (text4.Substring(text4.Length - 2) == "XY")
			{
				GClass2 gClass = new GClass2();
				gClass.method_14(text4.Substring(text4.Length - 4, 2));
				uint num = (uint)gClass.method_1()[0];
				num = num * 123 % 256;
				gClass.method_1()[0] = num;
				stringBuilder2.Append(text4.Substring(0, text4.Length - 4));
				stringBuilder2.Append(gClass.method_13(2));
				stringBuilder2.Append("XY");
			}
			else
			{
				stringBuilder2.Append(gclass7_0.method_2());
			}
			text4 = stringBuilder2.ToString();
			if (dateTime_0 != DateTime.MinValue)
			{
				GClass2 gClass2 = new GClass2(long.Parse(method_4().ToString("yyyyMMdd")));
				stringBuilder2.Append(gClass2.method_13(0));
			}
			else if (int_2 != 0)
			{
				GClass2 gClass3 = new GClass2(long.Parse(new DateTime(2072, 4, 2).AddDays(int_2).ToString("yyyyMMdd")));
				stringBuilder2.Append(gClass3.method_13(0));
			}
			else if (!string.IsNullOrEmpty(string_2))
			{
				if (gclass4_0 == null)
				{
					gclass4_0 = new GClass4(string_0);
				}
				string text5 = string.Empty;
				for (int i = 0; i < string_2.Length; i++)
				{
					int j;
					for (j = "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".IndexOf(string_2[i]) - string_2.Length - i; j < 1; j += "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7".Length)
					{
					}
					text5 += "CQKRG5S9AP2TZXMB4UFE3J6LD8NYHVW7"[j - 1];
				}
				text5 = GClass7.smethod_0(text5);
				if (text5 == null)
				{
					throw new ArgumentException("Registration Number is not valid!");
				}
				string text6 = string.Empty;
				if (text5.IndexOf(text4, StringComparison.Ordinal) > -1)
				{
					text6 = text5.Substring(text4.Length, text5.Length - text4.Length);
					text6 = text6.Substring(0, text6.Length - gclass4_0.imethod_28().Length);
				}
				GClass2 gClass4 = new GClass2();
				int num2;
				try
				{
					gClass4.method_14(text6);
					string text7 = gClass4.method_1()[0].ToString();
					int day = int.Parse(text7.Substring(6, 2));
					int month = int.Parse(text7.Substring(4, 2));
					num2 = new DateTime(int.Parse(text7.Substring(0, 4)), month, day).Subtract(DateTime.Today).Days;
				}
				catch
				{
					num2 = 9999;
				}
				if (gclass4_0.imethod_26())
				{
					int_1 = num2;
				}
				else if (num2 > 0)
				{
					int_2 = num2 - new DateTime(2072, 4, 2).Subtract(DateTime.Today).Days;
				}
				stringBuilder2.Append(text6);
			}
			stringBuilder2.Append((gclass4_0 == null) ? GClass1.smethod_3(string_0) : gclass4_0.imethod_28());
			return string_2;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Code: (paste registration code here:)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activation Code:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "QEQ9D-3YLE2-59JG9-GNW6U-R7Y2W";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "License Key:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 257);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Nice Label 2017 Keygen by Arman Ridho";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
