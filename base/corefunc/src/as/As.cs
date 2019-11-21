//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    public static partial class As
    {
        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span<T> cast<S,T>(in Span<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<T> cast<S,T>(in ReadOnlySpan<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Block256<T> cast<S,T>(in Block256<S> src)                
            where S : unmanaged
            where T : unmanaged
                => Block256<T>.LoadAligned(MemoryMarshal.Cast<S,T>(src));

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock256<T> cast<S,T>(in ConstBlock256<S> src)                
            where S : unmanaged
            where T : unmanaged
                => (ConstBlock256<T>)MemoryMarshal.Cast<S,T>(src);
                
        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Block128<T> cast<S,T>(in Block128<S> src)                
            where S : unmanaged
            where T : unmanaged
                =>  Block128.load(MemoryMarshal.Cast<S,T>(src));

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal  static ConstBlock128<T> cast<S,T>(in ConstBlock128<S> src)                
            where S : unmanaged
            where T : unmanaged
                => (ConstBlock128<T>)MemoryMarshal.Cast<S,T>(src);


        
        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, int offset)
            => ref Unsafe.Add(ref src, offset);

        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);

        [MethodImpl(Inline)]
        public static ref T inAdd<T>(in T src, IntPtr offset)
            => ref Unsafe.Add(ref mutable(in src), offset);
    }
}