//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public enum EvexVectorLength 
	{
		L128,
		L256,
		L512,
	}

	static class EvexVectorLengthEnum {
		const string documentation = null;

		static IceEnumValue[] GetValues() =>
			typeof(EvexVectorLength).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(EvexVectorLength)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.EvexVectorLength, documentation, GetValues(), EnumTypeFlags.None);
	}	

}