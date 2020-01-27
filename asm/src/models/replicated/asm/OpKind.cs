//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs 
{
	/// <summary>
	/// Instruction operand kind
	/// </summary>
	public enum OpKind 
	{
		/// <summary>
		/// A register (<see cref="Intel.Register"/>).
		/// 
		/// This operand kind uses <see cref="Instruction.Op0Register"/>, <see cref="Instruction.Op1Register"/>,
		/// <see cref="Instruction.Op2Register"/> or <see cref="Instruction.Op3Register"/> depending on operand number.
		/// See also <see cref="Instruction.GetOpRegister(int)"/>.
		/// </summary>
		Register = 0,// Code assumes this is 0

		/// <summary>
		/// Near 16-bit branch. This operand kind uses <see cref="Instruction.NearBranch16"/>
		/// </summary>
		NearBranch16,

		/// <summary>
		/// Near 32-bit branch. This operand kind uses <see cref="Instruction.NearBranch32"/>
		/// </summary>
		NearBranch32,

		/// <summary>
		/// Near 64-bit branch. This operand kind uses <see cref="Instruction.NearBranch64"/>
		/// </summary>
		NearBranch64,

		/// <summary>
		/// Far 16-bit branch. This operand kind uses <see cref="Instruction.FarBranch16"/> and <see cref="Instruction.FarBranchSelector"/>
		/// </summary>
		FarBranch16,

		/// <summary>
		/// Far 32-bit branch. This operand kind uses <see cref="Instruction.FarBranch32"/> and <see cref="Instruction.FarBranchSelector"/>
		/// </summary>
		FarBranch32,

		/// <summary>
		/// 8-bit constant. This operand kind uses <see cref="Instruction.Immediate8"/>
		/// </summary>
		Immediate8,

		/// <summary>
		/// 8-bit constant used by the enter, extrq, insertq instructions. This operand kind uses <see cref="Instruction.Immediate8_2nd"/>
		/// </summary>
		Immediate8_2nd,

		/// <summary>
		/// 16-bit constant. This operand kind uses <see cref="Instruction.Immediate16"/>
		/// </summary>
		Immediate16,

		/// <summary>
		/// 32-bit constant. This operand kind uses <see cref="Instruction.Immediate32"/>
		/// </summary>
		Immediate32,

		/// <summary>
		/// 64-bit constant. This operand kind uses <see cref="Instruction.Immediate64"/>
		/// </summary>
		Immediate64,

		/// <summary>
		/// An 8-bit value sign extended to 16 bits. This operand kind uses <see cref="Instruction.Immediate8to16"/>
		/// </summary>
		Immediate8to16,

		/// <summary>
		/// An 8-bit value sign extended to 32 bits. This operand kind uses <see cref="Instruction.Immediate8to32"/>
		/// </summary>
		Immediate8to32,

		/// <summary>
		/// An 8-bit value sign extended to 64 bits. This operand kind uses <see cref="Instruction.Immediate8to64"/>
		/// </summary>
		Immediate8to64,

		/// <summary>
		/// A 32-bit value sign extended to 64 bits. This operand kind uses <see cref="Instruction.Immediate32to64"/>
		/// </summary>
		Immediate32to64,

		/// <summary>
		/// seg:[si]. This operand kind uses <see cref="Instruction.MemorySize"/>, <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		MemorySegSI,

		/// <summary>
		/// seg:[esi]. This operand kind uses <see cref="Instruction.MemorySize"/>, <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		MemorySegESI,

		/// <summary>
		/// seg:[rsi]. This operand kind uses <see cref="Instruction.MemorySize"/>, <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		MemorySegRSI,

		/// <summary>
		/// seg:[di]. This operand kind uses <see cref="Instruction.MemorySize"/>, <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		MemorySegDI,

		/// <summary>
		/// seg:[edi]. This operand kind uses <see cref="Instruction.MemorySize"/>, <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		MemorySegEDI,

		/// <summary>
		/// seg:[rdi]. This operand kind uses <see cref="Instruction.MemorySize"/>, <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		MemorySegRDI,

		/// <summary>
		/// es:[di]. This operand kind uses <see cref="Instruction.MemorySize"/>
		/// </summary>
		MemoryESDI,

		/// <summary>
		/// es:[edi]. This operand kind uses <see cref="Instruction.MemorySize"/>
		/// </summary>
		MemoryESEDI,

		/// <summary>
		/// es:[rdi]. This operand kind uses <see cref="Instruction.MemorySize"/>
		/// </summary>
		MemoryESRDI,

		/// <summary>
		/// 64-bit offset [xxxxxxxxxxxxxxxx]. This operand kind uses <see cref="Instruction.MemoryAddress64"/>,
		/// <see cref="Instruction.MemorySegment"/>, <see cref="Instruction.SegmentPrefix"/>, <see cref="Instruction.MemorySize"/>
		/// </summary>
		Memory64,

		/// <summary>
		/// Memory operand.
		/// 
		/// This operand kind uses <see cref="Instruction.MemoryDisplSize"/>, <see cref="Instruction.MemorySize"/>,
		/// <see cref="Instruction.MemoryIndexScale"/>, <see cref="Instruction.MemoryDisplacement"/>,
		/// <see cref="Instruction.MemoryBase"/>, <see cref="Instruction.MemoryIndex"/>, <see cref="Instruction.MemorySegment"/>,
		/// <see cref="Instruction.SegmentPrefix"/>
		/// </summary>
		Memory,
	}
}
