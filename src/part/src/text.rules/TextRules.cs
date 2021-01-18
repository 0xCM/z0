//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static memory;

    public readonly partial struct TextRules
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Inserts a string into the intern pool if it is not already there and, in any case, returns the string's address
        /// </summary>
        /// <param name="src">The text to intern</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress intern(string src)
            => address(string.Intern(src));

        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        static StringBuilder build()
            => EmptyString.Build();

        [ApiHost("text.rules.text")]
        public readonly partial struct Query
        {

        }

        [ApiHost("text.rules.format")]
        public readonly partial struct Format
        {

        }

        [ApiHost("text.rules.transform")]
        public readonly partial struct Transform
        {

        }

        [ApiHost("text.rules.parse")]
        public readonly partial struct Parse
        {

        }
    }
}