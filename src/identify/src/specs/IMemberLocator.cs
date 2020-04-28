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

        IEnumerable<Member> Hosted<K>(IApiHost src, K kind, GenericPartition g)
                where K : unmanaged, Enum;

        IEnumerable<Member> Located<K>(IApiHost src, K kind, GenericPartition g)
                where K : unmanaged, Enum;

        IEnumerable<Member> HostedNaturalNumeric(IApiHost src);         

        IEnumerable<Member> LocatedNaturalNumeric(IApiHost src);   
    }
}