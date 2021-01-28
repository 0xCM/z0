//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CreditTypes;

    using D = CreditTypes.DocFieldDelimiter;
    using F = CreditTypes.DocField;

    partial class Credits
    {
        [MethodImpl(Inline), Op]
        public static ContentRef content(DocRef src)
            => (ushort)(((ulong)F.Content & (ulong)src) >> (int)D.Content);

        [MethodImpl(Inline), Op]
        public static DocRef content(ContentRef src)
            => (ulong)src << (byte)D.Content;

        [MethodImpl(Inline), Op]
        public static ContentRef table(ContentNumber n0, ContentNumber n1 = default, ContentNumber n2 = default)
        {
            var l0 = (ushort)n0;
            var l1 = (ushort)((byte)n1 << (byte)ContentLevel.L1);
            var l2 = (ushort)((byte)n2 << (byte)ContentLevel.L2);
            var ct = (ushort)((byte)ContentType.Table << (byte)ContentLevel.Type);
            return (ushort)(l0 | l1 | l2 | ct);
        }

        [MethodImpl(Inline), Op]
        public static ContentType type(ContentRef src)
        {
            var isolated = (ushort)((ushort)(ContentField.Type) & (ushort)src);
            var value = isolated >> (byte)ContentLevel.Type;
            return (ContentType)value;
        }

        public static string format(ContentRef src)
        {
            if(src.IsNonEmpty)
            {
                var l0 = (byte)src.Level0;
                var l1 = (byte)src.Level1;
                var l2 = (byte)src.Level2;
                return text.concat(src.ContentType, ':', l0, '.', l1, '.', l2);
            }
            else
                return string.Empty;
        }

        const char DotSep = (char)SymNotKind.Dot;

        const char UriSep = (char)SymNotKind.FSlash;
    }
}