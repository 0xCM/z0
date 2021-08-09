//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct RP
    {
        [MethodImpl(Inline), Op]
        public static string pad(int pad)
            => "{0," + pad.ToString() + "}";

        [MethodImpl(Inline), Op]
        public static string pad(uint slot, int pad)
            => "{" + slot.ToString() + "," + pad.ToString() + "}";

        /// <summary>
        /// The end-of-line escape sequence
        /// </summary>
        public const string Eol = Chars.Eol;

        public const char PropertySep = Chars.Colon;

        public const sbyte PropertyPad = -16;

        /// <summary>
        /// Defines the literal '{0} -> {1}'
        /// </summary>
        [RenderPattern("{0} -> {1}")]
        public const string ArrowAxB = "{0} -> {1}";

        [MethodImpl(Inline)]
        static object denullify(object src)
            => src ?? "<null>";

    }
}