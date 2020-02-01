//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Z0.AsmSpecs;

    
    public interface IAsmImmBuilder : IAsmService
    {
        AsmFunction CreateFunction(MethodInfo method, byte imm);

    }

    public interface IAsmImmBuilder<D> : IAsmImmBuilder
        where D : Delegate
    {

    }

}