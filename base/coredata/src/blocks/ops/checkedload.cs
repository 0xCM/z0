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
    using static nfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Loads 16-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> checkedload<T>(N16 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 32-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> checkedload<T>(N32 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 64-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> checkedload<T>(N64 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 128-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> checkedload<T>(N128 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w, src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 128-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> checkedload<T>(N256 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w,offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads a 16-bit const block from a readonly span
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> checkedload<T>(N16 w,  ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads a 32-bit const block from a readonly span
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> checkedload<T>(N32 w,  ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads a 64-bit const block from a readonly span
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> checkedload<T>(N64 w,  ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads a 128-bit const block from a readonly span
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> checkedload<T>(N128 w, ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads a 256-bit const block from a readonly span
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock256<T> checkedload<T>(N256 w, ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                badsize(w, src.Length - offset);      

            return load(w, offset == 0 ? src : src.Slice(offset));
        }         

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatBlock<N,T> checkedload<N,T>(Span<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            if(src.Length < nati<N>())
                badsize(nati<N>(), src.Length);      

            return new NatBlock<N, T>(src);
        }


    }

}