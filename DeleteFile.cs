using System;

namespace DeleteFile
{
	/// <summary>
	/// DeleteFile �̊T�v�̐����ł��B
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2009.12.01 ���s�j���� �t�@�C��[proxy.ini]�̒ǉ� 
	//--------------------------------------------------------------------------
	public class DeleteFile
	{
		static void Main(string[] args)
		{
			// 
			// TODO: �R���X�g���N�^ ���W�b�N�������ɒǉ����Ă��������B
			//
			if (args.Length != 1) return;
			if (System.IO.File.Exists(args[0]))
			{
// MOD 2009.12.01 ���s�j���� �t�@�C���̒ǉ� START
//				if (args[0].Substring(args[0].LastIndexOf("\\") + 1).Equals("wis2.dll")) System.IO.File.Delete(args[0]);
				if(args[0].EndsWith("\\wis2.dll")
				|| args[0].EndsWith("\\proxy.ini")){
					System.IO.File.Delete(args[0]);
				}
// MOD 2009.12.01 ���s�j���� �t�@�C���̒ǉ� END
			}
		}
	}
}
