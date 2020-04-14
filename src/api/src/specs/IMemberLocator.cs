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

        IEnumerable<ApiMember> Hosted<K>(IApiHost src, K kind, GenericPartition g)
                where K : unmanaged, Enum;

        IEnumerable<ApiMember> Located<K>(IApiHost src, K kind, GenericPartition g)
                where K : unmanaged, Enum;

        IEnumerable<ApiMember> HostedNaturalNumeric(IApiHost src);         

        IEnumerable<ApiMember> LocatedNaturalNumeric(IApiHost src);   

    }
}