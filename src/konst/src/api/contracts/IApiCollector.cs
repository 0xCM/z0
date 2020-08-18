//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IApiCollector
    {
        IEnumerable<DirectApiGroup> ImmDirect(ApiHost host, ImmRefinementKind refinment);

        IEnumerable<GenericApiMethod> ImmGeneric(ApiHost host, ImmRefinementKind refinment); 
    } 
}