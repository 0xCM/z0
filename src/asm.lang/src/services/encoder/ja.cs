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

    partial class AsmEncoderPrototype
    {
        /// <summary>
        /// (JA rel8) 77 cb
        /// </summary>
        /// <param name="cb"></param>
        [MethodImpl(Inline), Op]
        public static Ja ja(Address8 cb)
            => AsmBytes.code(x77, cb);

        /// <summary>
        /// (JA rel32) 0F 87 cd
        /// </summary>
        /// <param name="cb"></param>
        [MethodImpl(Inline), Op]
        public static Ja ja(Address32 cd)
            => AsmBytes.code(x77, cd);
    }
}