//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatement : IEquatable<AsmStatement>
    {
        public asci64 Content {get;}

        [MethodImpl(Inline)]
        public AsmStatement(asci64 content)
            => Content = content;

        [MethodImpl(Inline)]
        public bool Equals(AsmStatement src)
            => Content.Equals(src.Content);

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is AsmStatement x && Equals(x);

        public int CompareTo(AsmStatement src)
            => Content.CompareTo(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement(asci64 src)
            => new AsmStatement(src);
    }

    public readonly struct AsmStatement<A> : IAsmStatement<A>
        where A : unmanaged, IAsmOperand
    {
        public AsmMnemonicExpr Mnemonic {get;}

        public Args<A> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, A a)
        {
            Mnemonic = mnemonic;
            Args = a;
        }
    }

    public readonly struct AsmStatement<A,B> : IAsmStatement<A,B>
        where A : unmanaged
        where B : unmanaged
    {
        public AsmMnemonicExpr Mnemonic {get;}

        public Args<A,B> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, A a, B b)
        {
            Mnemonic = mnemonic;
            Args = (a,b);
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, Args<A,B> args)
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
        public AsmMnemonicExpr Mnemonic {get;}

        public Args<A,B,C> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, A a, B b, C c)
        {
            Mnemonic = mnemonic;
            Args = (a,b,c);
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, Args<A,B,C> args)
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
        public AsmMnemonicExpr Mnemonic {get;}

        public Args<A,B,C,D> Args {get;}

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, Args<A,B,C,D> args)
        {
            Mnemonic = mnemonic;
            Args = args;
        }

        [MethodImpl(Inline)]
        public AsmStatement(AsmMnemonicExpr mnemonic, A a, B b, C c, D d)
        {
            Mnemonic = mnemonic;
            Args = (a,b,c,d);
        }
    }
}