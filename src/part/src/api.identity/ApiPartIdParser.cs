//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.IO;

    using static Part;

    public readonly struct ApiPartIdParser : IPartIdParser
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
            => parse<PartId>(src).ValueOrDefault(PartId.None);

        /// <summary>
        /// Parses each supplied identifier; if an identifier does not parse, the return slot
        /// is None-populated
        /// </summary>
        /// <param name="parts">The part identifiers</param>
        [Op]
        public static PartId[] parse(string[] parts)
        {
            var count = parts.Length;
            var dst = sys.alloc<PartId>(count);
            for(var i=0; i<count; i++)
                dst[i] = parse<PartId>(parts[i]).ValueOrDefault();
            return dst;
        }

        public ParseResult<PartId> Parse(string src)
            => parse<PartId>(src);

        /// <summary>
        /// Attempts to parse an enum literal, ignoring case, and returns a null value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        static ParseResult<E> parse<E>(string name)
            where E : unmanaged, Enum
        {
            try
            {
                return root.parsed(name, Enum.Parse<E>(text.remove(name, Chars.Dot),true));
            }
            catch(Exception e)
            {
                return root.unparsed<E>(name, e);
            }
        }
    }
}