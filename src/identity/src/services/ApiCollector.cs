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

        public IEnumerable<DirectApiGroup> ImmDirect(ApiHost host, ImmRefinementKind refinment)
            => ApiImmediates.direct(host,refinment);

        public IEnumerable<GenericApiMethod> ImmGeneric(ApiHost host, ImmRefinementKind refinment) 
            => ApiImmediates.generic(host,refinment);

        public IEnumerable<DirectApiGroup> CollectDirect(Assembly src)
            => ApiCollection.direct(src);

        public IEnumerable<GenericApiMethod> CollectGeneric(Assembly src)
            => ApiCollection.generic(src);

        public IEnumerable<DirectApiGroup> CollectDirect(IApiHost src)
            => src is ApiHost h ? CollectDirect(h) : 
               src is ApiDataType t ? CollectDirect(t) : 
               z.seq<DirectApiGroup>();

        public IEnumerable<GenericApiMethod> CollectGeneric(IApiHost src)
            => src is ApiHost h ? CollectGeneric(h) : 
               src is ApiDataType t ? CollectGeneric(t) : 
               z.seq<GenericApiMethod>();

        public IEnumerable<DirectApiGroup> CollectDirect(ApiHost src)        
            => ApiCollection.direct(src);

        public IEnumerable<DirectApiGroup> CollectDirect(ApiDataType src)        
            => ApiCollection.direct(src);

        public IEnumerable<GenericApiMethod> CollectGeneric(ApiHost src)
            => ApiCollection.generic(src);

        public IEnumerable<GenericApiMethod> CollectGeneric(ApiDataType src)
            => ApiCollection.generic(src);
    }
}