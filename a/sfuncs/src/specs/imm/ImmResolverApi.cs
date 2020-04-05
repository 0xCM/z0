//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISFImmResolverApi : ISFuncApi
    {
        NumericKind ImmKind => NumericKind.None;

        ArityValue ResolvedArity => ArityValue.Nullary;

        TypeWidth OperandWidth => TypeWidth.None;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISFImmResolverApi<T> : ISFImmResolverApi
        where T : unmanaged
    {
        NumericKind ISFImmResolverApi.ImmKind => NumericKinds.kind<T>();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISFImm8ResolverApi<T> : ISFImmResolverApi<byte>
        where T : struct
    {

    }
}