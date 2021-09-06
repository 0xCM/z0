//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Blit
    {
        public partial class Render
        {
            public static string format<S,T>(in kvp<S,T> m)
                where S : unmanaged
                where T : unmanaged
            {
                const string Pattern = "{0} -> {1}";
                return string.Format(Pattern, m.Key, m.Val);
            }
        }
    }
}