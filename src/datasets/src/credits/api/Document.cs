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
    using Entity = DocRef;

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
        public static Entity define(Vendor v, Volume vol, Chapter c, Section s, Topic t, ContentRef cr = default)
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
        public static Entity define(Vendor v, Volume vol, Appendix a, Section s, Topic t, ContentRef cr = default)
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
        public static Entity define(Vendor v, Volume vol, Division d, Section s, Topic t, ContentRef cr = default)
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

        /// <summary>
        /// Extracts the Vendor segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Vendor vendor(Entity src)
            => (Vendor)(((ulong)F.Vendor & (ulong)src) >> (int)D.Vendor);

        /// <summary>
        /// Initializes an empty bitfield with a Vendor segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Entity vendor(Vendor src)
            => (ulong)src << (byte)D.Vendor;

        /// <summary>
        /// Extracts the Volume segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Volume volume(Entity src)
            => (Volume)(((ulong)F.Volume & (ulong)src) >> (int)D.Volume);

        /// <summary>
        /// Initializes an empty bitfield with a Volume segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Entity volume(Volume src)
            => (ulong)src << (byte)D.Volume;

        /// <summary>
        /// Extracts the Division segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Division division(Entity src)
            => (Division)(((ulong)F.Division & (ulong)src) >> (int)D.Division);

        /// <summary>
        /// Initializes an empty bitfield with a Division segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Entity division(Division src)
            => (ulong)src << (byte)D.Division;

        /// <summary>
        /// Extracts the Chapter segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Chapter chapter(Entity src)
            => (Chapter)(((ulong)F.Chapter & (ulong)src) >> (int)D.Chapter);

        /// <summary>
        /// Initializes an empty bitfield with a Chapter segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static DocRef chapter(Chapter src)
            => (ulong)src << (byte)D.Division;

        /// <summary>
        /// Extracts the Appendix segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Appendix appendix(Entity src)
            => (Appendix)(((ulong)F.Appendix & (ulong)src) >> (int)D.Appendix);

        /// <summary>
        /// Initializes an empty bitfield with an Appendix segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Entity appendix(Appendix src)
            => (ulong)src << (byte)D.Division;

        /// <summary>
        /// Extracts the Section segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Section section(Entity src)
            => (Section)(((ulong)F.Section & (ulong)src) >> (int)D.Section);

        /// <summary>
        /// Initializes an empty bitfield with a Section segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Entity section(Section src)
            => (ulong)src << (byte)D.Section;

        /// <summary>
        /// Extracts the Topic segment value
        /// </summary>
        /// <param name="src">The bitfield source</param>
        [MethodImpl(Inline), Op]
        public static Topic topic(Entity src)
            => (Topic)(((ulong)F.Topic & (ulong)src) >> (int)D.Topic);

        /// <summary>
        /// Initializes an empty bitfield with a Topic segment value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Entity topic(Topic src)
            => (ulong)src << (byte)D.Topic;

        public static string format(Entity src)
        {
            return text.concat(
                src.Vendor, UriSep,
                src.Volume, UriSep, 
                (byte)src.Chapter, DotSep, 
                (byte)src.Section, DotSep, 
                (byte)src.Topic, src.Content.IsEmpty ? string.Empty : text.concat(DotSep, src.Content)
                );            
        }
    }
}