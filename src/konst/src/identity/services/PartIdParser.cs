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

    public readonly struct PartIdParser : IPartIdParser
    {
        public static IPartIdParser Service => default(PartIdParser);

        public static PartId part(FilePath src)
            => PartIdParser.single(src.FileName.Name.Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));

        public ParseResult<PartId> Parse(string src)
            => parse<PartId>(src);

        public static PartId single(string src)
            => parse<PartId>(src).ValueOrDefault(PartId.None);

        /// <summary>
        /// Parses each supplied identifier; if an identifier does not parse, the return slot
        /// is None-populated
        /// </summary>
        /// <param name="parts">The part identifiers</param>
        public static PartId[] parse(params string[] parts)
        {
            var dst = sys.alloc<PartId>(parts.Length);
            for(var i=0; i<parts.Length; i++)
                dst[i] = parse<PartId>(parts[i]).ValueOrDefault();
            return dst;
        }

        public PartId[] ParseValid(params string[] args)
            => WhereSome(args.Map(arg => parse<PartId>(arg).ValueOrDefault()));

        public static PartId[] parse(string[] args, PartId[] fallback)
        {
            var result = WhereSome(args.Map(arg => parse<PartId>(arg).ValueOrDefault()));
            return result.Length == 0 ? fallback : result;
        }

        [MethodImpl(Inline)]
        static E zero<E>()
            where E : unmanaged, Enum
                => default(E);

        [MethodImpl(Inline)]
        static bool IsSome<E>(E src)
            where E : unmanaged, Enum
                => !zero<E>().Equals(src);

        /// <summary>
        /// Filters zero-valued elements from the source array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="E">The enumeration type</typeparam>
        static E[] WhereSome<E>(E[] src)
            where E : unmanaged, Enum
                => src.Where(x => IsSome(x)).ToArray();

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