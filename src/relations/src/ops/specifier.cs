//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Relations
    {
        public static string specifier<S,T>(DataFlow<S,T> flow)
        {
            const string Pattern = "{0}:{1} -> {4}:{5}";
            return string.Format(Pattern, flow.Source, typeof(S).Name, flow.Target, typeof(T).Name);
        }

        public static string specifier<K,S,T>(DataFlow<K,S,T> flow)
            where K : unmanaged
        {
            const string Pattern = "{0}:{1} |{2}:{3}> {4}:{5}";
            return string.Format(Pattern, flow.Source, typeof(S).Name, flow.Actor, typeof(K).Name, flow.Target, typeof(T).Name);
        }
    }
}