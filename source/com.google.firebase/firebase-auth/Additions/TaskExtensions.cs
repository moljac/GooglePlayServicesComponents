using System;
using System.Threading.Tasks;
using Android.Gms.Extensions;

namespace Firebase
{
	/*
	This was part of firebase-common now moved to firebase-auth and as Extensions
	public partial class FirebaseApp
	{
		public Task<Firebase.Auth.GetTokenResult> GetTokenAsync(bool flag)
		{
			return GetToken(flag).AsAsync<Firebase.Auth.GetTokenResult>();
		}
	}
	*/
	public static class FirebaseAppExtensions
	{
		public static Task<Firebase.Auth.GetTokenResult> GetTokenAsync(this FirebaseApp app, bool flag)
		{
			return GetToken(flag).AsAsync<Firebase.Auth.GetTokenResult>();
		}
	}
}