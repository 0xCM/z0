//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IApiCollector<S>
    {
        IEnumerable<DirectApiGroup> CollectDirect(S source);

        IEnumerable<GenericApiMethod> CollectGeneric(S src);
    }

    public interface IApiCollector : IApiCollector<ApiHost>, IApiCollector<ApiDataType>, IApiCollector<Assembly>
    {
        IEnumerable<DirectApiGroup> ImmDirect(ApiHost host, ImmRefinementKind refinment);

        IEnumerable<GenericApiMethod> ImmGeneric(ApiHost host, ImmRefinementKind refinment); 
    } 
}