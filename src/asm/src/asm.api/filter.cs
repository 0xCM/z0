//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using RF = RexFieldIndex;

    partial struct asm
    {
        [Op]
        public static string format(RexPrefixBits src)
            => $"{RF.Code}:{src.Code} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";

        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        public static ApiInstructions filter(ApiInstructions src, IceMnemonic mnemonic)
            => from a in src.All
                let i = a.Instruction
                where i.Mnemonic == mnemonic
                select a;
    }
}