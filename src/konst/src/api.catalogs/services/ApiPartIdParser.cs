//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    [ApiHost("api.parsers.part")]
    public readonly struct ApiPartIdParser : IPartIdParser
    {
        [Op]
        public static PartId part(FilePath src)
            => single(src.FileName.Name.Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));

        [Op]
        public static PartId part(FS.FilePath src)
            => part(FilePath.Define(src.Name));

        [Op]
        public static PartId single(string src)
            => parse<PartId>(src).ValueOrDefault(PartId.None);

        /// <summary>
        /// Parses each supplied identifier; if an identifier does not parse, the return slot
        /// is None-populated
        /// </summary>
        /// <param name="parts">The part identifiers</param>
        [Op]
        public static PartId[] parse(params string[] parts)
        {
            var dst = sys.alloc<PartId>(parts.Length);
            for(var i=0; i<parts.Length; i++)
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
                var src = text.remove(name, Chars.Dot);
                return ParseResult.Success(name, Enum.Parse<E>(src,true));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<E>(name, e);
            }
        }
    }
}