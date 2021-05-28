//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SymPair<L,R>
        where L : unmanaged
        where R : unmanaged
    {
        public Sym<L> Left {get;}

        public Sym<R> Right {get;}

        [MethodImpl(Inline)]
        public SymPair(Sym<L> left, Sym<R> right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public static implicit operator SymPair<L,R>((Sym<L> left, Sym<R> right) src)
            => new SymPair<L,R>(src.left, src.right);

        [MethodImpl(Inline)]
        public static implicit operator SymPair<L,R>(Paired<Sym<L>,Sym<R>> src)
            => new SymPair<L,R>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Paired<Sym<L>,Sym<R>>(SymPair<L,R> src)
            => root.paired(src.Left, src.Right);

    }

}
