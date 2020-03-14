//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
   
    using static Root;
    using static Nats;
    using static FKT;

    public interface IImm8OpProvider : IAppService
    {     

    }

    public interface IImm8OpProvider<D> : IImm8OpProvider
        where D : Delegate
    {
        DynamicDelegate<D> CreateOp(MethodInfo src, byte imm);
    
    }        

}