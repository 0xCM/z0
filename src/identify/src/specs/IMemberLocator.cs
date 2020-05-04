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
        ApiMembers Hosted(IApiHost src);

        ApiMembers Located(IApiHost host);        

        IEnumerable<ApiMember> Hosted<K>(IApiHost src, K kind, GenericPartition g)
            where K : unmanaged, Enum;

        IEnumerable<ApiMember> Located<K>(IApiHost src, K kind, GenericPartition g)
            where K : unmanaged, Enum;
    }
}