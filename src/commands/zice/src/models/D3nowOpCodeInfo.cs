//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

	sealed class D3nowOpCodeInfo : OpCodeInfo 
    {
		public override EncodingKind Encoding => EncodingKind.D3NOW;
		public uint Immediate8 { get; }
		
		public override int OpKindsLength => 2;

		public override OpCodeOperandKind OpKind(int arg) {
			if (arg == 0) return OpCodeOperandKind.mm_reg;
			if (arg == 1) return OpCodeOperandKind.mm_or_mem;
			throw new ArgumentOutOfRangeException($"{arg}");
		} 
		
		public D3nowOpCodeInfo(IceEnumValue code, uint immediate8, OpCodeFlags flags) {
			Code = code;
			MandatoryPrefix = MandatoryPrefix.None;
			Table = OpCodeTableKind.T0F;
			OpCode = 0x0F;
			GroupIndex = -1;
			Flags = flags;
			Immediate8 = immediate8;
		}
	}	
}