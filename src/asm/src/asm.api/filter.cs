//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct asm
    {
        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        public static ApiInstructionBlock filter(ApiInstructionBlock src, IceMnemonic mnemonic)
            => from a in src.All
                let i = a.Instruction
                where i.Mnemonic == mnemonic
                select a;
    }
}