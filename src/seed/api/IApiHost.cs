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

    public interface IApiHost : IIdentifiedTarget
    {
        Type HostingType {get;}        

        string HostName => UriPath.Name;

        ApiHostUri UriPath => ApiHostUri.FromHost(HostingType);

        string IIdentified.Identifier => UriPath.Format();        

        ApiHostKind HostKind  => ApiHostKind.DirectAndGeneric;

        PartId Owner => HostingType.Assembly.Id();
    
        IEnumerable<MethodInfo> HostedMethods => HostingType.DeclaredMethods(false);

        IEnumerable<MethodInfo> HostedKind<K>(K k = default)
            where K : unmanaged, Enum
                => from m in HostedMethods.Tagged(typeof(OpKindAttribute))
                let a = m.Tag<OpKindAttribute>().Require()
                where a.KindId.ToString() == k.ToString()
                    select m;

    }

    public interface IApiHost<H> : IApiHost
        where H : IApiHost<H>, new()
    {
        Type IApiHost.HostingType => typeof(H);                
    }
}