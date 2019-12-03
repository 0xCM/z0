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
    /// Allocates a specified number of 64-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="blocks">The number of blocks to allocate</param>
    /// <typeparam name="T">The cell data type</typeparam>
    [MethodImpl(Inline)]
    public static Block64<T> blocks<T>(N64 n, int blocks)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 128-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Block128<T> blocks<T>(N128 n, int blocks)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Allocates a specified number of 256-bit blocks
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Block256<T> blocks<T>(N256 n, int blocks)
        where T : unmanaged
            => DataBlocks.alloc<T>(n, blocks);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(Block128<S> lhs, Block128<T> rhs, [CallerMemberName] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged                
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(ConstBlock128<S> lhs, ConstBlock128<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(Block256<S> lhs, Block256<T> rhs, [CallerMemberName] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged                
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(ConstBlock256<S> lhs, ConstBlock256<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);
}