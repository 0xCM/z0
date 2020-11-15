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

    partial struct Scripts
    {
        public static Index<IScriptVar> members<T>(T set)
            where T : IScriptVars<T>, new()
                => typeof(T).GetProperties(MemberSelector).Select(x => (IScriptVar)x.GetValue(set));
    }
}