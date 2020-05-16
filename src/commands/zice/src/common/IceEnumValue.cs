//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

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

		public override string ToString()
			=> RawName;
	}
}