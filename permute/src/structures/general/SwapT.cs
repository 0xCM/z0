//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
  
    /// <summary>
    /// Defines a transposition, i.e. a specification for the transposition
    /// of two elements, denoted by an ordered pair of space-delimited indices (i j)
    /// </summary>
    public struct Swap<T>
        where T : unmanaged
    {
        /// <summary>
        /// The first index
        /// </summary>
        public T i;
        
        /// <summary>
        /// The second index
        /// </summary>
        public T j;
        
        /// <summary>
        /// The monodial zero
        /// </summary>
        public static Swap<T> Zero => default;

        /// <summary>
        /// Creates a chain of transpositions, that includes the initial transposition
        /// </summary>
        /// <param name="s0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        public static Swap<T>[] Chain(Swap<T> s0, int len)
        {
            var dst = new Swap<T>[len];
            dst[0]  = s0;
            for(var k = 1; k < len; k++)
                dst[k] = ++s0;
            return dst;
        }

        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise
        /// returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static Swap<T> Parse(string src)
        {
            var indices = src.RemoveAny(AsciSym.LParen, AsciSym.RParen).Trim().Split(AsciSym.Space);
            if(indices.Length != 2)
                return Zero;
            
            var result = Root.Try(() => (NumericParser.parse<T>(indices[0]), NumericParser.parse<T>(indices[1])));
            if(result.IsSome())
                return result.Value();
            else
                return Zero;
        }


        [MethodImpl(Inline)]
        public static implicit operator Swap<T>((T i, T j) src)
            => new Swap<T>(src.i, src.j);

        [MethodImpl(Inline)]
        public static implicit operator (T i, T j)(Swap<T> src)
            => (src.i, src.j);

        [MethodImpl(Inline)]
        public static Swap<T> operator ++(in Swap<T> src)
        {
            ref var dst = ref edit(in src);
            dst.i = gmath.inc(dst.i);
            dst.j = gmath.inc(dst.j);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Swap<T> operator --(in Swap<T> src)
        {
            ref var dst = ref edit(in src);
            if(gmath.nonz(src.i))
                dst.i = gmath.dec(dst.i);
            
            if(gmath.nonz(src.j))
                dst.j = gmath.dec(dst.j);
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(Swap<T> lhs, Swap<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Swap<T> lhs, Swap<T> rhs)
            => !(lhs == rhs);                    

        [MethodImpl(Inline)]
        public Swap((T i, T j) src)
        {
            this.i = src.i;
            this.j = src.j;
        }

        [MethodImpl(Inline)]
        public Swap(T i, T j)
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
            => !gmath.nonz(i) && !gmath.nonz(j);
            
        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline)]
        public bool Equals(Swap<T> rhs)
            => (gmath.eq(i, rhs.i) && gmath.eq(j ,rhs.j) || 
               (gmath.eq(i, rhs.j) && gmath.eq(j, rhs.i)));

        [MethodImpl(Inline)]
        public void Deconstruct(out T i, out T j)
        {
            i = this.i;
            j = this.j;
        }

        [MethodImpl(Inline)]
        public (T i, T j) ToTuple()
            => (i,j);

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public Swap<T> Replicate()
            => (i,j);

        public override int GetHashCode()
            => throw new NotSupportedException();
             
        public override bool Equals(object o)
            => o is Swap<T> x ? Equals(x) : false;
    }
}