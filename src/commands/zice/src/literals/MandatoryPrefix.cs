//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;
	
	public enum MandatoryPrefix 
	{
		[Comment("No mandatory prefix (legacy and 3DNow! tables only)")]
		None,
		[Comment("Empty mandatory prefix (no #(c:66)#, #(c:F3)# or #(c:F2)# prefix)")]
		PNP,
		[Comment("#(c:66)# prefix")]
		P66,
		[Comment("#(c:F3)# prefix")]
		PF3,
		[Comment("#(c:F2)# prefix")]
		PF2,
	}
}