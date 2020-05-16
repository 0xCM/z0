//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public enum FlowControl 
	{
		[Comment("The next instruction that will be executed is the next instruction in the instruction stream")]
		Next,
		[Comment("It's an unconditional branch instruction: #(c:JMP NEAR)#, #(c:JMP FAR)#")]
		UnconditionalBranch,
		[Comment("It's an unconditional indirect branch: #(c:JMP NEAR reg)#, #(c:JMP NEAR [mem])#, #(c:JMP FAR [mem])#")]
		IndirectBranch,
		[Comment("It's a conditional branch instruction: #(c:Jcc SHORT)#, #(c:Jcc NEAR)#, #(c:LOOP)#, #(c:LOOPcc)#, #(c:JRCXZ)#")]
		ConditionalBranch,
		[Comment("It's a return instruction: #(c:RET NEAR)#, #(c:RET FAR)#, #(c:IRET)#, #(c:SYSRET)#, #(c:SYSEXIT)#, #(c:RSM)#, #(c:VMLAUNCH)#, #(c:VMRESUME)#, #(c:VMRUN)#, #(c:SKINIT)#")]
		Return,
		[Comment("It's a call instruction: #(c:CALL NEAR)#, #(c:CALL FAR)#, #(c:SYSCALL)#, #(c:SYSENTER)#, #(c:VMCALL)#, #(c:VMMCALL)#")]
		Call,
		[Comment("It's an indirect call instruction: #(c:CALL NEAR reg)#, #(c:CALL NEAR [mem])#, #(c:CALL FAR [mem])#")]
		IndirectCall,
		[Comment("It's an interrupt instruction: #(c:INT n)#, #(c:INT3)#, #(c:INT1)#, #(c:INTO)#")]
		Interrupt,
		[Comment("It's #(c:XBEGIN)#, #(c:XABORT)#, #(c:XEND)#, #(c:XSUSLDTRK)#, #(c:XRESLDTRK)#")]
		XbeginXabortXend,
		[Comment("It's an invalid instruction, eg. #(e:Code.INVALID)#, #(c:UD0)#, #(c:UD1)#, #(c:UD2)#")]
		Exception,
	}

	static class FlowControlEnum {
		const string documentation = "Flow control";

		static IceEnumValue[] GetValues() =>
			typeof(FlowControl).GetFields().Where(a => a.IsLiteral).Select(a => new IceEnumValue((uint)(FlowControl)a.GetValue(null)!, a.Name, CommentAttribute.GetDocumentation(a))).ToArray();

		public static readonly EnumType Instance = new EnumType(TypeIds.FlowControl, documentation, GetValues(), EnumTypeFlags.Public);
	}


}