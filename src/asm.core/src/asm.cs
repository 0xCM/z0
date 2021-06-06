//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct asm
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static AsmBlockLabel blocklabel(MemoryAddress address)
            => new AsmBlockLabel(string.Format("_{0}", address));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static AsmSigOp sigop<K>(Sym<K> sym)
            where K : unmanaged
                => new AsmSigOp(sym.Name, sym.Expr);

        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(MemoryAddress @base, MemoryAddress ip, byte fxSize, in AsmBranchTarget target)
            => new AsmBranchInfo(@base, ip, target, offset(ip, fxSize, target.Address));
    }
}