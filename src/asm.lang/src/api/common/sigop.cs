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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AsmSigOperand sigop<K>(Sym<K> sym)
            where K : unmanaged
                => new AsmSigOperand(sym.Name, sym.Expr);
    }
}