//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;


    public enum RepeatPrefixCode : byte
    {
        None = 0,

        REPNE = xf2,

        REPNZ = xf2,

        REPE = xf3,

        REPZ = xf3,
    }

    /*
       •
        REPNE/REPNZ prefix is encoded using F2H. Repeat-Not-Zero prefix applies only to string and
        input/output instructions. (F2H is also used as a mandatory prefix for some instructions.)
        •
        REP or REPE/REPZ is encoded using F3H. The repeat prefix applies only to string and input/output
        instructions. F3H is also used as a mandatory prefix for POPCNT, LZCNT and ADOX instructions.

    */
}