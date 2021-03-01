//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        /// <summary>
        /// Defines a <see cref='AsmSig'/>
        /// </summary>
        /// <param name="mnemonic"></param>
        /// <param name="operands"></param>
        [MethodImpl(Inline), Op]
        public static AsmSig sig(AsmMnemonicCode mnemonic, params AsmSigOp[] operands)
            => new AsmSig(mnemonic, operands);
    }
}