//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatement
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Args Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode monic, Args src)
        {
            Mnemonic = monic;
            Args = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic != 0;
        }

        public static AsmStatement Empty
        {
            [MethodImpl(Inline)]
            get => new AsmStatement(0, Args.Empty);
        }
    }

    public readonly struct AsmStatement<A> : IAsmStatement<A>
        where A : unmanaged, IAsmOp
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Args<A> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, A a)
        {
            Mnemonic = mnemonic;
            Args = a;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement(AsmStatement<A> src)
            => new AsmStatement(src.Mnemonic, src.Args);

        public static AsmStatement<A> Empty
        {
            [MethodImpl(Inline)]
            get => new AsmStatement<A>(0, default);
        }
    }

    public readonly struct AsmStatement<A,B> : IAsmStatement<A,B>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Args<A,B> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, A a, B b)
        {
            Mnemonic = mnemonic;
            Args = (a,b);
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, Args<A,B> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement(AsmStatement<A,B> src)
            => new AsmStatement(src.Mnemonic, src.Args);

        public static AsmStatement<A,B> Empty
        {
            [MethodImpl(Inline)]
            get => new AsmStatement<A,B>(0, default, default);
        }
    }

    public readonly struct AsmStatement<A,B,C> : IAsmStatement<A,B,C>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Args<A,B,C> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, A a, B b, C c)
        {
            Mnemonic = mnemonic;
            Args = (a,b,c);
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, Args<A,B,C> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement(AsmStatement<A,B,C> src)
            => new AsmStatement(src.Mnemonic, src.Args);
    }

    public readonly struct AsmStatement<A,B,C,D> : IAsmStatement<A,B,C,D>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
        where D : unmanaged, IAsmOp
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Args<A,B,C,D> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, Args<A,B,C,D> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicCode mnemonic, A a, B b, C c, D d)
        {
            Mnemonic = mnemonic;
            Args = (a,b,c,d);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement(AsmStatement<A,B,C,D> src)
            => new AsmStatement(src.Mnemonic, src.Args);
    }
}