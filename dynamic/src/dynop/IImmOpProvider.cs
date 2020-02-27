//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    public interface IImmOpProvider
    {     
        DynamicDelegate CreateOp(MethodInfo src, byte imm);        
    }
    
    public interface IImmOpProvider<D> : IImmOpProvider
        where D : Delegate
    {
        new DynamicDelegate<D> CreateOp(MethodInfo src, byte imm);
    
        DynamicDelegate IImmOpProvider.CreateOp(MethodInfo src, byte imm)
            => CreateOp(src,imm);
    }        

}