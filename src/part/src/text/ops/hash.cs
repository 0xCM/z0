//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextBlocks
    {
        [MethodImpl(Inline), Op]
        public static uint hash(TextBlock src)
            => src.IsEmpty ? 0u : (uint)Marvin.hash(src.View.AsUInt8());
    }
}