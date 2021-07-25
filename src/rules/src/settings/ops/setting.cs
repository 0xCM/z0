//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    partial struct Settings
    {
        [MethodImpl(Inline), Op]
        public static Setting setting(string name, dynamic value)
            => new Setting(name,value);

        [Op]
        public static ReadOnlySpan<Setting> parse(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            var buffer = span<Setting>(count);
            ref var dst = ref first(buffer);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = SQ.index(content, Chars.Colon);
                if(j > 0)
                {
                    var name = SQ.left(content, j).Format().Trim();
                    var value = SQ.right(content, j).Format().Trim();
                    seek(dst,counter++) = Settings.setting(name,value);
                }
            }
            return slice(buffer,0,counter);
        }
    }
}