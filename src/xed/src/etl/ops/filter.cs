//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct XedWfOps
    {
        public static XedPatternRow[] filter(XedPatternRow[] src, XedExtension match)
            => src.Where(p => p.Extension  == XedConst.Name(match));

        public static XedPatternRow[] filter(XedPatternRow[] src, XedCategory match)
            => src.Where(p => p.Category == XedConst.Name(match));

    }
}