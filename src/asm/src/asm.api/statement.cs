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
        [MethodImpl(Inline), Op]
        public static Statement statement(string src)
            => new Statement(src.Trim());

        [MethodImpl(Inline)]
        public static AsmStatement<A> statement<A>(AsmMnemonicCode mnemonic, A a)
            where A : unmanaged, IAsmOp
                => new AsmStatement<A>(mnemonic,a);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B> statement<A,B>(AsmMnemonicCode mnemonic, A a, B b)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
                => new AsmStatement<A,B>(mnemonic,a,b);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B> statement<A,B>(AsmMnemonicCode mnemonic, Args<A,B> args)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
                => new AsmStatement<A,B>(mnemonic, args);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B,C> statement<A,B,C>(AsmMnemonicCode mnemonic, A a, B b, C c)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
            where C : unmanaged, IAsmOp
                => new AsmStatement<A,B,C>(mnemonic,a,b,c);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B,C> statement<A,B,C>(AsmMnemonicCode mnemonic, Args<A,B,C> args)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
            where C : unmanaged, IAsmOp
                => new AsmStatement<A,B,C>(mnemonic, args);
    }
}