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

    public interface IMemberOpCollector<S> : IAppService
    {
        IEnumerable<DirectOpGroup> CollectDirect(S source);

        IEnumerable<GenericOp> CollectGeneric(S src);
    }

    public interface IMemberOpCollector : IMemberOpCollector<ApiHost>, IMemberOpCollector<Assembly>
    {
        
    } 
}