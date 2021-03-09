//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static void decode(in BinaryCode src, Span<char> dst)
        {
            var count = src.Length;
            var view = src.View;

            for(var i=0u; i<count; i++)
                seek(dst,i) = (char)skip(view,i);
        }
    }
}