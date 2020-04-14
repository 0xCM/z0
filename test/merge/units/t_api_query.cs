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

    public class t_api_query : UnitTest<t_api_query>
    {


        public void query_1()
        {
            var host = ApiHost.Create<math>();
            var locator = Context.MemberLocator();
            var members = locator.Hosted(host, BitLogicKind.And, GenericPartition.NonGeneric);
            iter(members, m => trace(m.OpUri));            
                
        }

    }
}


