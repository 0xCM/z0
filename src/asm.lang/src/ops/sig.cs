//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;

    partial struct asm
    {
        /// <summary>
        /// Attempts to parse a <see cref='AsmSig'/>
        /// </summary>
        /// <param name="src">The input text</param>
        /// <param name="dst">The parsed signature upon success</param>
        [Op]
        public static bool sig(string src, out AsmSig dst)
            => AsmSigParser.parse(src, out dst);
    }
}