//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

	public sealed class VexOpCodeInfo : OpCodeInfo {
		public override EncodingKind Encoding => EncodingKind.VEX;
		public VexVectorLength VectorLength { get; }
		public VexOpKind[] OpKinds { get; }

		public override int OpKindsLength => OpKinds.Length;

		public override OpCodeOperandKind OpKind(int arg) {
			var kind = OpKinds[arg];
			return (OpCodeOperandKind)EncoderTypes.VexOpHandlers[(int)kind].opCodeOperandKind.Value;
		}
		
		public VexOpCodeInfo(IceEnumValue code, MandatoryPrefix mandatoryPrefix, OpCodeTableKind table, uint opCode, int groupIndex, VexVectorLength vecLen, OpCodeFlags flags, VexOpKind[] opKinds) {
			Code = code;
			MandatoryPrefix = mandatoryPrefix;
			Table = table;
			OpCode = opCode;
			GroupIndex = groupIndex;
			Flags = flags;
			VectorLength = vecLen;
			OpKinds = opKinds;
		}
	}
}