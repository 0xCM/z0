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

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8VResolverApi<V> : ISImm8ResolverApi<V>
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryResolverApi<W,V> : ISVImm8VResolverApi<V>
        where V : struct
        where W : unmanaged, ITypeWidth
    {
        DynamicDelegate<UnaryOp<V>>  @delegate(byte imm8);  

        TypeWidth ISImmResolverApi.OperandWidth => Widths.type<W>();

        ArityValue ISImmResolverApi.ResolvedArity => ArityValue.Unary;           
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8BinaryResolverApi<W,V> : ISVImm8VResolverApi<V>
        where V : struct
        where W : unmanaged, ITypeWidth
    {
        DynamicDelegate<BinaryOp<V>>  @delegate(byte imm8);  

        TypeWidth ISImmResolverApi.OperandWidth => Widths.type<W>();

        ArityValue ISImmResolverApi.ResolvedArity => ArityValue.Binary;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryResolver128Api<T> : ISVImm8UnaryResolverApi<W128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryResolver256Api<T> : ISVImm8UnaryResolverApi<W256,Vector256<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8BinaryResolver128Api<T> : ISVImm8BinaryResolverApi<W128,Vector128<T>>
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8BinaryResolver256Api<T>  : ISVImm8BinaryResolverApi<W256,Vector256<T>>
        where T : unmanaged
    {
        
    }
}