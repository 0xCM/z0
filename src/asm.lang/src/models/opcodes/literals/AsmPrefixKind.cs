//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;

    using static Pow2x8;
    using static Hex8Seq;

    [AttributeUsage(AttributeTargets.Enum)]
    public class PrefixCodesAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Field)]
    public class PrefixCodeAttribute : Attribute
    {
        public PrefixCodeAttribute()
        {
            Description = EmptyString;
        }

        public PrefixCodeAttribute(string description)
        {
            Description = description;
        }

        public string Description {get;}
    }

    /// <summary>
    /// Defines prefix classifiers
    /// </summary>
    public enum LegacyPrefixKind : byte
    {
        None = 0,

        Lock = P2ᐞ00,

        Rep = P2ᐞ01,

        Repne = P2ᐞ02,

        Override = P2ᐞ04,

        SegOverride = P2ᐞ04,

        OperandOverride = P2ᐞ05,

        AddressOverride = P2ᐞ06
    }

    public enum LegacyPrefixCode : byte
    {
        None = 0,

        LOCK = LockPrefixCode.LOCK,

        REPE = RepeatPrefixCode.REPE,

        REPNE = RepeatPrefixCode.REPNE,
    }

    public enum LegacyPrefixGroup : byte
    {
        None = 0,

        Group1 = 1,

        Group2 = 2,

        Group3 = 3,

        Group4 = 4,
    }

    /*
        Lock and repeat prefixes:
        •
        LOCK prefix is encoded using F0H.
        •
        REPNE/REPNZ prefix is encoded using F2H. Repeat-Not-Zero prefix applies only to string and
        input/output instructions. (F2H is also used as a mandatory prefix for some instructions.)
        •
        REP or REPE/REPZ is encoded using F3H. The repeat prefix applies only to string and input/output
        instructions. F3H is also used as a mandatory prefix for POPCNT, LZCNT and ADOX instructions.
    */
}