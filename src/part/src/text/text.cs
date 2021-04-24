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
        const MethodImplOptions Options = NotInline;

        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// An abbreviation for the ridiculously long "StringComparison.InvariantCultureIgnoreCase"
        /// </summary>
        public const StringComparison NoCase = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>
        /// An abbreviation for the somewhat verbose "StringComparison.InvariantCulture"
        /// </summary>
        public const StringComparison Cased = StringComparison.InvariantCulture;

        const string Assignment = ":=";

        [MethodImpl(Inline)]
        public static int width<E>(E field)
            where E : unmanaged, Enum
        {
            var w = Numeric.scalar<E,uint>(field) >> 16;
            return (int)w;
        }

        [Op]
        public static ITextBuffer buffer()
            => new TextBuffer(new StringBuilder());

        [Op]
        public static ITextBuffer buffer(uint capacity)
            => new TextBuffer(new StringBuilder((int)capacity));
    }
}