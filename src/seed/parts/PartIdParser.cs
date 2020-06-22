//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    
    public readonly struct PartIdParser : IPartIdParser
    {
        public static IPartIdParser Service => default(PartIdParser);
     
        public ParseResult<PartId> Parse(string src)
            => parse<PartId>(src);

        public PartId[] ParseValid(params string[] args)
            => WhereSome(args.Map(arg => parse<PartId>(arg).ValueOrDefault()));

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
        /// Attempts o parse an enum literal, ignoring case, and returns a null value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        static ParseResult<E> parse<E>(string name)
            where E : unmanaged, Enum
        {
            try
            {                
                return ParseResult.Success(name,Enum.Parse<E>(name,true));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<E>(name, e);
            }
        }
    }
}