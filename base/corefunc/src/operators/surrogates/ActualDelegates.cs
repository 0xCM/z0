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
    using System.Security;
    using static FixedContainers;

    using static zfunc;

   /// <summary>
    /// Defines the canonical shape of a unary operator
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a);

    /// <summary>
    /// Defines the canonical shape of a binary operator
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b);

    /// <summary>
    /// Defines the canonical shape of a binary operator
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public unsafe delegate T* BinaryPtrOp<T>(T* a, T* b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a tenary operator
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<T>(T a, T b, T c);

    /// <summary>
    /// Defines the canonical shape of a value emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T>();


    [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity] 
    public delegate uint FuncP32u(uint x, uint y);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity] 
    public delegate int FuncP32i(int x, int y);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity] 
    public delegate ulong FuncP64u(ulong x, ulong y);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity] 
    public delegate long FuncP64i(long x, long y);

}