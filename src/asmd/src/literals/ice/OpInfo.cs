//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public enum OpInfo 
	{
		None,
		
		CondRead,
		
		CondWrite,
		
		// CMOVcc with GPR32 dest in 64-bit mode: upper 32 bits of full 64-bit reg are always cleared.
		CondWrite32_ReadWrite64,
		
		NoMemAccess,
		
		Read,
		
		ReadCondWrite,
		
		ReadP3,
		
		ReadWrite,
		
		Write,
		
		// Don't convert Write to ReadWrite, eg. EVEX_Vblendmpd_xmm_k1z_xmm_xmmm128b64 since it always overwrites dest
		WriteForce,
		
		WriteMem_ReadWriteReg,
	}
}