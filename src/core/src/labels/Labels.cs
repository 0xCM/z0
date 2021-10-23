//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Strings;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Labels
    {
        [MethodImpl(Inline), Op]
        public static Label label(string src)
        {
            if(core.empty(src))
                return Label.Empty;
            StringAddress a = src;
            return new Label(a.Address, (byte)src.Length);
        }

        [MethodImpl(Inline), Op]
        public static Label label(ReadOnlySpan<char> src)
            => new Label(address(src), (byte)src.Length);

        [MethodImpl(Inline), Op]
        public static Label label(ReadOnlySpan<char> src, int offset, StringBuffer dst)
        {
            var length = src.Length;
            if(length <= byte.MaxValue && strings.store(src, offset, dst))
                return new Label(dst.Address(offset), (byte)length);
            else
                return Label.Empty;
        }

        [MethodImpl(Inline), Op]
        public static Label label(ReadOnlySpan<char> src, uint offset, StringBuffer dst)
        {
            var length = src.Length;
            if(length <= byte.MaxValue && strings.store(src, offset, dst))
                return new Label(dst.Address(offset), (byte)length);
            else
                return Label.Empty;
        }

        [Op]
        public static StringBuffer alloc(ReadOnlySpan<string> src, out Index<Label> index)
        {
            var count = src.Length;
            var len = strings.length(src);
            var dst = strings.buffer(len);
            index = core.alloc<Label>(count);
            var offset = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                index[i] = dst.StoreLabel(s,offset);
                offset += (uint)s.Length;
            }

            return dst;
        }
    }
}