//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmInstructions;
    using static Hex8Seq;
    using static AsmHexCodes;

    partial class AsmEncoder
    {
        /// <summary>
        /// (JA rel8) 77 cb
        /// </summary>
        /// <param name="cb"></param>
        [MethodImpl(Inline), Op]
        public static Ja ja(Address8 cb)
            => asmhex(x77, cb);

        /// <summary>
        /// (JA rel32) 0F 87 cd
        /// </summary>
        /// <param name="cb"></param>
        [MethodImpl(Inline), Op]
        public static Ja ja(Address32 cd)
            => asmhex(x77, cd);
    }
}