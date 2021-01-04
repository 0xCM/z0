//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CreditTypes;

    using D = CreditTypes.DocFieldDelimiter;
    using F = CreditTypes.DocField;
    using Entity = ContentRef;

    partial class Credits
    {
        /// <summary>
        /// Defines a reference to a topic in a chapter
        /// </summary>
        /// <param name="v">The document vendor</param>
        /// <param name="vol">The referenced volume</param>
        /// <param name="c">The referenced chapter</param>
        /// <param name="s">The referenced section</param>
        /// <param name="t">The referenced topic</param>
        [MethodImpl(Inline), Op]
        public static DocRef define(Vendor v, Volume vol, Chapter c, Section s, Topic t, ContentRef cr = default)
        {
            var r = 0ul;
            r |= vendor(v);
            r |= volume(vol);
            r |= chapter(c);
            r |= section(s);
            r |= topic(t);
            r |= content(cr);
            return r;
        }

        /// <summary>
        /// Defines a reference to a topic in an appendix
        /// </summary>
        /// <param name="v">The document vendor</param>
        /// <param name="vol">The referenced volume</param>
        /// <param name="a">The referenced appendix</param>
        /// <param name="s">The referenced section</param>
        /// <param name="t">The referenced topic</param>
        [MethodImpl(Inline), Op]
        public static DocRef define(Vendor v, Volume vol, Appendix a, Section s, Topic t, ContentRef cr = default)
        {
            var r = 0ul;
            r |= vendor(v);
            r |= volume(vol);
            r |= appendix(a);
            r |= section(s);
            r |= topic(t);
            r |= content(cr);
            return r;
        }

        /// <summary>
        /// Defines a reference to a topic in either a chapter or appendix
        /// </summary>
        /// <param name="v">The document vendor</param>
        /// <param name="vol">The referenced volume</param>
        /// <param name="d">The referenced chapter or appendix</param>
        /// <param name="s">The referenced section</param>
        /// <param name="t">The referenced topic</param>
        [MethodImpl(Inline), Op]
        public static DocRef define(Vendor v, Volume vol, Division d, Section s, Topic t, ContentRef cr = default)
        {
            var r = 0ul;
            r |= vendor(v);
            r |= volume(vol);
            r |= division(d);
            r |= section(s);
            r |= topic(t);
            r |= content(cr);
            return r;
        }

        [MethodImpl(Inline), Op]
        public static Entity content(DocRef src)
            => (ushort)(((ulong)F.Content & (ulong)src) >> (int)D.Content);

        [MethodImpl(Inline), Op]
        public static DocRef content(Entity src)
            => (ulong)src << (byte)D.Content;

        [MethodImpl(Inline), Op]
        public static Entity table(ContentNumber n0, ContentNumber n1 = default, ContentNumber n2 = default)
        {
            var l0 = (ushort)n0;
            var l1 = (ushort)((byte)n1 << (byte)ContentLevel.L1);
            var l2 = (ushort)((byte)n2 << (byte)ContentLevel.L2);
            var ct = (ushort)((byte)ContentType.Table << (byte)ContentLevel.Type);
            return (ushort)(l0 | l1 | l2 | ct);
        }

        [MethodImpl(Inline), Op]
        public static ContentNumber number(Entity src, N0 level)
        {
            var isolated = (ushort)((ushort)(ContentField.L0) & (ushort)src);
            return (ContentNumber)(isolated >> (byte)ContentLevel.L0);
        }

        [MethodImpl(Inline), Op]
        public static ContentNumber number(Entity src, N1 level)
        {
            var isolated = (ushort)((ushort)(ContentField.L1) & (ushort)src);
            return (ContentNumber)(isolated >> (byte)ContentLevel.L1);
        }

        [MethodImpl(Inline), Op]
        public static ContentNumber number(Entity src, N2 level)
        {
            var isolated = (ushort)((ushort)(ContentField.L2) & (ushort)src);
            return (ContentNumber)(isolated >> (byte)ContentLevel.L2);
        }

        [MethodImpl(Inline), Op]
        public static ContentType type(Entity src)
        {
            var isolated = (ushort)((ushort)(ContentField.Type) & (ushort)src);
            var value = isolated >> (byte)ContentLevel.Type;
            return (ContentType)value;
        }

        public static string format(Entity src)
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