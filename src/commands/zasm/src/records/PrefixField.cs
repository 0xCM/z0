//-----------------------------------------------------------------------------
// Derived from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using I = PrefixFieldId;
    using W = AsmFieldWidths;

    public enum PrefixFieldId : uint
    {
        Sequence,

        [Comment("Gets the opcode. 00000000xxh if it's 1-byte, 0000yyxxh if it's 2-byte (yy != 00, and yy is the first byte and xx the second byte). It doesn't include the table value, see Iced.Intel.OpCodeInfo.Table. Example values: 0xDFC0 (Iced.Intel.Code.Ffreep_sti), 0x01D8 (Iced.Intel.Code.Vmrunw), 0x2A (Iced.Intel.Code.Sub_r8_rm8, Iced.Intel.Code.Cvtpi2ps_xmm_mmm64, etc).")]
        Id,

        [Comment("true if the LOCK (F0) prefix can be used")]
        Lock,

        [Comment("true if the XACQUIRE (F2) prefix can be used")]
        Xacquire,

        [Comment("true if the XRELEASE (F3) prefix can be used")]
        Xrelease,

        [Comment("true if the REP / REPE (F3) prefixes can be used")]
        Rep,

        [Comment("true if the REPNE (F2) prefix can be used")]
        Repne,

        [Comment("true if the BND (F2) prefix can be used")]
        Bnd,

        [Comment("true if the HINT-TAKEN (3E) and HINT-NOT-TAKEN (2E) prefixes can be used")]
        HintTaken,

        [Comment("true if the NOTRACK (3E) prefix can be used")]
        Notrack,

        [Comment("Gets the mandatory prefix")]
        Mandatory,
    }

    public enum PrefixField : uint
    {
        Sequence = I.Sequence | W.Sequence << W.Offset,
        Id = I.Id | W.Id << W.Offset,

        Lock = I.Lock | W.BoolLarge << W.Offset,

        Xacquire = I.Xacquire | W.BoolLarge << W.Offset,

        Xrelease = I.Xrelease | W.BoolLarge << W.Offset,
        
        Rep = I.Rep | W.BoolLarge << W.Offset,

        Repne = I.Repne | W.BoolLarge << W.Offset,

        Bnd = I.Bnd | W.BoolLarge << W.Offset,

        HintTaken = I.HintTaken | W.BoolLarge << W.Offset,

        Notrack = I.Notrack | W.BoolLarge << W.Offset,

        Mandatory = I.Mandatory | 12u << W.Offset,    
    }
}