//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct asm
    {
        public static AsmSig sig<A,B>(Sym<AsmMnemonicCode> monic, Sym<A> a, Sym<B> b)
            where A : unmanaged
            where B : unmanaged
                => new AsmSig(monic, array(sigop(a), sigop(b)));

        public static AsmSig sig<A,B,C>(Sym<AsmMnemonicCode> monic, Sym<A> a, Sym<B> b, Sym<C> c)
            where A : unmanaged
            where B : unmanaged
            where C : unmanaged
                => new AsmSig(monic, array(sigop(a), sigop(b), sigop(c)));

        [MethodImpl(Inline), Op]
        public static AsmSigExpr sig(AsmMnemonic mnemonic, string formatted)
            => new AsmSigExpr(mnemonic,formatted);
    }
}