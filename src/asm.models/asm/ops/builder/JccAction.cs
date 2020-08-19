//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static JccTest;
    using static Hex8Kind;

    public enum JccAction : byte
    {
        JCC = x70,

        /// <summary>
        /// Jump short if overflow (OF=1)
        /// </summary>
        JO = JCC | O,

        /// <summary>
        /// Jump short if not overflow (OF=0).
        /// </summary>
        JNO = JCC | NO,

        /// <summary>
        /// Jump short if below (CF=1)
        /// </summary>
        JB = JCC | B,

        /// <summary>
        /// Jump short if not below (CF=0)
        /// </summary>
        JNB = JCC | NB,

        JE = JCC | E,

        JNE = JCC | NE,

        JBE = JCC | BE,

        JNBE = JCC | NBE,

        JS = JCC | S,

        JNS = JCC | NS,

        JP = JCC | P,

        JNP = JCC | NP,

        JL = JCC | L,

        JNL = JCC | NL,

        JLE = JCC | LE,

        JLNE = JCC | NLE
    }
}