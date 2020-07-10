//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public readonly struct ApiCollector : IApiCollector
    {        
        public static ApiCollector Service 
            => default;

        public IEnumerable<DirectApiGroup> ImmDirect(IApiHost host, ImmRefinementKind refinment)
            => ApiImmediates.direct(host,refinment);

        public IEnumerable<GenericApiMethod> ImmGeneric(IApiHost host, ImmRefinementKind refinment) 
            => ApiImmediates.generic(host,refinment);

        public IEnumerable<DirectApiGroup> CollectDirect(Assembly src)
            => ApiCollection.direct(src);

        public IEnumerable<GenericApiMethod> CollectGeneric(Assembly src)
            => ApiCollection.generic(src);

        public IEnumerable<DirectApiGroup> CollectDirect(IApiHost src)        
            => ApiCollection.direct(src);
                        
        public IEnumerable<GenericApiMethod> CollectGeneric(IApiHost src)
            => ApiCollection.generic(src);
    }
}