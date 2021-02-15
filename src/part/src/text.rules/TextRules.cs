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

    [ApiHost("text.rules")]
    public readonly partial struct TextRules
    {
        const NumericKind Closure = UnsignedInts;

        const MethodImplOptions Options = NotInline;

        public const StringComparison InvariantCulture = StringComparison.InvariantCulture;

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
        [MethodImpl(Inline)]
        static StringBuilder build()
            => EmptyString.Build();

        [ApiHost("text.rules.query")]
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

        [ApiHost("text.rules.factory")]
        public readonly partial struct Factory
        {

        }

        [ApiComplete("text.rules.data")]
        public readonly partial struct Data
        {

        }
    }
}