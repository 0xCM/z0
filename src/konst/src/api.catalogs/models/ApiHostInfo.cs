//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    /// <summary>
    /// Describes an api host
    /// </summary>
    public readonly struct ApiHostInfo : IApiHost
    {
        public ApiHostUri Uri {get;}

        public PartId PartId {get;}

        public Index<MethodInfo> Methods {get;}

        public Type HostType {get;}

        Dictionary<string,MethodInfo> Index {get;}

        [MethodImpl(Inline)]
        public ApiHostInfo(Type host, ApiHostUri uri, PartId part, MethodInfo[] methods)
        {
            HostType = host;
            Uri = uri;
            PartId = part;
            Methods = methods;
            Index = ApiHost.index(methods);
        }

        public bool FindMethod(OpUri uri, out MethodInfo method)
            => Index.TryGetValue(uri.OpId.Identifier, out method);
    }
}