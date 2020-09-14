//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Adds a an offset of 1 byte to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, W8 w)
            => ref AddByteOffset(ref edit(src), (IntPtr)1);

        /// <summary>
        /// Adds a an offset of 2 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, W16 w)
            => ref AddByteOffset(ref edit(src), (IntPtr)2);

        /// <summary>
        /// Adds a an offset of 3 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, W24 w)
            => ref AddByteOffset(ref edit(src), (IntPtr)3);

        /// <summary>
        /// Adds a an offset of 4 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, W32 w)
            => ref AddByteOffset(ref edit(src), (IntPtr)3);

        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to add</param>
        /// <typeparam name="T">The reference type</typeparam>
        /// <remarks>
        /// u8:  movsxd rax,edx -> add rax,rcx
        /// u16: movsxd rax,edx -> lea rax,[rcx+rax*2]
        /// u32: movsxd rax,edx -> lea rax,[rcx+rax*4]
        /// u64: movsxd rax,edx -> lea rax,[rcx+rax*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, int count)
            => ref Add(ref edit(src), count);

        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to add</param>
        /// <typeparam name="T">The reference type</typeparam>
        /// <remarks>
        /// u8:  movsxd rax,edx -> add rax,rcx
        /// u16: movsxd rax,edx -> lea rax,[rcx+rax*2]
        /// u32: movsxd rax,edx -> lea rax,[rcx+rax*4]
        /// u64: movsxd rax,edx -> lea rax,[rcx+rax*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, uint count)
            => ref Add(ref edit(src), (int)count);

        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to add</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, byte count)
            => ref Add(ref edit(src), (int)count);

        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to add</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, ushort count)
            => ref Add(ref edit(src), (int)count);

        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to add</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, ulong count)
            => ref Add(ref edit(src), (int)count);
    }
}