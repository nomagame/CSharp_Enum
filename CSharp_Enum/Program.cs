using System;

namespace CSharp_Enum
{
	/// <summary>
	/// Week.2016.12.4
	/// </summary>
	//	定义枚举类型
	enum week
	{
		Monday,		//周一
		Tuesday,	//周二
		Wednesday,	//周三
		Thursday,	//周四
		Friday,		//周五
		Saturday,	//周六
		Sunday		//周日
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			//枚举类型初始化
			week day = week.Friday;
			Console.WriteLine (day);
			Console.ReadKey ();
		}
	}
}
