//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct ApiHostInfo : IApiHost
    {
        public ApiHostUri Uri {get;}

        public PartId PartId {get;}

        public MethodInfo[] Methods {get;}

        public Type HostType {get;}

        internal ApiHostInfo(Type host, ApiHostUri uri, PartId part, MethodInfo[] methods)
        {
            HostType = host;
            Uri = uri;
            PartId = part;
            Methods = methods;
        }
    }
}