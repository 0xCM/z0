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
    
        MethodInfo[] HostedMethods 
            => HostType.DeclaredMethods();
            
        bool IsEmtpy 
            => HostType == typeof(void);

        bool IsNonEmtpy 
            => HostType != typeof(void);
    }
}