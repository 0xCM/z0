//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	static class EncodingKindEnum {
		const string documentation = "Instruction encoding";

		static IceEnumValue[] GetValues() =>
			typeof(EncodingKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(EncodingKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.EncodingKind, documentation, GetValues(), EnumTypeFlags.Public);
	}

	static class FlowControlEnum {
		const string documentation = "Flow control";

		static IceEnumValue[] GetValues() =>
			typeof(FlowControl).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(FlowControl)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.FlowControl, documentation, GetValues(), EnumTypeFlags.Public);
	}


	static class CpuidFeatureEnum {
		const string documentation = "#(c:CPUID)# feature flags";

		static IceEnumValue[] GetValues() =>
			typeof(CpuidFeature).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(CpuidFeature)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.CpuidFeature, documentation, GetValues(), EnumTypeFlags.Public);
	}    


	static class EvexVectorLengthEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(EvexVectorLength).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(EvexVectorLength)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.EvexVectorLength, documentation, GetValues(), EnumTypeFlags.None);
	}	

	static class MemorySizeEnum {
		const string documentation = "Size of a memory reference";
		public const int NumValues = 136;

		static IceEnumValue[] GetValues() =>
			typeof(MemorySize).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(MemorySize)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.MemorySize, documentation, GetValues(), EnumTypeFlags.Public);
	}	


	static class OpKindEnum {
		const string documentation = "Instruction operand kind";

		static IceEnumValue[] GetValues() =>
			typeof(OpKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(OpKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.OpKind, documentation, GetValues(), EnumTypeFlags.Public);
	}	


	static class EvexOpKindEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(EvexOpKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(EvexOpKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.EvexOpKind, documentation, GetValues(), EnumTypeFlags.NoInitialize);
	}	


	static class VexOpKindEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(VexOpKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(VexOpKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.VexOpKind, documentation, GetValues(), EnumTypeFlags.NoInitialize);
	}

	static class LegacyOpKindEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(LegacyOpKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(LegacyOpKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.LegacyOpKind, documentation, GetValues(), EnumTypeFlags.NoInitialize);
	}


	static class XopOpKindEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(XopOpKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(XopOpKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.XopOpKind, documentation, GetValues(), EnumTypeFlags.NoInitialize);
	}


	static class OpCodeOperandKindEnum {
		const string documentation = "Operand kind";

		static IceEnumValue[] GetValues() =>
			typeof(OpCodeOperandKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(OpCodeOperandKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.OpCodeOperandKind, documentation, GetValues(), EnumTypeFlags.Public);
	}


	static class RegisterEnum 
	{
		const string documentation = "A register";

		public const int NumValues = 241;

		static IceEnumValue[] GetValues() =>
			typeof(Register).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(Register)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.Register, documentation, GetValues(), EnumTypeFlags.Public);
	}

	static class VexVectorLengthEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(VexVectorLength).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(VexVectorLength)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.VexVectorLength, documentation, GetValues(), EnumTypeFlags.None);
	}

	static class XopVectorLengthEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(XopVectorLength).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(XopVectorLength)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.XopVectorLength, documentation, GetValues(), EnumTypeFlags.None);
	}

}