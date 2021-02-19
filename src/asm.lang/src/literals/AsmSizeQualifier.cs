//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Pow2x8;

    /// <summary>
    /// Classifies memory size qualifiers
    /// </summary>
    public enum AsmSizeQualifier : byte
    {
        None = 0,

        Byte = P2ᐞ00,

        Word = P2ᐞ01,

        DWord = P2ᐞ02,

        QWord = P2ᐞ03,

        XmmWord = P2ᐞ04,

        YmmWord = P2ᐞ05,

        ZmmWord = P2ᐞ06,
    }
}