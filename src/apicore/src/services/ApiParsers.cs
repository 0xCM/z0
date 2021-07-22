//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct ApiParsers
    {
        public static Outcome path(string src, out ApiPath dst)
        {
            var result = Outcome.Success;
            dst = ApiPath.Empty;
            var _part = PartId.None;
            var i = text.index(src, Chars.FSlash);
            if(i > 0)
            {
                var components = src.Split(Chars.FSlash);
                result = part(text.left(src,i), out _part);
                if(result)
                    dst = ApiPath.define(_part, text.right(src,i));
            }
            else
            {
                result = part(src, out _part);
                if(result)
                    dst = ApiPath.define(_part);
            }

            return result;
        }

        [Op]
        public static Outcome part(string src, out PartId dst)
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

        [Op]
        public static ReadOnlySpan<PartId> parts(ReadOnlySpan<string> parts)
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
    }
}