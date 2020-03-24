//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection;


    [SuppressUnmanagedCodeSecurity]
    public interface IImmResolver : ISFuncApi
    {
        NumericKind ImmKind => NumericKind.None;

        ArityValue ResolvedArity => ArityValue.Nullary;

        FixedWidth OperandWidth => FixedWidth.None;

    }

    public interface IImmResolver<T> : IImmResolver
        where T : unmanaged
    {
        NumericKind IImmResolver.ImmKind => NumericTypes.kind<T>();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IImm8Resolver<T> : IImmResolver<byte>
        where T : struct
    {

    }

    public interface IDynamicImmInjector : IAppService
    {     

    }

    public interface IDynamicImmInjector<D> : IDynamicImmInjector
        where D : Delegate
    {
        DynamicDelegate<D> EmbedImmediate(MethodInfo src, byte imm);    
    }        
}