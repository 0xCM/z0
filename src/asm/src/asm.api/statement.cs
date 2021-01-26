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
        [MethodImpl(Inline), Op]
        public static AsmStatement statement(string src)
            => new AsmStatement(src.Trim());

        [MethodImpl(Inline)]
        public static AsmStatement<A> statement<A>(AsmMnemonic mnemonic, A a)
            where A : unmanaged, IAsmOperand
                => new AsmStatement<A>(mnemonic,a);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B> statement<A,B>(AsmMnemonic mnemonic, A a, B b)
            where A : unmanaged, IAsmOperand
            where B : unmanaged, IAsmOperand
                => new AsmStatement<A,B>(mnemonic,a,b);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B> statement<A,B>(AsmMnemonic mnemonic, Args<A,B> args)
            where A : unmanaged, IAsmOperand
            where B : unmanaged, IAsmOperand
                => new AsmStatement<A,B>(mnemonic, args);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B,C> statement<A,B,C>(AsmMnemonic mnemonic, A a, B b, C c)
            where A : unmanaged, IAsmOperand
            where B : unmanaged, IAsmOperand
            where C : unmanaged, IAsmOperand
                => new AsmStatement<A,B,C>(mnemonic,a,b,c);

        [MethodImpl(Inline)]
        public static AsmStatement<A,B,C> statement<A,B,C>(AsmMnemonic mnemonic, Args<A,B,C> args)
            where A : unmanaged, IAsmOperand
            where B : unmanaged, IAsmOperand
            where C : unmanaged, IAsmOperand
                => new AsmStatement<A,B,C>(mnemonic, args);
    }
}