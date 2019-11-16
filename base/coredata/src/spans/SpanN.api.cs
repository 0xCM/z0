//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Diagnostics;    
    
    using static zfunc;
    using static nfunc;
    
    public static class NatSpan
    {        
        [MethodImpl(Inline)]   
        public static Span<N,T> alloc<N,T>(T fill = default(T), N n = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<N,T>(fill);

        [MethodImpl(Inline)]   
        public static Span<N,T> alloc<N,T>(N n, T fill = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<N,T>(fill);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> alloc<M,N,T>(M m, N n, T fill = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<M,N,T>(fill);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> alloc<M,N,T>(T fill = default(T), M m = default, N n = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<M,N,T>(fill);

        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<M,N,T> load<M,N,T>(M m, N n, ref T src)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<M,N,T>(ref src);

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(N n, ReadOnlySpan<T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Span<N,T>.CheckedTransfer(src);

        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(N n, ref T src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<N,T>(ref src);

        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(N n, Span<T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Span<N,T>.CheckedTransfer(src);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> load<M,N,T>(M m, N n, Span<T> src)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Span<M,N,T>.CheckedTransfer(src);

        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(N n, T[] src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Span<N,T>.CheckedTransfer(src);

        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(Span<N,T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<N,T>(src);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> load<M,N,T>(ReadOnlySpan<T> src, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<M,N,T>(src);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<M,N,T>(src);

        [MethodImpl(Inline)]   
        public static Span<N,T> parts<N,T>(N n, params T[] elements) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Span<N,T>.CheckedTransfer(elements);
    }
}