//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial struct HexFormat
    {
        /// <summary>
        /// Renders a sequence of primal numeric T-cells as a sequence of hex-formatted values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The rendered data receiver</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [Op, Closures(Closure)]
        public static void render<T>(ReadOnlySpan<T> src, in HexFormatOptions config, ITextBuffer dst)
            where T : unmanaged
        {
            var count = src.Length;
            ref readonly var cell = ref first(src);
            var last = count - 1;
            for(var i=0u; i<count; i++)
            {
                ref readonly var current = ref skip(cell,i);
                dst.Append(format(current, config.ZeroPad, config.Specifier, config.Uppercase, config.PreSpec));

                if(i != last)
                    dst.Append(config.SegDelimiter);
            }
        }
    }
}