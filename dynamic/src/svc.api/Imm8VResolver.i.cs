//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Nats;

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8VResolver<V> : IImm8Resolver<V>
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8VUnaryResolver<W,V> : IImm8VResolver<V>
        where V : struct
        where W : unmanaged, ITypeNat
    {
        DynamicDelegate<UnaryOp<V>>  @delegate(byte imm8);  

        FixedWidth IImmResolver.OperandWidth => (FixedWidth)nateval<W>();

        ArityValue IImmResolver.ResolvedArity => ArityValue.Unary;           
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8VBinaryResolver<W,V> : IImm8VResolver<V>
        where V : struct
        where W : unmanaged, ITypeNat
    {
        DynamicDelegate<BinaryOp<V>>  @delegate(byte imm8);  

        FixedWidth IImmResolver.OperandWidth => (FixedWidth)nateval<W>();

        ArityValue IImmResolver.ResolvedArity => ArityValue.Binary;           

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8V128UnaryResolver<T> : IImm8VUnaryResolver<N128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8V256UnaryResolver<T> : IImm8VUnaryResolver<N256,Vector256<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8V128BinaryResolver<T> : IImm8VBinaryResolver<N128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8V256BinaryResolver<T>  : IImm8VBinaryResolver<N256,Vector256<T>>
        where T : unmanaged
    {
        
    }
}