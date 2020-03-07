//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    public interface IImm8OpProvider
    {     
        DynamicDelegate CreateOp(MethodInfo src, byte imm);        
    }
    
    public interface IImm8OpProvider<D> : IImm8OpProvider
        where D : Delegate
    {
        new DynamicDelegate<D> CreateOp(MethodInfo src, byte imm);
    
        DynamicDelegate IImm8OpProvider.CreateOp(MethodInfo src, byte imm)
            => CreateOp(src,imm);
    }        

}