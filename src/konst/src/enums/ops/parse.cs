//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Enums
    {
        /// <summary>
        /// Attempts to parses an enumeration literal, ignoring case, and returns a default value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E parse<E>(string name, E @default)
            where E : unmanaged, Enum
        {
            if(Enum.TryParse(name,true,out E result))
                return result;
            else
                return @default;
        }

        /// <summary>
        /// Attempts o parse an enum literal, ignoring case, and returns a null value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<E> parse<E>(string name)
            where E : unmanaged, Enum
        {
            if(Enum.TryParse(name, true, out E result))
                return parsed(name, result);
            else
                return unparsed<E>(name);
        }
    }
}