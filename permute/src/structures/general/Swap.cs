//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    /// <summary>
    /// Defines a transposition, i.e. a specification for a two-element position exchange
    /// Typically denoted by an ordered pair of space-delimited indices (i j)
    /// </summary>
    public struct Swap
    {
        /// <summary>
        /// The first index
        /// </summary>
        public int i;
        
        /// <summary>
        /// The second index
        /// </summary>
        public int j;

        /// <summary>
        /// The monodial zero
        /// </summary>
        public static Swap Zero => (0,0);

        /// <summary>
        /// The empty element, which is not Zero
        /// </summary>
        public static Swap Empty => (-1,-1);
        
        /// <summary>
        /// Effects (i j) -> ((i + 1) (j+ 1))
        /// </summary>
        [MethodImpl(Inline)]
        public static ref Swap Inc(ref Swap src)
        {
            ++src;
            return ref src;
        }

        /// <summary>
        /// Effects (i j) -> ((i - 1) (j - 1)) where decremented indices are clamped to 0 
        /// </summary>
        [MethodImpl(Inline)]
        public static ref Swap Dec(ref Swap src)
        {
            --src;
            return ref src;
        }

        /// <summary>
        /// Creates a sequence of transpositions
        /// </summary>
        /// <param name="s0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        public static Swap[] Chain(Swap s0, int len)
        {
            var dst = new Swap[len];
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
        public static Swap Parse(string src)
        {
            var indices = src.RemoveAny(Chars.LParen, Chars.RParen).Trim().Split(Chars.Space);
            if(indices.Length != 2)
                return Empty;

            var result = Try(() => (Int32.Parse(indices[0]), Int32.Parse(indices[1])));
            if(result.IsSome())
                return result.Value();
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator Swap((int i, int j) src)
            => new Swap(src);

        [MethodImpl(Inline)]
        public static implicit operator (int i, int j)(Swap src)
            => (src.i, src.j);

        [MethodImpl(Inline)]
        public static Swap operator ++(in Swap src)
        {
            ref var dst = ref edit(in src);
            dst.i++;
            dst.j++;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Swap operator --(in Swap src)
        {
            ref var dst = ref edit(in src);
            if(src.i != 0)
                dst.i--;
            if(src.j != 0)
                --dst.j;
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(Swap lhs, Swap rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Swap lhs, Swap rhs)
            => !(lhs == rhs);                    

        [MethodImpl(Inline)]
        public Swap((int i, int j) src)
        {
            this.i = src.i;
            this.j = src.j;
        }

        [MethodImpl(Inline)]
        public Swap(int i, int j)
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
            => i == Empty.i && j == Empty.j;
            
        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline)]
        public bool Equals(Swap rhs)
            => (i == rhs.i && j == rhs.j) || (i == rhs.j && j == rhs.i);

        [MethodImpl(Inline)]
        public void Deconstruct(out int i, out int j)
        {
            i = this.i;
            j = this.j;
        }

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public Swap Replicate()
            => (i,j);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(i,j);
             
        public override bool Equals(object o)
            => o is Swap x && Equals(x);
    }
}