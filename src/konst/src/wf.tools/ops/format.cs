//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Tooling
    {
        [Projector]
        static ref ToolOption extract(MemberInfo src, ushort index, out ToolOption dst)
        {
            var tag = src.RequiredTag<SlotAttribute>();
            var purpose = src.Tag<MeaningAttribute>().MapValueOrElse(t => (string)t.Content, () => EmptyString);
            dst = option(index, text.ifempty(tag.Name, src.Name), purpose);
            return ref dst;
        }

        [Formatter]
        public static string format(OptionDelimiter src)
        {
            var len = src.Length;
            if(len == 0)
                return EmptyString;
            else if(len == 1)
            {
                Span<char> content = stackalloc char[1]{(char)src.C0};
                return new string(content);
            }
            else
            {
                Span<char> content = stackalloc char[2]{(char)src.C0, (char)src.C1};
                return new string(content);
            }
        }

        [MethodImpl(Inline), Formatter]
        public static string format(ToolOption src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [MethodImpl(Inline), Formatter, Closures(Closure)]
        public static string format<K>(ToolOption<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [Formatter]
        public static string format(ToolArg src, char specifier)
            => string.Format("{0}{1}{2}", src.Option, specifier, src.Value);

        public static string format<K,V>(ToolArg<K,V> src, char specifier)
            where K : unmanaged
                => string.Format("{0}{1}{2}", src.Option, specifier, src.Value);
    }
}