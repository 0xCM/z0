//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IImmInjector : IService
    {     
        DynamicDelegate EmbedImmediate(MethodInfo method, byte imm);
    }

    public interface IImmInjector<D> : IImmInjector
        where D : Delegate
    {
        new DynamicDelegate<D> EmbedImmediate(MethodInfo src, byte imm);

        [MethodImpl(Inline)]
        DynamicDelegate IImmInjector.EmbedImmediate(MethodInfo src, byte imm) 
            => EmbedImmediate(src, imm).Untyped; 
    }   
}