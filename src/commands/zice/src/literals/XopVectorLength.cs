//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

	public enum XopVectorLength 
    {
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

}