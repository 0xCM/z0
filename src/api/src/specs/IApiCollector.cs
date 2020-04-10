//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IApiCollector<S> : IService
    {
        IEnumerable<DirectApiGroup> CollectDirect(S source);

        IEnumerable<GenericApiOp> CollectGeneric(S src);
    }

    public interface IApiCollector : IApiCollector<IApiHost>, IApiCollector<Assembly>
    {
        
    } 

}