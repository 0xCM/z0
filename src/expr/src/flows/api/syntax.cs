//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    partial struct flows
    {
        public static string syntax<S,T>(Flow<S,T> flow)
            where S : IChannel
            where T : IChannel
        {
            const string Pattern = "{0}:{1} -> {4}:{5}";
            return string.Format(Pattern, flow.Source, typeof(S).Name, flow.Target, typeof(T).Name);
        }

        public static string syntax<K,S,T>(Flow<K,S,T> flow)
            where K : unmanaged
            where S : IChannel
            where T : IChannel
        {
            const string Pattern = "{0}:{1} |{2}:{3}> {4}:{5}";
            return string.Format(Pattern, flow.Source, typeof(S).Name, flow.Kind, typeof(K).Name, flow.Target, typeof(T).Name);
        }
    }
}