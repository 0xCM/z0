//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        public static string identifier<S,T>(DataFlow<S,T> flow)
            => RenderLink<S,T>().Format(flow.Source, flow.Target);
    }
}