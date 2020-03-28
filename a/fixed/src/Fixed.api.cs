//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    [SuppressUnmanagedCodeSecurity, ApiHost("api")]
    public static partial class Fixed
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

        /// <summary>
        /// Creates a fixed-type value
        /// </summary>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static F alloc<F>()
            where F : unmanaged, IFixed
                => default(F);
   
        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<F,T>(ref F src)
            where F : unmanaged, IFixed
            where T : unmanaged
                => ref Unsafe.As<F,T>(ref src);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<F,T>(ref F src, int index)
            where F : unmanaged, IFixed
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<F,T>(ref src), index);

        /// <summary>
        /// Presents a fixed source value as a span of bytes
        /// </summary>
        /// <param name="src">The fixed source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<byte> edit<F>(ref F src)
            where F : unmanaged, IFixed
                => new Span<byte>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<F>());

        /// <summary>
        /// Presents a fixed source value as a span of T-values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> edit<F,T>(ref F src)
            where F : unmanaged, IFixed
            where T : unmanaged
                => new Span<T>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<F>());

        /// <summary>
        /// Presents a fixed source value as a reaodonly span of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<byte> read<F>(in F src)
            where F : unmanaged, IFixed
                => new ReadOnlySpan<byte>(Unsafe.AsPointer(ref Unsafe.AsRef(in src)), Unsafe.SizeOf<F>());

        /// <summary>
        /// Presents a fixed source value as a reaodonly span of T-values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<T> read<F,T>(in F src)
            where F : unmanaged, IFixed
            where T : unmanaged
                => new ReadOnlySpan<T>(Unsafe.AsPointer(ref Unsafe.AsRef(in src)), Unsafe.SizeOf<F>()); 
 
        /// Writes a specified number of source elements to a fixed target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S,F>(in S src, int count, ref F dst, int offset)
            where S : unmanaged
            where F : unmanaged, IFixed
                => store(src, sizeof(S) * count, ref Unsafe.Add(ref Unsafe.As<F,byte>(ref dst), sizeof(S) * offset));

        /// <summary>
        /// Writes source data to a fixed target which, hopefully, is of sufficient size
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <typeparam name="F">The fixed target type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S,F>(in S src, ref F dst)
            where S : unmanaged
            where F : unmanaged, IFixed
        {
            ref var dstBytes = ref Unsafe.As<F,byte>(ref dst);
            ref var srcBytes = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));            
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)sizeof(F));
        }

        [MethodImpl(Inline)]
        public static ref readonly F from<T,F>(in T src)
            where F : unmanaged, IFixed
            where T : struct
                => ref Unsafe.As<T,F>(ref  Unsafe.AsRef(in src));
        
        [MethodImpl(Inline)]
        public static ref readonly F from<T,F>(in Vector128<T> src)
            where F : unmanaged, IFixed
            where T : struct
                => ref from<Vector128<T>,F>(in src);

        [MethodImpl(Inline)]
        public static ref readonly F from<T,F>(in Vector256<T> src)
            where F : unmanaged, IFixed
            where T : struct
                => ref from<Vector256<T>,F>(in src);

        [MethodImpl(Inline)]
        static unsafe void store<S,T>(in S src, int bytecount, ref T dst)
            where S : unmanaged
            where T : unmanaged
        {
            ref var dstBytes = ref Unsafe.As<T,byte>(ref dst);
            ref var srcBytes = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));            
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)bytecount);
        } 
    }
}