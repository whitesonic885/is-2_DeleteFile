using System;

namespace DeleteFile
{
	/// <summary>
	/// DeleteFile の概要の説明です。
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2009.12.01 東都）高木 ファイル[proxy.ini]の追加 
	//--------------------------------------------------------------------------
	public class DeleteFile
	{
		static void Main(string[] args)
		{
			// 
			// TODO: コンストラクタ ロジックをここに追加してください。
			//
			if (args.Length != 1) return;
			if (System.IO.File.Exists(args[0]))
			{
// MOD 2009.12.01 東都）高木 ファイルの追加 START
//				if (args[0].Substring(args[0].LastIndexOf("\\") + 1).Equals("wis2.dll")) System.IO.File.Delete(args[0]);
				if(args[0].EndsWith("\\wis2.dll")
				|| args[0].EndsWith("\\proxy.ini")){
					System.IO.File.Delete(args[0]);
				}
// MOD 2009.12.01 東都）高木 ファイルの追加 END
			}
		}
	}
}
