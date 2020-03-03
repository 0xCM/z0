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

    using static Root;
    using static Nats;

    [SuppressUnmanagedCodeSecurity]
    public interface IVImm8Resolver<V> : IImm8Resolver<V>
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver<W,V> : IVImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeNat
    {
        DynamicDelegate<UnaryOp<V>>  @delegate(byte imm8);  

        FixedWidth IImmResolver.OperandWidth => (FixedWidth)nateval<W>();

        OpArityKind IImmResolver.ResolvedArity => OpArityKind.Unary;           
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver<W,V> : IVImm8Resolver<V>
        where V : struct
        where W : unmanaged, ITypeNat
    {
        DynamicDelegate<BinaryOp<V>>  @delegate(byte imm8);  

        FixedWidth IImmResolver.OperandWidth => (FixedWidth)nateval<W>();

        OpArityKind IImmResolver.ResolvedArity => OpArityKind.Binary;           

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver128<T> : IVUnaryImm8Resolver<N128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryImm8Resolver256<T> : IVUnaryImm8Resolver<N256,Vector256<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver128<T> : IVBinaryImm8Resolver<N128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryImm8Resolver256<T>  : IVBinaryImm8Resolver<N256,Vector256<T>>
        where T : unmanaged
    {
        
    }
}