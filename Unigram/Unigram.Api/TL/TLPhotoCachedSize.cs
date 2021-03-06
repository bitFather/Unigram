// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPhotoCachedSize : TLPhotoSizeBase 
	{
		public TLFileLocationBase Location { get; set; }
		public Int32 W { get; set; }
		public Int32 H { get; set; }
		public Byte[] Bytes { get; set; }

		public TLPhotoCachedSize() { }
		public TLPhotoCachedSize(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhotoCachedSize; } }

		public override void Read(TLBinaryReader from)
		{
			Type = from.ReadString();
			Location = TLFactory.Read<TLFileLocationBase>(from);
			W = from.ReadInt32();
			H = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Type ?? string.Empty);
			to.WriteObject(Location);
			to.WriteInt32(W);
			to.WriteInt32(H);
			to.WriteByteArray(Bytes);
		}
	}
}