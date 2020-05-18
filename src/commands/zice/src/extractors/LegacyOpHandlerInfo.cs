//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

	public readonly struct LegacyOpHandlerInfo
	{
		public static LegacyOpHandlerInfo[] Load()
		{
			var src = EncoderTypes.LegacyOpHandlers;
			var dst = new LegacyOpHandlerInfo[src.Length];
			for(var i=0; i<dst.Length; i++)
				dst[i] = src[i];
			return dst;
		}
		public static implicit operator LegacyOpHandlerInfo((IceEnumValue OperandKind, IceEnumValue LegacyKind, OpHandlerKind HandlerKind, object[] Args) src)
			=> new LegacyOpHandlerInfo(src.OperandKind, src.LegacyKind, src.HandlerKind, src.Args);
		public LegacyOpHandlerInfo(IceEnumValue OperandKind, IceEnumValue LegacyKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = (OpCodeOperandKind)OperandKind.Value;
			this.LegacyKind = (LegacyOpKind)LegacyKind.Value;
			this.HandlerKind = HandlerKind;
			this.Args = Args;

		}
		public LegacyOpHandlerInfo(OpCodeOperandKind OperandKind, LegacyOpKind LegacyKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = OperandKind;
			this.LegacyKind = LegacyKind;
			this.HandlerKind = HandlerKind;
			this.Args = Args;
		}
		public readonly OpCodeOperandKind OperandKind;

		public readonly LegacyOpKind LegacyKind;

		public readonly OpHandlerKind HandlerKind;

		public readonly object[] Args;
	}
}