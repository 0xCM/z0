//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public sealed class EvexOpCodeInfo : OpCodeInfo 
	{
		public override EncodingKind Encoding => EncodingKind.EVEX;
		public EvexVectorLength VectorLength { get; }
		public TupleType TupleType { get; }
		public EvexOpKind[] OpKinds { get; }
		
		public override int OpKindsLength => OpKinds.Length;

		public override OpCodeOperandKind OpKind(int arg) {
			var kind = OpKinds[arg];
			return (OpCodeOperandKind)EncoderTypes.EvexOpHandlers[(int)kind].opCodeOperandKind.Value;
		} 
		
		public EvexOpCodeInfo(IceEnumValue code, MandatoryPrefix mandatoryPrefix, OpCodeTableKind table, uint opCode, int groupIndex, EvexVectorLength vecLen, TupleType tupleType, OpCodeFlags flags, EvexOpKind[] opKinds) {
			Code = code;
			MandatoryPrefix = mandatoryPrefix;
			Table = table;
			OpCode = opCode;
			GroupIndex = groupIndex;
			Flags = flags;
			VectorLength = vecLen;
			OpKinds = opKinds;
			TupleType = tupleType;
		}
	}
}