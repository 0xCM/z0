//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public enum EncodingKind 
    {
		[Comment("Legacy encoding")]
		Legacy,
		[Comment("VEX encoding")]
		VEX,
		[Comment("EVEX encoding")]
		EVEX,
		[Comment("XOP encoding")]
		XOP,
		[Comment("3DNow! encoding")]
		D3NOW,
	}


	static class EncodingKindEnum {
		const string documentation = "Instruction encoding";

		static IceEnumValue[] GetValues() =>
			typeof(EncodingKind).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(EncodingKind)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.EncodingKind, documentation, GetValues(), EnumTypeFlags.Public);
	}
}