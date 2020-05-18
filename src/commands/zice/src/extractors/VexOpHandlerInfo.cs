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

	public readonly struct VexOpHandlerInfo
	{
		public static VexOpHandlerInfo[] Load()
		{
			var src = EncoderTypes.VexOpHandlers;
			var dst = new VexOpHandlerInfo[src.Length];
			for(var i=0; i<dst.Length; i++)
				dst[i] = src[i];
			return dst;
		}
		public static implicit operator VexOpHandlerInfo((IceEnumValue OperandKind, IceEnumValue VexKind, OpHandlerKind HandlerKind, object[] Args) src)
			=> new VexOpHandlerInfo(src.OperandKind, src.VexKind, src.HandlerKind, src.Args);
		public VexOpHandlerInfo(IceEnumValue OperandKind, IceEnumValue VexKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = (OpCodeOperandKind)OperandKind.Value;
			this.VexKind = (VexOpKind)VexKind.Value;
			this.HandlerKind = HandlerKind;
			this.Args = Args;

		}
		public VexOpHandlerInfo(OpCodeOperandKind OperandKind, VexOpKind VexKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = OperandKind;
			this.VexKind = VexKind;
			this.HandlerKind = HandlerKind;
			this.Args = Args;
		}
		public readonly OpCodeOperandKind OperandKind;

		public readonly VexOpKind VexKind;

		public readonly OpHandlerKind HandlerKind;

		public readonly object[] Args;
	}
}