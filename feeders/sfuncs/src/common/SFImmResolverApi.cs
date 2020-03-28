//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISImmResolverApi : ISFuncApi
    {
        NumericKind ImmKind => NumericKind.None;

        ArityValue ResolvedArity => ArityValue.Nullary;

        TypeWidth OperandWidth => TypeWidth.None;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISImmResolverApi<T> : ISImmResolverApi
        where T : unmanaged
    {
        NumericKind ISImmResolverApi.ImmKind => NumericTypes.kind<T>();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8ResolverApi<T> : ISImmResolverApi<byte>
        where T : struct
    {

    }
}