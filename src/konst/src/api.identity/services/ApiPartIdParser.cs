//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    public readonly struct ApiPartIdParser : IPartIdParser
    {
        [Op]
        public static PartId part(FS.FilePath src)
            => single(src.FileName.Name.Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));

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
                return ParseResult.win(name, Enum.Parse<E>(text.remove(name, Chars.Dot),true));
            }
            catch(Exception e)
            {
                return ParseResult.fail<E>(name, e);
            }
        }
    }
}