//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Seed;
    using static Memories;

	using Flags = OpCodeDataFlags;

	public struct OpCodeDataAdapter
	{
		public static string GetOpCodeString(OpCodeDataBlock src)
		{
			var adapter = new OpCodeDataAdapter(src);
			var ocs = new OpCodeFormatter(adapter, new StringBuilder(), src.lkind).Format();
			return ocs;
		}

		readonly OpCodeDataBlock Src;

		[MethodImpl(Inline)]
		public static implicit operator OpCodeDataAdapter(in OpCodeDataBlock src)
			=> new OpCodeDataAdapter(src);

		[MethodImpl(Inline)]
		public OpCodeDataAdapter(in OpCodeDataBlock src)
		{
			Src = src;			
		}
		
		/// <summary>
		/// Gets the code
		/// </summary>
		public Code Code => (Code)Src.CodeId;

		/// <summary>
		/// Gets the encoding
		/// </summary>
		public EncodingKind Encoding => Src.Encoding;

		/// <summary>
		/// <see langword="true"/> if it's an instruction, <see langword="false"/> if it's eg. <see cref="Code.INVALID"/>, <c>db</c>, <c>dw</c>, <c>dd</c>, <c>dq</c>
		/// </summary>
		public bool IsInstruction => (Src.Flags & Flags.NoInstruction) == 0;

		/// <summary>
		/// <see langword="true"/> if it's an instruction available in 16-bit mode
		/// </summary>
		public bool Mode16 => (Src.Flags & Flags.Mode16) != 0;

		/// <summary>
		/// <see langword="true"/> if it's an instruction available in 32-bit mode
		/// </summary>
		public bool Mode32 => (Src.Flags & Flags.Mode32) != 0;

		/// <summary>
		/// <see langword="true"/> if it's an instruction available in 64-bit mode
		/// </summary>
		public bool Mode64 => (Src.Flags & Flags.Mode64) != 0;

		/// <summary>
		/// <see langword="true"/> if an <c>FWAIT</c> (<c>9B</c>) instruction is added before the instruction
		/// </summary>
		public bool Fwait => (Src.Flags & Flags.Fwait) != 0;

		/// <summary>
		/// (Legacy encoding) Gets the required operand size (16,32,64) or 0 if no operand size prefix (<c>66</c>) or <c>REX.W</c> prefix is needed
		/// </summary>
		public int OperandSize => Src.operandSize;


		/// <summary>
		/// (Legacy encoding) Gets the required address size (16,32,64) or 0 if no address size prefix (<c>67</c>) is needed
		/// </summary>
		public int AddressSize => Src.addressSize;

		/// <summary>
		/// (VEX/XOP/EVEX) <c>L</c> / <c>L'L</c> value or default value if <see cref="IsLIG"/> is <see langword="true"/>
		/// </summary>
		public uint L => Src.l;

		/// <summary>
		/// (VEX/XOP/EVEX) <c>W</c> value or default value if <see cref="IsWIG"/> or <see cref="IsWIG32"/> is <see langword="true"/>
		/// </summary>
		public uint W => (Src.Flags & Flags.W) != 0 ? 1U : 0;

		/// <summary>
		/// (VEX/XOP/EVEX) <see langword="true"/> if the <c>L</c> / <c>L'L</c> fields are ignored.
		/// <br/>
		/// EVEX: if reg-only ops and <c>{er}</c> (<c>EVEX.b</c> is set), <c>L'L</c> is the rounding control and not ignored.
		/// </summary>
		public bool IsLIG => (Src.Flags & Flags.LIG) != 0;

		/// <summary>
		/// (VEX/XOP/EVEX) <see langword="true"/> if the <c>W</c> field is ignored in 16/32/64-bit modes
		/// </summary>
		public bool IsWIG => (Src.Flags & Flags.WIG) != 0;

		/// <summary>
		/// (VEX/XOP/EVEX) <see langword="true"/> if the <c>W</c> field is ignored in 16/32-bit modes (but not 64-bit mode)
		/// </summary>
		public bool IsWIG32 => (Src.Flags & Flags.WIG32) != 0;

		/// <summary>
		/// (EVEX) Gets the tuple type
		/// </summary>
		public TupleType TupleType => (TupleType)Src.tupleType;

		/// <summary>
		/// (EVEX) <see langword="true"/> if the instruction supports broadcasting (<c>EVEX.b</c> bit) (if it has a memory operand)
		/// </summary>
		public bool CanBroadcast => (Src.Flags & Flags.Broadcast) != 0;

		/// <summary>
		/// (EVEX) <see langword="true"/> if the instruction supports rounding control
		/// </summary>
		public bool CanUseRoundingControl => (Src.Flags & Flags.RoundingControl) != 0;

		/// <summary>
		/// (EVEX) <see langword="true"/> if the instruction supports suppress all exceptions
		/// </summary>
		public bool CanSuppressAllExceptions => (Src.Flags & Flags.SuppressAllExceptions) != 0;

		/// <summary>
		/// (EVEX) <see langword="true"/> if an opmask register can be used
		/// </summary>
		public bool CanUseOpMaskRegister => (Src.Flags & Flags.OpMaskRegister) != 0;

		/// <summary>
		/// (EVEX) <see langword="true"/> if a non-zero opmask register must be used
		/// </summary>
		public bool RequireNonZeroOpMaskRegister => (Src.Flags & Flags.NonZeroOpMaskRegister) != 0;

		/// <summary>
		/// (EVEX) <see langword="true"/> if the instruction supports zeroing masking (if one of the opmask registers <c>K1</c>-<c>K7</c> is used and destination operand is not a memory operand)
		/// </summary>
		public bool CanUseZeroingMasking => (Src.Flags & Flags.ZeroingMasking) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>LOCK</c> (<c>F0</c>) prefix can be used
		/// </summary>
		public bool CanUseLockPrefix => (Src.Flags & Flags.LockPrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>XACQUIRE</c> (<c>F2</c>) prefix can be used
		/// </summary>
		public bool CanUseXacquirePrefix => (Src.Flags & Flags.XacquirePrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>XRELEASE</c> (<c>F3</c>) prefix can be used
		/// </summary>
		public bool CanUseXreleasePrefix => (Src.Flags & Flags.XreleasePrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>REP</c> / <c>REPE</c> (<c>F3</c>) prefixes can be used
		/// </summary>
		public bool CanUseRepPrefix => (Src.Flags & Flags.RepPrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>REPNE</c> (<c>F2</c>) prefix can be used
		/// </summary>
		public bool CanUseRepnePrefix => (Src.Flags & Flags.RepnePrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>BND</c> (<c>F2</c>) prefix can be used
		/// </summary>
		public bool CanUseBndPrefix => (Src.Flags & Flags.BndPrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>HINT-TAKEN</c> (<c>3E</c>) and <c>HINT-NOT-TAKEN</c> (<c>2E</c>) prefixes can be used
		/// </summary>
		public bool CanUseHintTakenPrefix => (Src.Flags & Flags.HintTakenPrefix) != 0;

		/// <summary>
		/// <see langword="true"/> if the <c>NOTRACK</c> (<c>3E</c>) prefix can be used
		/// </summary>
		public bool CanUseNotrackPrefix => (Src.Flags & Flags.NotrackPrefix) != 0;

		/// <summary>
		/// Gets the opcode table
		/// </summary>
		public OpCodeTableKind Table => (OpCodeTableKind)Src.table;

		/// <summary>
		/// Gets the mandatory prefix
		/// </summary>
		public MandatoryPrefix MandatoryPrefix => (MandatoryPrefix)Src.mandatoryPrefix;

		/// <summary>
		/// Gets the opcode. <c>000000xxh</c> if it's 1-byte, <c>0000yyxxh</c> if it's 2-byte (<c>yy</c> != <c>00</c>, and <c>yy</c> is the first byte and <c>xx</c> the second byte).
		/// It doesn't include the table value, see <see cref="Table"/>.
		/// <br/>
		/// Example values: <c>0xDFC0</c> (<see cref="Code.Ffreep_sti"/>), <c>0x01D8</c> (<see cref="Code.Vmrunw"/>), <c>0x2A</c> (<see cref="Code.Sub_r8_rm8"/>, <see cref="Code.Cvtpi2ps_xmm_mmm64"/>, etc).
		/// </summary>
		public uint OpCode => Src.OpCode;

		/// <summary>
		/// <see langword="true"/> if it's part of a group
		/// </summary>
		public bool IsGroup => Src.groupIndex>= 0;

		/// <summary>
		/// Group index (0-7) or -1. If it's 0-7, it's stored in the <c>reg</c> field of the <c>modrm</c> byte.
		/// </summary>
		public int GroupIndex => Src.groupIndex;

		/// <summary>
		/// Gets the number of operands
		/// </summary>
		public int OpCount => InstructionOpCounts.OpCount[(int)Src.CodeId];

		/// <summary>
		/// Gets operand #0's opkind
		/// </summary>
		public OpCodeOperandKind Op0Kind => (OpCodeOperandKind)Src.op0Kind;

		/// <summary>
		/// Gets operand #1's opkind
		/// </summary>
		public OpCodeOperandKind Op1Kind => (OpCodeOperandKind)Src.op1Kind;

		/// <summary>
		/// Gets operand #2's opkind
		/// </summary>
		public OpCodeOperandKind Op2Kind => (OpCodeOperandKind)Src.op2Kind;

		/// <summary>
		/// Gets operand #3's opkind
		/// </summary>
		public OpCodeOperandKind Op3Kind => (OpCodeOperandKind)Src.op3Kind;

		/// <summary>
		/// Gets operand #4's opkind
		/// </summary>
		public OpCodeOperandKind Op4Kind => (OpCodeOperandKind)Src.op4Kind;		

		/// <summary>
		/// Gets an operand's opkind
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		/// <returns></returns>
		public OpCodeOperandKind GetOpKind(int operand) =>
			operand switch {
				0 => Op0Kind,
				1 => Op1Kind,
				2 => Op2Kind,
				3 => Op3Kind,
				4 => Op4Kind,
				_ => throw new ArgumentOutOfRangeException(nameof(operand)),
			};

		/// <summary>
		/// Checks if the instruction is available in 16-bit mode, 32-bit mode or 64-bit mode
		/// </summary>
		/// <param name="bitness">16, 32 or 64</param>
		/// <returns></returns>
		public bool IsAvailableInMode(int bitness) =>
			bitness switch {
				16 => Mode16,
				32 => Mode32,
				64 => Mode64,
				_ => throw new ArgumentOutOfRangeException(nameof(bitness)),
			};
	}
}