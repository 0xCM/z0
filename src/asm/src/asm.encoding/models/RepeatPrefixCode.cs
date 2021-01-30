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

        /// <summary>
        /// REP or REPE/REPZ is encoded using F3H. The repeat prefix applies only to string and input/output instructions. F3H is also used as a mandatory prefix for POPCNT, LZCNT and ADOX instructions.
        /// </summary>
        REP = xf3,

        REPNE = xf2,

        REPNZ = xf2,

        REPE = xf3,

        REPZ = xf3,
    }
}