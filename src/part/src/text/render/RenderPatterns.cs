//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct RenderPatterns
    {
        [MethodImpl(Inline), Op]
        public static RenderCapture capture(IRenderPattern src, params object[] args)
            => new RenderCapture(src, args);
    }
}