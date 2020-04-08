//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Core;
    using static Gone2;

    /// <summary>
    /// Defines a natural bitvector over an intrinsic vector
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    /// <typeparam name="N">The bit-width type</typeparam>
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public readonly struct BitVector128<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        internal readonly Vector128<T> data;

        public static N128 MaxWidth => default;
        
        public static Vector128<T> Ones
        {
            [MethodImpl(Inline)]
            get => gvec.vones<T>(MaxWidth);
        }

        public static T Zero => default;

        /// <summary>
        /// Implicitly convers a scalar to a bitvector
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector128<N,T>(Vector128<T> src)
            => new BitVector128<N,T>(src);

        /// <summary>
        /// Implicitly convers a bitvector to its scalar representation
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(BitVector128<N,T> src)
            => src.data;

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator &(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator |(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator ^(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator ~(in BitVector128<N,T> src)
            => BitVector.not(src);
    
        /// <summary>
        /// Computes the two's complement negation of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator -(in BitVector128<N,T> src)
            => BitVector.negate(src);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator <<(in BitVector128<N,T> x, int s)
            => BitVector.sll(x,(byte)s);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator >>(in BitVector128<N,T> x, int s)
            => BitVector.srl(x,(byte)s);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(in BitVector128<N,T> src)
            => src.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(in BitVector128<N,T> src)
            => src.Empty;

        /// <summary>
        /// Determines whether operand content is identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator ==(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => BitVector.same(x,y);

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => !BitVector.same(x,y);

        /// <summary>
        /// Intializes a bitvector with the lo N bits of a scalar source
        /// </summary>
        /// <param name="data">The scalar source value</param>
        [MethodImpl(Inline)]
        public BitVector128(Vector128<T> data)
            => this.data = data;

        /// <summary>
        /// The scalar representation of the vector
        /// </summary>
        public Vector128<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The bitvector's natural width
        /// </summary>
        public int Width
        {
            [MethodImpl(Inline)]
            get => nati<N>();
        }

        /// <summary>
        /// The bitvector's lower 64 bits
        /// </summary>
        public BitVector64 Lo
        {
            [MethodImpl(Inline)]
            get => vcell(v64u(data),0);
        }

        /// <summary>
        /// The bitvector's upper 64 bits
        /// </summary>
        public BitVector64 Hi
        {
            [MethodImpl(Inline)]
            get => vcell(v64u(data),1);
        }

        /// <summary>
        /// Specifies whether all bits are disabled
        /// </summary>
        public bit Empty
        {
            [MethodImpl(Inline)]
            get => !gmath.nonz(data);
        }

        /// <summary>
        /// Specifies whether at least one bit is enabled
        /// </summary>
        public bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => gmath.nonz(data);
        }
 
        [MethodImpl(Inline)]
        public readonly bool Equals(in BitVector128<N,T> y)
            => BitVector.same(this,y);

        public readonly override bool Equals(object obj)
            => obj is BitVector128<N,T> x && Equals(x);
        
        public readonly override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => string.Empty;

        [MethodImpl(Inline)]
        public BitVector128<N,U> As<U>()
            where U : unmanaged
                => data.As<T,U>();
    }
}