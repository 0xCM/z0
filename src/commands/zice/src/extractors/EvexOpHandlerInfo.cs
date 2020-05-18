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

	public readonly struct EvexOpHandlerInfo
	{
		public static EvexOpHandlerInfo[] Load()
		{
			var src = EncoderTypes.EvexOpHandlers;
			var dst = new EvexOpHandlerInfo[src.Length];
			for(var i=0; i<dst.Length; i++)
				dst[i] = src[i];
			return dst;
		}
		public static implicit operator EvexOpHandlerInfo((IceEnumValue OperandKind, IceEnumValue EvexKind, OpHandlerKind HandlerKind, object[] Args) src)
			=> new EvexOpHandlerInfo(src.OperandKind, src.EvexKind, src.HandlerKind, src.Args);
		public EvexOpHandlerInfo(IceEnumValue OperandKind, IceEnumValue EvexKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = (OpCodeOperandKind)OperandKind.Value;
			this.EvexKind = (EvexOpKind)EvexKind.Value;
			this.HandlerKind = HandlerKind;
			this.Args = Args;

		}
		public EvexOpHandlerInfo(OpCodeOperandKind OperandKind, EvexOpKind EvexKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = OperandKind;
			this.EvexKind = EvexKind;
			this.HandlerKind = HandlerKind;
			this.Args = Args;
		}
		public readonly OpCodeOperandKind OperandKind;

		public readonly EvexOpKind EvexKind;

		public readonly OpHandlerKind HandlerKind;

		public readonly object[] Args;
	}
}