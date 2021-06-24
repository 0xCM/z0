//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct SpanRes
    {
        [Op]
        public static string format(ByteSpanSpec src)
        {
            var dst = TextTools.buffer();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static string format(CharSpanSpec src)
        {
            var dst = TextTools.buffer();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static string format<T>(ByteSpanSpec<T> src)
            where T : unmanaged
        {
            var dst = TextTools.buffer();
            render(src, dst);
            return dst.Emit();
        }

        public static string format<T>(SymSpanSpec<T> src)
            where T : unmanaged
        {
            var dst = TextTools.buffer();
            var margin = 0u;
            render(margin,src,dst);
            return dst.Emit();
        }

        public static string format<T>(ReadOnlySpan<Sym<T>> src)
            where T : unmanaged
        {
            var dst = TextTools.buffer();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(src,i);
                if(i != count - 1)
                    dst.Append(string.Format("{0}, ", cell));
                else
                    dst.Append(cell.ToString());
            }
            return dst.Emit();
        }
    }
}