//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;


	static class RegisterEnum 
	{
		const string documentation = "A register";

		public const int NumValues = 241;

		static IceEnumValue[] GetValues() =>
			typeof(Register).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(Register)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.Register, documentation, GetValues(), EnumTypeFlags.Public);
	}

	public struct IceEnumValue  
    {
		public Type DeclaringType {get;}

		public uint Value {get;}

		public string RawName {get;}

		public string Documentation {get; set;}

		public IceEnumValue(uint value, string name, string documentation) 
        {
			DeclaringType = typeof(void);
			Value = value;
			RawName = name;
			Documentation = documentation;
		}
	}

	public abstract class OpEncodingInfo 
    {
		public abstract EncodingKind Encoding { get; }
		public IceEnumValue Code { get; protected set; }
		
        public MandatoryPrefix MandatoryPrefix { get; protected set; }
		
        public OpCodeTableKind Table { get; protected set; }
		
        public uint OpCode { get; protected set; }
		
        public int GroupIndex { get; protected set; }
		
        public OpCodeFlags Flags { get; protected set; }

		public abstract int OpKindsLength { get; }

		public abstract OpCodeOperandKind OpKind(int arg); 

		public override string ToString() => $"{this.GetType().Name}: {Code.RawName}";
	}

	sealed class D3nowOpCodeInfo : OpEncodingInfo {
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

	enum XopVectorLength {
		L128,
		L256,
		L0,
		L1,
	}

	static class XopVectorLengthEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(XopVectorLength).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(XopVectorLength)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.XopVectorLength, documentation, GetValues(), EnumTypeFlags.None);
	}

	sealed class XopOpCodeInfo : OpEncodingInfo {
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