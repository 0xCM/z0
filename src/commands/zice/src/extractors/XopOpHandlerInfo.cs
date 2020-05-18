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

	public readonly struct XopOpHandlerInfo
	{
		public static XopOpHandlerInfo[] Load()
		{
			var src = EncoderTypes.XopOpHandlers;
			var dst = new XopOpHandlerInfo[src.Length];
			for(var i=0; i<dst.Length; i++)
				dst[i] = src[i];
			return dst;
		}
		public static implicit operator XopOpHandlerInfo((IceEnumValue OperandKind, IceEnumValue XopKind, OpHandlerKind HandlerKind, object[] Args) src)
			=> new XopOpHandlerInfo(src.OperandKind, src.XopKind, src.HandlerKind, src.Args);
		public XopOpHandlerInfo(IceEnumValue OperandKind, IceEnumValue XopKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = (OpCodeOperandKind)OperandKind.Value;
			this.XopKind = (XopOpKind)XopKind.Value;
			this.HandlerKind = HandlerKind;
			this.Args = Args;

		}
		public XopOpHandlerInfo(OpCodeOperandKind OperandKind, XopOpKind XopKind, OpHandlerKind HandlerKind, object[] Args)
		{
			this.OperandKind = OperandKind;
			this.XopKind = XopKind;
			this.HandlerKind = HandlerKind;
			this.Args = Args;
		}
		public readonly OpCodeOperandKind OperandKind;

		public readonly XopOpKind XopKind;

		public readonly OpHandlerKind HandlerKind;

		public readonly object[] Args;
	}
}