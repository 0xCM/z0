//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; 
    using static Memories;    

    partial class BitVector
    {
        /// <summary>
        /// Allocates a natural bitvector
        /// </summary>
        /// <param name="n">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> alloc<N,T>(N n = default, T fill = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new BitVector<N, T>(fill);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> xor<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.xor(x.Scalar, y.Scalar);

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
                => gvec.vxor(x.data,y.data);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <typeparam name="T">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> nor<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.nor(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the bitvector z: = ~(x | y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        /// <typeparam name="T">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> nor<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vnor(x.data,y.data);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> not<N,T>(BitVector<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gmath.not(x.Scalar);

        /// <summary>
        /// Computes the bitwise complement z:= ~x of a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> not<N,T>(in BitVector128<N,T> x)
            where N : unmanaged,ITypeNat
            where T : unmanaged
                => gvec.vnot(x.data);

        /// <summary>
        /// Computes the converse nonimplication, z := x & ~y, for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> cnonimpl<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.cnonimpl(x.Scalar, y.Scalar);

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
                => gvec.vcnonimpl(x.data, y.data);
 
        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> impl<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.impl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material implication z := x | ~y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> impl<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vimpl(x.data, y.data);
 
        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> nonimpl<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.nonimpl(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> nonimpl<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vnonimpl(x.data, y.data);

        /// <summary>
        /// Computes z := ~(x & y) for bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> nand<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.nand(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the material nonimplication, equivalent to the bitwise expression a & (~b) for operands a and b
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> nand<N,T>(BitVector128<N,T> x, BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vnand(x.data, y.data);         
 
         /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> xnor<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.xor(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the bitvector z := ~(x ^ y) from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> xnor<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gvec.vxnor(x.data,y.data); 

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> select<N,T>(BitVector<N,T> x, BitVector<N,T> y, BitVector<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> select<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y, in BitVector128<N,T> z)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vselect(x.data, y.data, z.data);   

        /// <summary>
        /// Creates a bitvector with uniformly alternating states where the state of 
        /// the first bit is determined by a parity bit
        /// </summary>
        /// <param name="parity">The state of the first bit</param>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> alt<N,T>(bit parity, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => natural<N,T>(parity ? convert<T>(BitMasks.Even64) : convert<T>(BitMasks.Odd64));

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString bitstring<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitString.scalar<T>(x.Scalar, x.Width);

        /// <summary>
        /// Converts the vector content to a bitring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString bitstring<N,T>(BitVector<N,T> x, byte[] storage)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitString.scalar<T>(x.Scalar, storage, x.Width);

        /// <summary>
        /// Converts the vector to a bistring representation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="N">The bitvector width</typeparam>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString bitstring<N,T>(in BitVector128<N,T> x)
            where T : unmanaged   
            where N : unmanaged, ITypeNat
                => BitString.load(x.data, x.Width);
 
        [MethodImpl(Inline)]
        public static BitVector128<N,T> broadcast<N,T>(N128 w, T a, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Vectors.vbroadcast(w,a);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> disable<N,T>(BitVector<N,T> x, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.disable(x.data,index);

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="index">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> enable<N,T>(BitVector<N,T> x, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.enable(x.data,index);

        /// <summary>
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled<N,T>(BitVector<N,T> x, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.test(x.data, index);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline)]
        public static string format<N,T>(in BitVector128<N,T> x, BitFormatConfig? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => bitstring(x).Format(fmt);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="fmt">Optional formatting style</param>
        [MethodImpl(Inline)]
        public static string format<N,T>(BitVector<N,T> x, BitFormatConfig? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => bitstring(x).Format(fmt);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> gather<N,T>(BitVector<N,T> src, BitVector<N,T> spec)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.gather(src.data, spec.data);

        /// <summary>
        /// Initializes a natural bitvector over a primal type
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector<W,T> init<W,T>(T src, W w = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => new BitVector<W,T>(src);

        /// <summary>
        /// Initializes a full-width 128-bit bitvector
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N128,T> init<T>(Vector128<T> src)
            where T : unmanaged
                => new BitVector128<N128,T>(src);

        /// <summary>
        /// Initializes a 128-bit bitvector with effective width determined by the parametric natural type that must not exeed 128
        /// </summary>
        /// <param name="src">The value used to initialize the bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> init<N,T>(Vector128<T> src, N w = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new BitVector128<N,T>(src);

        /// <summary>
        /// Creates an N-bit vector directly from the source data, bypassing masked initialization
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        internal static BitVector<N,T> inject<N,T>(T src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector<N,T>.Inject(src);

        /// <summary>
        /// Arithmetically increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> inc<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.inc(x.data);

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var result = 0u;
            for(var i=0; i<x.Width; i++)
                result += ((uint)x[i]*(uint)y[i]);                
            return gmath.odd(result);
        }

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> negate<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.negate(x.Scalar);

        /// <summary>
        /// Computes the two's complement bitvector z := ~x + 1 for a bitvector x
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> negate<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vnegate(x.data);

       /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint dist<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint dist<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => pop(xor(x,y));
 
        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int nlz<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                =>  gbits.nlz(x.data) - x.Width;

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz<N,T>(in BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.ntz(x.data);

        /// <summary>
        /// Counts the number of trailing zeros
        /// </summary>
        [MethodImpl(Inline)]
        public static int ntz<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var lo = x.Lo;
            if(lo != 0)
                return gbits.ntz(lo);
            else
                return gbits.ntz(x.Hi) + 64;
        }

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> reverse<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.srl(gbits.rev(src.Scalar), (byte)(bitsize<T>() - src.Width));       

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> replicate<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.data;

        /// <summary>
        /// Creates a copy of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> replicate<N,T>(in BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.data;        
 
        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> seg<N,T>(BitVector<N,T> x, byte first, byte last)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.between(x.data, first, last);

        [MethodImpl(Inline)]
        public static bit same<N,T>(in BitVector<N,T> x, in BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.eq(x.data,y.data);

        [MethodImpl(Inline)]
        public static bit same<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vsame(x.data, y.data);

        /// <summary>
        /// Computes the bitvector z := x ^ y from bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> or<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.or(x.Scalar, y.Scalar);

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
                => gvec.vor(x.data,y.data);
 
        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static int width<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => x.Width - nlz(x);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> zerohi<N,T>(BitVector<N,T> src, int pos)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.zerohi(src.data, pos);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> zerohi<N,T>(in BitVector128<N,T> x)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gvec.vzerohi(x.data);

        public static BitVector<N,T> perm<N,T>(BitVector<N,T> src, in Perm spec)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = src.Replicate();
            var n = src.Width;
            for(var i=0; i<n; i++)
                dst[i] = src[spec[i]];
            return dst;
        }

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.data.AsUInt64().GetElement(0)) + gbits.pop(x.data.AsUInt64().GetElement(1));
    }
}