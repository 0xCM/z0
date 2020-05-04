//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static Memories;

    public class t_api_query : t_identity<t_api_query>
    {
        void query_1()
        {
            var host = ApiHost.Create<math>();
            var members = Identities.Services.ApiLocator.Hosted(host, BitLogicKind.And, GenericPartition.NonGeneric);
            iter(members, m => Trace(m.OpUri));            
                
        }

        void query_2()
        {
            var host = ApiHost.Create<math>();
            var located = Identities.Services.ApiLocator.Located(host);
            iter(located, m => Trace(m.OpUri));        
        }
    }
}