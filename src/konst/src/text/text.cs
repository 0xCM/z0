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

    [ApiHost]
    public static partial class text
    {
        public const string PageBreak = "--------------------------------------------------------------------------------------------------------------";

        const string Assignment = ":=";

        public const string Empty = "";

        const MethodImplOptions Options = NotInline;

        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        public static StringBuilder build()
            => EmptyString.Build();

        [Op]
        public static ITextBuffer buffer()
            => new TextBuffer(new StringBuilder());

        [MethodImpl(Inline)]
        public static int width<E>(E field)
            where E : unmanaged, Enum
        {
            var w = Scalars.scalar<E,uint>(field) >> 16;
            return (int)w;
        }
    }
}