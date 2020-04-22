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
            var locator = Context.MemberLocator();
            var members = locator.Hosted(host, BitLogicKind.And, GenericPartition.NonGeneric);
            iter(members, m => trace(m.OpUri));            
                
        }

        void query_2()
        {
            var host = ApiHost.Create<math>();
            var locator = Context.MemberLocator();
            var located = locator.Located(host);
            iter(located, m => trace(m.OpUri));        
        }

        // public void query_3()
        // {
        //     var host = ApiHost.Create<dvec>();
        //     var query = Context.QueryLocated(host);
        //     var unary = query.UnaryOps();
        //     iter(unary, m => trace(m.OpUri));

        // }

    }
}