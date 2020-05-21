//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	public enum RepPrefixKind 
	{
		[Comment("No #(c:REP)#/#(c:REPE)#/#(c:REPNE)# prefix")]
		None,

		[Comment("#(c:REP)#/#(c:REPE)# prefix")]
		Repe,

		[Comment("#(c:REPNE)# prefix")]
		Repne,
	}
}