//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	public enum AllowedPrefixes 
	{
		None,
		
		Bnd,
		
		BndNotrack,
		
		HintTakenBnd,
		
		Lock,
		
		Rep,
		
		RepRepne,
		
		XacquireXreleaseLock,
		
		Xrelease,
	}
}