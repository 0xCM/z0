//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmOpCodeInfo
    {
        //
        // Summary:
        //     (EVEX) true if the instruction supports suppress all exceptions
        bool CanSuppressAllExceptions {get;}

        //
        // Summary:
        //     (EVEX) true if a non-zero opmask register must be used
        bool RequireNonZeroOpMaskRegister {get;}

        //
        // Summary:
        //     (EVEX) true if the instruction supports zeroing masking (if one of the opmask
        //     registers k1-k7 is used)
        bool CanUseZeroingMasking {get;}

        //
        // Summary:
        //     true if the LOCK (F0) prefix can be used
        bool CanUseLockPrefix {get;}

        //
        // Summary:
        //     true if the XACQUIRE (F2) prefix can be used
        bool CanUseXacquirePrefix {get;}

        //
        // Summary:
        //     true if the XRELEASE (F3) prefix can be used
        bool CanUseXreleasePrefix {get;}

        //
        // Summary:
        //     true if the REP / REPE (F3) prefixes can be used
        bool CanUseRepPrefix {get;}

        //
        // Summary:
        //     true if the REPNE (F2) prefix can be used
        bool CanUseRepnePrefix {get;}

        //
        // Summary:
        //     true if the BND (F2) prefix can be used
        bool CanUseBndPrefix  {get;}

        //
        // Summary:
        //     true if the HINT-TAKEN (3E) and HINT-NOT-TAKEN (2E) prefixes can be used
        bool CanUseHintTakenPrefix  {get;}

        //
        // Summary:
        //     true if the NOTRACK (3E) prefix can be used
        bool CanUseNotrackPrefix {get;}

        //
        // Summary:
        //     Gets the opcode table
        IceOpCodeTableKind Table {get;}

        //
        // Summary:
        //     Gets the mandatory prefix
        IceMandatoryPrefix MandatoryPrefix {get;}

        //
        // Summary:
        //     Gets the opcode. 00000000xxh if it's 1-byte, 0000yyxxh if it's 2-byte (yy !=
        //     00, and yy is the first byte and xx the second byte). It doesn't include the
        //     table value, see Iced.Intel.OpCodeInfo.Table. Example values: 0xDFC0 (Iced.Intel.Code.Ffreep_sti),
        //     0x01D8 (Iced.Intel.Code.Vmrunw), 0x2A (Iced.Intel.Code.Sub_r8_rm8, Iced.Intel.Code.Cvtpi2ps_xmm_mmm64,
        //     etc).
        uint OpCode {get;}

        //
        // Summary:
        //     true if it's part of a group
        bool IsGroup {get;}

        //
        // Summary:
        //     Group index (0-7) or -1. If it's 0-7, it's stored in the 'reg' field of the modrm
        //     byte.
        int GroupIndex {get;}

        //
        // Summary:
        //     Gets the number of operands
        int OpCount {get;}

        //
        // Summary:
        //     Gets operand #0's opkind
        IceOpCodeOperandKind Op0Kind {get;}

        //
        // Summary:
        //     Gets operand #1's opkind
        IceOpCodeOperandKind Op1Kind {get;}

        //
        // Summary:
        //     Gets operand #2's opkind
        IceOpCodeOperandKind Op2Kind {get;}

        //
        // Summary:
        //     (EVEX) true if an opmask register can be used
        bool CanUseOpMaskRegister {get;}

        //
        // Summary:
        //     Gets operand #3's opkind
        IceOpCodeOperandKind Op3Kind {get;}

        //
        // Summary:
        //     Gets operand #4's opkind
        IceOpCodeOperandKind Op4Kind {get;}

        //
        // Summary:
        //     (EVEX) true if the instruction supports broadcasting (EVEX.b bit) (if it has
        //     a memory operand)
        bool CanBroadcast {get;}

        //
        // Summary:
        //     Gets the encoding
        IceEncodingKind Encoding {get;}

        //
        // Summary:
        //     true if it's an instruction, false if it's eg. Iced.Intel.Code.INVALID, db, dw,
        //     dd, dq
        bool IsInstruction {get;}

        //
        // Summary:
        //     true if it's an instruction available in 16-bit mode
        bool Mode16 {get;}

        //
        // Summary:
        //     true if it's an instruction available in 32-bit mode
        bool Mode32 {get;}

        //
        // Summary:
        //     (EVEX) true if the instruction supports rounding control
        bool CanUseRoundingControl {get;}

        //
        // Summary:
        //     true if an fwait (9B) instruction is added before the instruction
        bool Fwait {get;}

        //
        // Summary:
        //     true if it's an instruction available in 64-bit mode
        bool Mode64 {get;}

        //
        // Summary:
        //     (Legacy encoding) Gets the required address size (16,32,64) or 0 if no address
        //     size prefix (67) is needed
        int AddressSize {get;}
        //
        // Summary:
        //     (VEX/XOP/EVEX) L / L'L value or default value if Iced.Intel.OpCodeInfo.IsLIG
        //     is true
        uint L {get;}

        //
        // Summary:
        //     (VEX/XOP/EVEX) W value or default value if Iced.Intel.OpCodeInfo.IsWIG or Iced.Intel.OpCodeInfo.IsWIG32
        //     is true
        uint W {get;}

        //
        // Summary:
        //     (VEX/XOP/EVEX) true if the L / L'L fields are ignored. EVEX: if reg-only ops
        //     and {er} (EVEX.b is set), L'L is the rounding control and not ignored.
        bool IsLIG {get;}
        //
        // Summary:
        //     (VEX/XOP/EVEX) true if the W field is ignored in 16/32/64-bit modes
        bool IsWIG {get;}
        //
        // Summary:
        //     (VEX/XOP/EVEX) true if the W field is ignored in 16/32-bit modes (but not 64-bit
        //     mode)
        bool IsWIG32 {get;}
        //
        // Summary:
        //     (EVEX) Gets the tuple type
        IceTupleType TupleType {get;}
        //
        // Summary:
        //     (Legacy encoding) Gets the required operand size (16,32,64) or 0 if no operand
        //     size prefix (66) or REX.W prefix is needed
        int OperandSize {get;}
    }
}