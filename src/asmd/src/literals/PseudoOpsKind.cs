//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	public enum PseudoOpsKind 
	{
		cmpps,
	
		vcmpps,
	
		cmppd,
	
		vcmppd,
	
		cmpss,
	
		vcmpss,
	
		cmpsd,
	
		vcmpsd,
	
		pclmulqdq,
	
		vpclmulqdq,
	
		vpcomb,
	
		vpcomw,
	
		vpcomd,
	
		vpcomq,
	
		vpcomub,
	
		vpcomuw,
	
		vpcomud,
	
		vpcomuq,
	}
}