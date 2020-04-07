//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiHost : IIdentifiedTarget
    {
        string HostName {get;}

        ApiHostKind HostKind {get;}

        PartId Owner {get;}

        ApiHostUri Path {get;}
        
        Type HostingType {get;}        
    }
}