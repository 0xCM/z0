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
    public interface IImmResolver : IFunc
    {
        NumericKind ImmKind => NumericKind.None;

        OpArityKind ResolvedArity => OpArityKind.Nullary;

        FixedWidth OperandWidth => FixedWidth.None;

    }

    public interface IImmResolver<T> : IImmResolver
        where T : unmanaged
    {
        NumericKind IImmResolver.ImmKind => Numeric.kind<T>();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8Resolver : IImmResolver<byte>
    {
            
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryImm8Resolver<T> : IImm8Resolver
        where T :struct
    {
        DynamicDelegate<UnaryOp<T>>  @delegate(byte imm8);  

        OpArityKind IImmResolver.ResolvedArity => OpArityKind.Unary;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryImm8Resolver<T> : IImm8Resolver
        where T :struct
    {
        DynamicDelegate<BinaryOp<T>>  @delegate(byte imm8);  

        OpArityKind IImmResolver.ResolvedArity => OpArityKind.Binary;        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8Resolver<T> : IImm8Resolver
    {

    }
}