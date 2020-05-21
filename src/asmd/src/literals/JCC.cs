//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using static JccCode;
    using static HexKind;

    public enum JCC : byte
    {
        Jcc = x70,

        /// <summary>
        /// Jump short if overflow (OF=1)
        /// </summary>
        Jo = Jcc | O,

        /// <summary>
        /// Jump short if not overflow (OF=0).
        /// </summary>
        Jno = Jcc | NO,

        /// <summary>
        /// Jump short if below (CF=1)
        /// </summary>
        Jb = Jcc | B,

        /// <summary>
        /// Jump short if not below (CF=0)
        /// </summary>
        Jnb = Jcc | NB,

        Je = Jcc | E,

        Jne = Jcc | NE,

        Jbe = Jcc | BE,

        Jnbe = Jcc | NBE,

        Js = Jcc | S,

        Jns = Jcc | NS,

        Jp = Jcc | P,

        Jnp = Jcc | NP,

        Jl = Jcc | L,

        Jnl = Jcc | NL,

        Jle = Jcc | LE,

        Jlne = Jcc | NLE
    }
}