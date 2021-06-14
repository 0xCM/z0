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

    public readonly struct ApiPartIdParser
    {
        public static ApiHostUri hosturi(Type src)
        {
            var typename = src.Name;
            var partName = typename.LeftOfFirst('_');
            var part = single(partName);
            var host = text.ifempty(typename.RightOfFirst('_'), "anonymous");
            return new ApiHostUri(part, host);
        }

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
        public static ReadOnlySpan<PartId> parse2(ReadOnlySpan<string> parts)
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

        public static Outcome parse2(string src, out PartId dst)
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


        /// <summary>
        /// Parses each supplied identifier; if an identifier does not parse, the return slot
        /// is None-populated
        /// </summary>
        /// <param name="parts">The part identifiers</param>
        [Op]
        public static PartId[] parse(string[] parts)
        {
            var count = parts.Length;
            var buffer = sys.alloc<PartId>(count);
            ref var dst = ref first(buffer);
            ref readonly var src = ref first(parts);
            for(var i=0; i<count; i++)
                parse(text.remove(skip(src,i), Chars.Dot), out seek(dst,i));
            return buffer;
        }

        [MethodImpl(Inline)]
        public static Outcome parse(string src, out PartId dst)
            => Enums.parse(text.remove(src, Chars.Dot), out dst);
    }
}