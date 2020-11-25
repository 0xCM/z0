//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;

    partial struct WfScripts
    {
        public static Index<ICmdVar> members<T>(T set)
            where T : ICmdVars<T>, new()
                => typeof(T).GetProperties(MemberSelector).Select(x => (ICmdVar)x.GetValue(set));
    }
}