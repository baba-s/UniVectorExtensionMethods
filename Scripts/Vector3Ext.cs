using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// Vector3 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class Vector3Ext
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 値を四捨五入して返します
		/// </summary>
		public static Vector3 Round( this Vector3 self )
		{
			return new Vector3
			(
				Mathf.Round( self.x ),
				Mathf.Round( self.y ),
				Mathf.Round( self.z )
			);
		}
	}
}