using UnityEngine;
using System.Collections;
using KiiCorp.Cloud.Storage;

namespace Kii
{
	public class UserMaster : MonoBehaviour
	{
		/// <summary>
		/// ユーザー登録
		/// </summary>
		public static void Regist ()
		{
			KiiUser.Builder builder;
			builder = KiiUser.BuilderWithName ("user_123456");
			builder.WithEmail ("user_123456@example.com");
			builder.WithPhone ("+819012345678");
			KiiUser user = builder.Build ();
			
			user.Register ("123ABC", (KiiUser registeredUser, System.Exception e) => {
				if (e != null) {
					// handle error
					return;
				}
			
			});
				
		}

		/// <summary>
		/// ユーザー情報更新
		/// </summary>
		public static void Update ()
		{
			
		}

		/// <summary>
		/// ログイン
		/// </summary>
		public static void Login ()
		{
			
		}

		/// <summary>
		/// ログアウト
		/// </summary>
		public static void Logout ()
		{
			
		}
	}
}