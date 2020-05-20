//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;

	public enum OpHandlerKind 
	{
		None,

		OpA,

		OpHx,

		OpI2,

		OpIb,

		OpIb11,

		OpIb21,

		OpId,

		OpImm,

		OpIq,

		OpIs4x,

		OpIw,

		OpJ,

		OpJdisp,

		OpJx,

		OpModRM_reg,

		OpModRM_reg_mem,

		OpModRM_regF0,

		OpModRM_rm,

		OpModRM_rm_mem_only,

		OpModRM_rm_reg_only,

		OpMRBX,

		OpO,

		OprDI,

		OpReg,

		OpRegEmbed8,

		OpRegSTi,

		OpVMx,

		OpX,

		OpY,
	}	

}