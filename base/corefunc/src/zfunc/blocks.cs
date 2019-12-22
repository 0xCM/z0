//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Allocates a specified number of 16-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="blocks">The number of blocks to allocate</param>
    /// <typeparam name="T">The cell data type</typeparam>
    [MethodImpl(Inline)]
    public static Block16<T> blocks<T>(N16 n, int blocks, T t = default)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 32-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="blocks">The number of blocks to allocate</param>
    /// <typeparam name="T">The cell data type</typeparam>
    [MethodImpl(Inline)]
    public static Block32<T> blocks<T>(N32 n, int blocks, T t = default)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 64-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="blocks">The number of blocks to allocate</param>
    /// <typeparam name="T">The cell data type</typeparam>
    [MethodImpl(Inline)]
    public static Block64<T> blocks<T>(N64 n, int blocks, T t = default)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 128-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Block128<T> blocks<T>(N128 n, int blocks, T t = default)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 256-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Block256<T> blocks<T>(N256 n, int blocks, T t = default)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 512-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Block512<T> blocks<T>(N512 n, int blocks, T t = default)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

}