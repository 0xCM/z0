//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IApiHost : IIdentifiedTarget
    {
        string HostName {get;}

        ApiHostKind HostKind {get;}

        PartId Owner {get;}

        ApiHostUri UriPath {get;}
        
        Type HostingType {get;}        

        IEnumerable<MethodInfo> DeclaredMethods {get;}        
    }
}