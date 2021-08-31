//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Blit
    {
        partial struct Operate
        {
            public static string format<S,T>(in map<S,T> m)
                where S : unmanaged
                where T : unmanaged
            {
                const string Pattern = "{0} -> {1}";
                return string.Format(Pattern, m.Source, m.Target);
            }
        }
    }
}