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
    
    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128<T>(in Block128<T> src, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256<T>(in Block256<T> src, in Block256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> BinaryBlockedOp128<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> BinaryBlockedOp256<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128Imm8<T>(in Block128<T> src, byte imm8, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256Imm8<T>(in Block256<T> src, byte imm8, in Block256<T> dst)
        where T : unmanaged;

    /// <summary>
    /// Base interface for block-oriented operations
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedOp : IFunc
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedOp<W> : IBlockedOp
        where W : unmanaged, ITypeNat
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedOp<W,T> : IBlockedOp
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> src, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> src, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> src, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> src, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> src, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedOp512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> src, in Block512<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> a, in Block16<T> b, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> a, in Block32<T> b, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedOp512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> a, in Block512<T> b, in Block512<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        ref readonly Block16<T> Invoke(in Block16<T> a, in Block16<T> b, in Block16<T> c, in Block16<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        ref readonly Block32<T> Invoke(in Block32<T> a, in Block32<T> b, in Block32<T> c, in Block32<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> c, in Block64<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c,in Block256<T> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryBlockedOp512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        ref readonly Block512<T> Invoke(in Block512<T> a, in Block512<T> b, in Block512<T> c, in Block512<T> dst);
    }


    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryBlockedPred512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> src, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred16<T> : IBlockedOp<N16,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block16<T> a, in Block16<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred32<T> : IBlockedOp<N32,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block32<T> a, in Block32<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred64<T> : IBlockedOp<N64,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block64<T> a, in Block64<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred128<T> : IBlockedOp<N128,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block128<T> a, in Block128<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred256<T> : IBlockedOp<N256,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block256<T> a, in Block256<T> b, Span<bit> dst);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryBlockedPred512<T> : IBlockedOp<N512,T>
        where T : unmanaged
    {
        Span<bit> Invoke(in Block512<T> a, in Block512<T> b, Span<bit> dst);
    }

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