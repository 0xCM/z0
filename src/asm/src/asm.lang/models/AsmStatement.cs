//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatement<A> : IAsmStatement<A>
        where A : unmanaged, IAsmOperand
    {
        public AsmMnemonic Mnemonic {get;}

        public Args<A> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, A a)
        {
            Mnemonic = mnemonic;
            Args = a;
        }
    }

    public readonly struct AsmStatement<A,B> : IAsmStatement<A,B>
        where A : unmanaged
        where B : unmanaged
    {
        public AsmMnemonic Mnemonic {get;}

        public Args<A,B> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, A a, B b)
        {
            Mnemonic = mnemonic;
            Args = (a,b);
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, Args<A,B> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }
    }

    public readonly struct AsmStatement<A,B,C> : IAsmStatement<A,B,C>
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
    {
        public AsmMnemonic Mnemonic {get;}

        public Args<A,B,C> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, A a, B b, C c)
        {
            Mnemonic = mnemonic;
            Args = (a,b,c);
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, Args<A,B,C> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }
    }

    public readonly struct AsmStatement<A,B,C,D> : IAsmStatement<A,B,C,D>
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged
    {
        public AsmMnemonic Mnemonic {get;}

        public Args<A,B,C,D> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, Args<A,B,C,D> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonic mnemonic, A a, B b, C c, D d)
        {
            Mnemonic = mnemonic;
            Args = (a,b,c,d);
        }
    }
}