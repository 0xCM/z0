//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Relations
    {
        public static string identifier<S,T>(DataFlow<S,T> flow)
            => RenderLink<S,T>().Format(flow.Source, flow.Target);
    }
}