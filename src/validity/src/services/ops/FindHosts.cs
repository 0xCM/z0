//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;

    partial class TestApp<A>
    {
        public Type[] FindHosts()
            =>  (from t in typeof(A).Assembly.Types().Realize<IUnitTest>()
                where t.IsConcrete() && t.Untagged<IgnoreAttribute>()
                orderby t.Name
                select t).Array();
    }
}