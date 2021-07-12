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

    using static Root;
    using static cpu;
    using static BitVector128;

    public readonly struct BitVector128
    {
        /// <summary>
        /// Defines a 128-bit bitvector of natural width
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="a">The scalar source data</param>
        /// <typeparam name="N">The width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> define<N,T>(N n, Vector128<T> x)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitVector128<N,T>(x);

        /// <summary>
        /// Computes the sum of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> add<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var sum = cpu.vadd(gcpu.v64u(x.State), gcpu.v64u(y.State));
            bit carry = x.Lo > cpu.vcell(sum,0);
            return  core.generic<T>(cpu.vadd(sum, cpu.vbroadcast(w128, (ulong)carry)));
        }

        /// <summary>
        /// Computes the bitvector z := x & y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> and<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vand(x.State, y.State);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> or<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vor(x.State,y.State);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> xor<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vxor(x.State,y.State);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> cnonimpl<N,T>(BitVector128<N,T> x, BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gcpu.vcnonimpl(x.State, y.State);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.State.AsUInt64().GetElement(0)) + gbits.pop(x.State.AsUInt64().GetElement(1));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint hamming<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));

        /// <summary>
        /// Computes the parity of the source vector
        /// </summary>
        [MethodImpl(Inline)]
        public static bit parity<N,T>(in BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => math.odd(pop(src));


        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => parity(and(x,y));

       /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> replicate<N,T>(in BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.State;
    }

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
        internal readonly Vector128<T> Data;

        /// <summary>
        /// Initializes a bitvector with the lo N bits of a scalar source
        /// </summary>
        /// <param name="data">The scalar source value</param>
        [MethodImpl(Inline)]
        public BitVector128(Vector128<T> data)
            => Data = data;

        /// <summary>
        /// The scalar representation of the vector
        /// </summary>
        public Vector128<T> State
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// The bitvector's natural width
        /// </summary>
        public int Width
        {
            [MethodImpl(Inline)]
            get => (int)TypeNats.value<N>();
        }

        /// <summary>
        /// The bitvector's lower 64 bits
        /// </summary>
        public BitVector64 Lo
        {
            [MethodImpl(Inline)]
            get => vcell(v64u(Data),0);
        }

        /// <summary>
        /// The bitvector's upper 64 bits
        /// </summary>
        public BitVector64 Hi
        {
            [MethodImpl(Inline)]
            get => vcell(v64u(Data),1);
        }

        /// <summary>
        /// Specifies whether all bits are disabled
        /// </summary>
        public bit Empty
        {
            [MethodImpl(Inline)]
            get => !gmath.nonz(Data);
        }

        /// <summary>
        /// Specifies whether at least one bit is enabled
        /// </summary>
        public bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => gmath.nonz(Data);
        }

        [MethodImpl(Inline)]
        public readonly bool Equals(in BitVector128<N,T> y)
            => BitVector.eq(this,y);

        public readonly override bool Equals(object obj)
            => obj is BitVector128<N,T> x && Equals(x);

        public readonly override int GetHashCode()
            => Data.GetHashCode();

        public override string ToString()
            => string.Empty;

        [MethodImpl(Inline)]
        public BitVector128<N,U> As<U>()
            where U : unmanaged
                => Data.As<T,U>();

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
            => src.Data;

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator &(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => and(x,y);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator |(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => or(x,y);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> operator ^(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => xor(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => dot(x,y);

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
            => BitVector.eq(x,y);

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(in BitVector128<N,T> x, in BitVector128<N,T> y)
            => !BitVector.eq(x,y);

        public static N128 MaxWidth => default;

        public static Vector128<T> Ones
        {
            [MethodImpl(Inline)]
            get => gcpu.vones<T>(MaxWidth);
        }

        public static T Zero => default;
    }
}