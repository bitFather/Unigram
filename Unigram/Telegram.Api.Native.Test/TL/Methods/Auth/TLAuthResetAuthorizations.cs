// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.resetAuthorizations.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAuthResetAuthorizations : TLObject
	{
		public TLAuthResetAuthorizations() { }
		public TLAuthResetAuthorizations(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthResetAuthorizations; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x9FAB0D1A);
		}
	}
}