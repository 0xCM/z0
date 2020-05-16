//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{
    using System;
    using System.Reflection;
	using System.Linq;

	public sealed class LegacyOpCodeInfo : OpEncodingInfo 
    {
		public override EncodingKind Encoding => EncodingKind.Legacy;
		
        public OperandSize OperandSize { get; }
		
        public AddressSize AddressSize { get; }
		
        public LegacyOpKind[] OpKinds { get; }

		public override int OpKindsLength => OpKinds.Length;

		public override OpCodeOperandKind OpKind(int arg) {
			var kind = OpKinds[arg];
			return (OpCodeOperandKind)EncoderTypes.LegacyOpHandlers[(int)kind].opCodeOperandKind.Value;
		} 
		
		public LegacyOpCodeInfo(IceEnumValue code, MandatoryPrefix mandatoryPrefix, OpCodeTableKind table, uint opCode, int groupIndex, OperandSize operandSize, AddressSize addressSize, OpCodeFlags flags, LegacyOpKind[] opKinds) {
			Code = code;
			MandatoryPrefix = mandatoryPrefix;
			Table = table;
			OpCode = opCode;
			GroupIndex = groupIndex;
			Flags = flags;
			OperandSize = operandSize;
			AddressSize = addressSize;
			OpKinds = opKinds;
		}
	}
}