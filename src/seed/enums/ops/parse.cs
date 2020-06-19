//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Enums
    {
        public static PartId[] ParseParts(params string[] args)
            => args.Map(arg => Enums.Parse<PartId>(arg).ValueOrDefault()).WhereSome();

        /// <summary>
        /// Attempts to parses an enumeration literal, ignoring case, and returns a default value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E Parse<E>(string name, E @default)
            where E : unmanaged, Enum
                => Option.Try(() => Enum.Parse<E>(name, true), error => {}).ValueOrDefault(@default);

        /// <summary>
        /// Attempts o parse an enum literal, ignoring case, and returns a null value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static ParseResult<E> Parse<E>(string name)
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