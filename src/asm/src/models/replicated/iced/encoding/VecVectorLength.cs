//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{
    using System;
    using System.Reflection;
	using System.Linq;

	public enum VexVectorLength 
	{
		LZ,
		L0,
		L1,
		L128,
		L256,
		LIG,
	}

	static class VexVectorLengthEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(VexVectorLength).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(VexVectorLength)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.VexVectorLength, documentation, GetValues(), EnumTypeFlags.None);
	}

}