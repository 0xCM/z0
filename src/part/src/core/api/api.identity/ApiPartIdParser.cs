//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.IO;

    using static Part;
    using static memory;

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
            => ClrEnums.parse(text.remove(src, Chars.Dot), out dst);
    }
}