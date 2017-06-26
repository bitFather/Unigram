// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChannelMigrateFrom : TLMessageActionBase 
	{
		public String Title { get; set; }
		public Int32 ChatId { get; set; }

		public TLMessageActionChannelMigrateFrom() { }
		public TLMessageActionChannelMigrateFrom(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChannelMigrateFrom; } }

		public override void Read(TLBinaryReader from)
		{
			Title = from.ReadString();
			ChatId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Title ?? string.Empty);
			to.WriteInt32(ChatId);
		}
	}
}