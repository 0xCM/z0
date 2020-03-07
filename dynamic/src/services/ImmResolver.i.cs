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

}