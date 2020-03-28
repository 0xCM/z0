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

    public interface IImmInjector : IService
    {     

    }

    public interface IImmInjector<D> : IImmInjector
        where D : Delegate
    {
        DynamicDelegate<D> EmbedImmediate(MethodInfo src, byte imm);    
    }        
}