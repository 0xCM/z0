//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    public interface IApiCollector<S> : IAppService
    {
        IEnumerable<DirectOpGroup> CollectDirect(S source);

        IEnumerable<GenericOp> CollectGeneric(S src);
    }

    public interface IApiCollector : IApiCollector<ApiHost>, IApiCollector<Assembly>
    {
        
    } 
}