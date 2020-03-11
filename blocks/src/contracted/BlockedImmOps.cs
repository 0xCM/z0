//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128Imm8<T>(in Block128<T> src, byte imm8, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256Imm8<T>(in Block256<T> src, byte imm8, in Block256<T> dst)
        where T : unmanaged;


    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp16Imm8<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> src, byte imm8, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp32Imm8<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> src, byte imm8, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp64Imm8<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> src, byte imm8, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp128Imm8<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> src, byte imm8, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp256Imm8<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> src, byte imm8, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp512Imm8<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> src, byte imm8, in Block512<T> dst);
    }
}