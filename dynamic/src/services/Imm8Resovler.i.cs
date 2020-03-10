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
    public interface IImm8Resolver : IImmResolver<byte>
    {
            
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8Resolver<T> : IImm8Resolver
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8UnaryResolver<T> : IImm8Resolver
        where T :struct
    {
        DynamicDelegate<UnaryOp<T>>  @delegate(byte imm8);  

        ArityKind IImmResolver.ResolvedArity => ArityKind.Unary;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8BinaryResolver<T> : IImm8Resolver
        where T :struct
    {
        DynamicDelegate<BinaryOp<T>>  @delegate(byte imm8);  

        ArityKind IImmResolver.ResolvedArity => ArityKind.Binary;        
    }
}