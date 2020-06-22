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

        IEnumerable<GenericApiMethod> CollectGeneric(S src);
    }

    public interface IApiCollector : IApiCollector<IApiHost>, IApiCollector<Assembly>
    {
        IEnumerable<DirectApiGroup> ImmDirect(IApiHost host, ImmRefinementKind refinment);

        IEnumerable<GenericApiMethod> ImmGeneric(IApiHost host, ImmRefinementKind refinment); 
    } 
}