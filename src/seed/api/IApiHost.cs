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

    public interface IApiHost : IIdentification
    {
        Type HostingType {get;}        

        string HostName => UriPath.Name;

        ApiHostUri UriPath => ApiHostUri.FromHost(HostingType);

        string IIdentified.Identifier => UriPath.Format();        

        ApiHostKind HostKind  => ApiHostKind.DirectAndGeneric;

        PartId Owner => HostingType.Assembly.Id();
    
        IEnumerable<MethodInfo> HostedMethods => HostingType.DeclaredMethods(false);

    }

    public interface IApiHost<H> : IApiHost
        where H : IApiHost<H>, new()
    {
        Type IApiHost.HostingType => typeof(H);                
    }
}