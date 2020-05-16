//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

	sealed class XopOpCodeInfo : OpCodeInfo 
    {
		public override EncodingKind Encoding => EncodingKind.XOP;
		public XopVectorLength VectorLength { get; }
		public XopOpKind[] OpKinds { get; }
		
		public override int OpKindsLength => OpKinds.Length;

		public override OpCodeOperandKind OpKind(int arg) {
			var kind = OpKinds[arg];
			return (OpCodeOperandKind)EncoderTypes.XopOpHandlers[(int)kind].opCodeOperandKind.Value;
		} 
		
		public XopOpCodeInfo(IceEnumValue code, MandatoryPrefix mandatoryPrefix, OpCodeTableKind table, uint opCode, int groupIndex, XopVectorLength vecLen, OpCodeFlags flags, XopOpKind[] opKinds) {
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