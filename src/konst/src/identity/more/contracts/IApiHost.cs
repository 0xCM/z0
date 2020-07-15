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
        Type HostType {get;}        

        string Name 
            => Uri.Name;

        ApiHostUri Uri 
            => ApiHostUri.FromHost(HostType);

        string IIdentified.Identifier 
            => Uri.Format();        

        ApiHostKind HostKind  
            => ApiHostKind.DirectAndGeneric;

        PartId PartId 
            => HostType.Assembly.Id();
    
        IEnumerable<MethodInfo> HostedMethods 
            => HostType.DeclaredMethods(false);
        MethodInfo[] HostedMethodArray
            => HostType.DeclaredMethods(false);
    }
}