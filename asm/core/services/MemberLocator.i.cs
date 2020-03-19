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

        IEnumerable<ApiStatelessMember> Hosted(ApiHost src);

        IEnumerable<ApiLocatedMember> Located(ApiHost host);        

    }
}