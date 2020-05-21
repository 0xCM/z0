//-----------------------------------------------------------------------------
// Derived from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using I = OpCodeDetailId;
    using W = AsmFieldWidths;
    using P = PrefixFieldId;
    using M = ModeFieldId;
    using K = OpKindFieldId;
    public enum OpCodeDetailId : uint
    {
        Sequence,

        [Comment("Gets the opcode. 00000000xxh if it's 1-byte, 0000yyxxh if it's 2-byte (yy != 00, and yy is the first byte and xx the second byte). It doesn't include the table value, see Iced.Intel.OpCodeInfo.Table. Example values: 0xDFC0 (Iced.Intel.Code.Ffreep_sti), 0x01D8 (Iced.Intel.Code.Vmrunw), 0x2A (Iced.Intel.Code.Sub_r8_rm8, Iced.Intel.Code.Cvtpi2ps_xmm_mmm64, etc).")]
        Id,

        [Comment("(EVEX) true if the instruction supports suppress all exceptions")]
        CanSuppressAllExceptions,

        [Comment("(EVEX) true if a non-zero opmask register must be used")]
        RequireNonZeroOpMaskRegister,

        [Comment("(EVEX) true if the instruction supports zeroing masking (if one of the opmask registers k1-k7 is used)")]
        CanUseZeroingMasking,

        [Comment("The opcode table")]
        Table,

        [Comment("true if it's part of a group")]
        IsGroup,

        [Comment("Group index (0-7) or -1. If it's 0-7, it's stored in the 'reg' field of the modrm byte.")]
        GroupIndex,

        [Comment("Gets the number of operands")]
        OpCount,

        [Comment("(EVEX) true if an opmask register can be used")]
        CanUseOpMaskRegister,

        [Comment("(EVEX) true if the instruction supports broadcasting (EVEX.b bit) (if it has a memory operand)")]
        CanBroadcast,


        [Comment("Gets the encoding")]
        Encoding,

        [Comment("true if it's an instruction, false if it's eg. Iced.Intel.Code.INVALID, db, dw, dd, dq")]
        IsInstruction,


        [Comment("(EVEX) true if the instruction supports rounding control")]
        CanUseRoundingControl,

        [Comment("true if an fwait (9B) instruction is added before the instruction")]
        Fwait,


        [Comment("(Legacy encoding) Gets the required address size (16,32,64) or 0 if no address size prefix (67) is needed")]
        AddressSize,

        [Comment("(VEX/XOP/EVEX) L / L'L value or default value if Iced.Intel.OpCodeInfo.IsLIG is true")]
        L,

        [Comment("(VEX/XOP/EVEX) W value or default value if Iced.Intel.OpCodeInfo.IsWIG or Iced.Intel.OpCodeInfo.IsWIG32 is true")]
        W,

        [Comment("(VEX/XOP/EVEX) true if the L / L'L fields are ignored. EVEX: if reg-only ops and {er} (EVEX.b is set), L'L is the rounding control and not ignored.")]
        IsLIG,

        [Comment("(VEX/XOP/EVEX) true if the W field is ignored in 16/32/64-bit modes")]
        IsWIG,

        [Comment("(VEX/XOP/EVEX) true if the W field is ignored in 16/32-bit modes (but not 64-bit mode)")]
        IsWIG32,
        
        [Comment("(EVEX) Gets the tuple type")]
        TupleType,
        
        [Comment("(Legacy encoding) Gets the required operand size (16,32,64) or 0 if no operand size prefix (66) or REX.W prefix is needed")]
        OperandSize,
    }

    public enum OpCodeDetailField : uint
    {
        Sequence = I.Sequence,
        
        Id = I.Id,

        CanSuppressAllExceptions = I.CanSuppressAllExceptions,

        RequireNonZeroOpMaskRegister = I.RequireNonZeroOpMaskRegister,

        CanUseZeroingMasking = I.CanUseZeroingMasking,

        CanUseLockPrefix = P.Lock,

        CanUseXacquirePrefix = P.Xacquire,

        CanUseXreleasePrefix = P.Xrelease,

        CanUseRepPrefix = P.Rep,

        CanUseRepnePrefix = P.Repne,

        CanUseBndPrefix = P.Bnd,

        CanUseHintTakenPrefix = P.HintTaken,

        CanUseNotrackPrefix = P.Notrack,

        Table = I.Table,

        MandatoryPrefix = P.Mandatory,

        IsGroup = I.IsGroup,

        GroupIndex = I.GroupIndex,

        OpCount = I.OpCount,

        Op0Kind = K.Op0Kind,

        Op1Kind = K.Op1Kind,

        Op2Kind = K.Op2Kind,
        Op3Kind = K.Op3Kind,

        Op4Kind = K.Op4Kind,

        CanUseOpMaskRegister = I.CanUseOpMaskRegister,

        CanBroadcast = I.CanBroadcast,

        Encoding = I.Encoding,

        IsInstruction = I.IsInstruction,

        Mode16 = M.Mode16,

        Mode32 = M.Mode32,

        Mode64 = M.Mode64,

        CanUseRoundingControl = I.CanUseRoundingControl,

        Fwait = I.Fwait,
 
        AddressSize = I.AddressSize,

        L = I.L,

        W = I.W,
        
        IsLIG = I.IsLIG,
        IsWIG = I.IsWIG,
        IsWIG32 = I.IsWIG32,
        
        TupleType = I.TupleType,
        
        OperandSize = I.OperandSize,
    }
}