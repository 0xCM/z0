//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    public static class BitSpan
    {
        /// <summary>
        /// Allocates a bitspan filled with a specified value
        /// </summary>
        /// <param name="n">The natural length of the vector in bits</param>
        /// <param name="src">The fill value</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> init<N,T>(N n, T src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var cells = alloc<N,T>();
            cells.Data.Fill(src);
            return cells;
        }

        /// <summary>
        /// Transfers span content to a bitspan without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The bitspan length representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> transfer<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N, T>(src,true);

        /// <summary>
        /// Allocates a zero-filled bitspan
        /// </summary>
        /// <param name="n">The bitspan width representative</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> alloc<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N,T>(new T[BitSpan<N,T>.CellCount], true);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bitspan width representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> load<N,T>(T[] src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N,T>(src);    

        /// <summary>
        /// Creates a bitspan from a parameter array
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> literals<N,T>(params T[] src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitSpan.load<N,T>(src);

        /// <summary>
        /// Creates a natural cell container over a single cell
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The bitspan width representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> literal<N,T>(T src, N n = default)        
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N, T>(src);

        /// <summary>
        /// Loads a natural bitcell container from a span
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitspan width representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> load<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N,T>(src);    

        /// <summary>
        /// Loads a natural bitspan from a readonly span; allocation required
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> load<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N,T>(src.ToSpan());

        /// <summary>
        /// Allocates a bitspan over a specified number of 256-bit blocks
        /// </summary>
        /// <param name="blocks">The block count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitSpan<T> blockalloc<T>(int blocks)        
            where T : unmanaged
                => new BitSpan<T>(DataBlocks.alloc<T>(n256,blocks));

        /// <summary>
        /// Creates a bitspan over a single cell
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitSpan<T> literal<T>(T src, int? bitsize = null)
            where T : unmanaged
                => new BitSpan<T>(src, bitsize ?? bitsize<T>());

        /// <summary>
        /// Creates a bitspan over an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitSpan<T> literals<T>(params T[] src)
            where T : unmanaged
                => new BitSpan<T>(src, bitsize<T>()*src.Length);

        /// <summary>
        /// Loads a bitspan from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The cell count</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<T> load<T>(Span<T> src, int n)
            where T : unmanaged
                => new BitSpan<T>(src, n);
         
        /// <summary>
        /// Creates a bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        public static BitSpan<T> load<T>(Span<byte> src, int n)
            where T : unmanaged
        {
            var q = Math.DivRem(src.Length, size<T>(), out int r);
            var cellcount = r == 0 ? q : q + 1;
            var capacity = size<T>();
            
            var cells = new T[cellcount];
            for(int i=0, offset = 0; i< cellcount; i++, offset += capacity)
                cells[i] = src.Slice(offset).TakeScalar<T>();
            return new BitSpan<T>(cells, n);
        }

        [MethodImpl(Inline)]
        public static BitSpan<N,T> load<N,T>(Span<byte> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitSpan<N,T>(src.As<byte,T>());    

        /// <summary>
        /// Loads an bitvector of minimal size from a source bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]
        public static BitSpan<T> from<T>(BitString src)
            where T : unmanaged
                => load<T>(src.ToPackedBytes(), src.Length);

        /// <summary>
        /// Computes the Euclidean scalar product between two bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        public static bit modprod<T>(in BitSpan<T> x, in BitSpan<T> y)
            where T : unmanaged
        {
            var result = 0u;
            for(var i=0; i<x.BitCount; i++)
            {
                var a = (uint)x[i];
                var b = (uint)y[i];
                result += a*b;
            }
            return odd(result);
        }

        /// <summary>
        /// Computes the Euclidean scalar product between two natural bitvectors using modular arithmetic
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>This should be considered a reference implementation; the dot operation is considerably faster</remarks>
        [MethodImpl(Inline)]
        public static bit modprod<N,T>(in BitSpan<N,T> x, in BitSpan<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => modprod(x.Unsize(),y.Unsize());

        /// <summary>
        /// Computes the scalar product between this vector and another
        /// </summary>
        /// <param name="rhs">The other vector</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit dot<N,T>(in BitSpan<N,T> x, in BitSpan<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {             
            var result = bit.Off;
            for(var i=0; i<x.Width; i++)
                result ^= x[i] & y[i];
            return result;
        }

        /// <summary>
        /// Computes the scalar product between two bitspans
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit dot<T>(in BitSpan<T> x, in BitSpan<T> y)
            where T : unmanaged
        {
            var result = bit.Off;
            for(var i=0; i<x.BitCount; i++)
                result ^= x[i] & y[i];
            return result;
        } 

        /// <summary>
        /// Computes the number of primal cells required to cover a specified number of bits
        /// </summary>
        /// <param name="bitcount">The number of bits to cover</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static int cellcount<T>(int bitcount)
            where T : unmanaged
        {
            var q = Math.DivRem(bitcount, bitsize<T>(), out int r);            
            return r == 0 ? q : q + 1;
        }

        [MethodImpl(Inline)]
        static int stepsize<T>()
            where T : unmanaged
                => 256 / bitsize<T>();

        [MethodImpl(Inline)]
        public static void and<T>(in BitSpan<T> x, in BitSpan<T> y, ref BitSpan<T> z)        
            where T : unmanaged
                => vblock.and(n256, x.BlockCount, stepsize<T>(), in x.Head, y.Head, ref z.Head);

        [MethodImpl(Inline)]
        public static BitSpan<T> and<T>(in BitSpan<T> x,in BitSpan<T> y)
            where T : unmanaged
        {
            var z = blockalloc<T>(x.BlockCount);
            and(x,y,ref z);
            return z;
        }

   }
}