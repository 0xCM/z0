//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    using M = AsmMnemonicCode;

    partial struct asm
    {
        /// <summary>
        /// PUSH r16 | 50 +rw
        /// </summary>
        /// <param name="r"></param>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r16> push(r16 r)
            => statement(M.PUSH, r);

        /// <summary>
        /// PUSH r32 | 50 +rd
        /// </summary>
        /// <param name="r"></param>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r32> push(r32 r)
            => statement(M.PUSH, r);

        /// <summary>
        /// PUSH r64 | 50 +ro
        /// </summary>
        /// <param name="r"></param>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r64> push(r64 r)
            => statement(M.PUSH, r);
    }
}
