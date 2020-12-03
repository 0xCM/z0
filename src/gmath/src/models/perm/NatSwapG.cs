//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a transposition in the context of a permutation of natural length
    /// </summary>
    public struct NatSwap<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        /// <summary>
        /// The first index
        /// </summary>
        Mod<N> i;

        /// <summary>
        /// The second index
        /// </summary>
        Mod<N> j;

        /// <summary>
        /// The monodial zero
        /// </summary>
        public static NatSwap<N,T> Zero => default;

        /// <summary>
        /// Creates a chain of transpositions, that includes the initial transposition
        /// </summary>
        /// <param name="t0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        public static NatSwap<N,T>[] Chain(NatSwap<N,T> t0, int len)
        {
            var dst = new NatSwap<N,T>[len];
            dst[0]  = t0;
            for(var k = 1; k < len; k++)
                dst[k] = ++t0;
            return dst;
        }

        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise
        /// returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static NatSwap<N,T> Parse(string src)
            => FromTuple(Swap<T>.Parse(src));

        /// <summary>
        /// Converts a tuple representation to a swap
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public static NatSwap<N,T> FromTuple((T i, T j) src)
            => new NatSwap<N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator NatSwap<N,T>((T i, T j) src)
            => FromTuple(src);

        /// <summary>
        /// Implicitly converts the transpostion to its unsized representation
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public static implicit operator Swap<T>(NatSwap<N,T> src)
            => new Swap<T>(src.ToTuple());

        /// <summary>
        /// Implicitly converts the transpostion to its canonical tuple representation
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public static implicit operator (T i, T j)(NatSwap<N,T> src)
            => src.ToTuple();

        [MethodImpl(Inline)]
        public static implicit operator Swap(NatSwap<N,T> src)
            => (src.i, src.j);

        [MethodImpl(Inline)]
        public static NatSwap<N,T> operator ++(in NatSwap<N,T> src)
        {
            ref var dst = ref edit(src);
            dst.i++;
            dst.j++;
            return dst;
        }

        [MethodImpl(Inline)]
        public static NatSwap<N,T> operator --(in NatSwap<N,T> src)
        {
            ref var dst = ref edit(src);
            if(src.i != 0)
                dst.i--;
            if(src.j != 0)
                --dst.j;
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(NatSwap<N,T> lhs, NatSwap<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(NatSwap<N,T> lhs, NatSwap<N,T> rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public NatSwap((int i, int j) src)
        {
            this.i = src.i;
            this.j = src.j;
        }

        [MethodImpl(Inline)]
        public NatSwap((T i, T j) src)
        {
            this.i = NumericCast.force<T,uint>(src.i);
            this.j = NumericCast.force<T,uint>(src.j);
        }

        [MethodImpl(Inline)]
        NatSwap(Mod<N> i, Mod<N> j)
        {
            this.i = i;
            this.j = j;
        }

        /// <summary>
        /// Renders the tranposition as text in canonical form
        /// </summary>
        public string Format()
            => $"({i} {j})";

        public bool IsEmpy
            => i == Zero.i && j == Zero.j;

        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline)]
        public bool Equals(NatSwap<N,T> rhs)
            => (i == rhs.i && j == rhs.j) || (i == rhs.j && j == rhs.i);

        [MethodImpl(Inline)]
        public void Deconstruct(out T i, out T j)
        {
            i = NumericCast.force<T>(this.i.State);
            j = NumericCast.force<T>(this.j.State);
        }

        /// <summary>
        /// Converts the transpostion to its canonical tuple representation
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public (T i, T j) ToTuple()
            => (NumericCast.force<T>(i.State), NumericCast.force<T>(j.State));

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public NatSwap<N,T> Replicate()
            => new NatSwap<N,T>(i,j);

        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object o)
            => throw new NotSupportedException();
    }

}