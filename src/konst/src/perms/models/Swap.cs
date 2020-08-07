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
    /// Defines a transposition, i.e. a specification for a two-element position exchange
    /// Typically denoted by an ordered pair of space-delimited indices (i j)
    /// </summary>
    [ApiHost]
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
        /// Effects (i j) -> ((i + 1) (j+ 1))
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ref Swap inc(ref Swap src)
        {
            ++src.i;
            ++src.j;
            return ref src;
        }
    
        /// <summary>
        /// Effects (i j) -> ((i - 1) (j - 1)) where decremented indices are clamped to 0 
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ref Swap dec(ref Swap src)
        {
            if(src.i != 0)
                src.i--;
            if(src.j != 0)
                --src.j;
            return ref src;
        }

        /// <summary>
        /// Creates a sequence of transpositions
        /// </summary>
        /// <param name="s0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        [MethodImpl(Inline), Op]
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

            var result = Option.Try(() => (Int32.Parse(indices[0]), Int32.Parse(indices[1])));
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
        public static Swap operator ++(Swap src)
            => inc(ref src);

        [MethodImpl(Inline)]
        public static Swap operator --(Swap src)
            => dec(ref src);

        [MethodImpl(Inline)]
        public static bool operator ==(Swap lhs, Swap rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Swap lhs, Swap rhs)
            => !(lhs == rhs);                    

        [MethodImpl(Inline)]
        public Swap((int i, int j) src)
        {
            i = src.i;
            j = src.j;
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
        [MethodImpl(Inline), Op]
        public string Format()
            => $"({i} {j})";
        
        public bool IsEmpy
        {
            [MethodImpl(Inline), Op]
            get => i == Empty.i && j == Empty.j;
        }
            
        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline), Op]
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
        [MethodImpl(Inline), Op]
        public Swap Replicate()
            => (i,j);

        [Ignore]
        public override string ToString()
            => Format();

        [Ignore]
        public override int GetHashCode()
            => HashCode.Combine(i,j);
             
        [Ignore]
        public override bool Equals(object o)
            => o is Swap x && Equals(x);

        /// <summary>
        /// The monodial zero
        /// </summary>
        public static Swap Zero => (0,0);

        /// <summary>
        /// The empty element, which is not Zero
        /// </summary>
        public static Swap Empty => (-1,-1);
    }
}