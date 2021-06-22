//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.IO;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct ApiPartIdParser
    {
        [Op]
        public static PartId fromFile(string src)
            => single(Path.GetFileName(src).Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));

        [Op]
        public static PartId single(string src)
        {
            parse(src, out var dst);
            return dst;
        }

        [Op]
        public static ReadOnlySpan<PartId> parse(ReadOnlySpan<string> parts)
        {
            var count = parts.Length;
            if(count == 0)
                return default;

            var symbols = Symbols.index<PartId>();
            var dst = span<PartId>(count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var name = ref skip(parts,i);
                if(symbols.Lookup(name, out var sym))
                    seek(dst, counter++) = sym.Kind;
            }
            return slice(dst, 0, counter);
        }

        [Op]
        public static Outcome parse(string src, out PartId dst)
        {
            var symbols = Symbols.index<PartId>();
            if(symbols.Lookup(src, out var sym))
            {
                dst = sym.Kind;
                return true;
            }
            dst = PartId.None;
            return false;
        }
    }
}