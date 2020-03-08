//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    public interface IMemberLocator : IAsmService
    {
        IEnumerable<HostedMember> Hosted(Assembly src);

        IEnumerable<HostedMember> Hosted(Type src);

        IEnumerable<HostedMember> Hosted(ApiHost src);
                            
        IEnumerable<LocatedMember> Located(Type host);

        IEnumerable<LocatedMember> Located(ApiHost host);        

        IEnumerable<LocatedMember> Located(Assembly assembly);
    }
}