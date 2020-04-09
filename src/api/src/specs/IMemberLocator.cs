//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    public interface IMemberLocator : IService
    {
        IEnumerable<ApiMember> Hosted(IApiHost src);

        IEnumerable<ApiMember> Located(IApiHost host);        
    }
}