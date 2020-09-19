//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Defines the content of file path component
        /// </summary>
        public readonly struct PathPart : ITextual
        {
            public string Text {get;}

            [MethodImpl(Inline)]
            public static bool operator ==(PathPart a, PathPart b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(PathPart a, PathPart b)
                => !a.Equals(b);

            [MethodImpl(Inline)]
            public static implicit operator PathPart(char[] data)
                => new PathPart(data);

            [MethodImpl(Inline)]
            public static implicit operator PathPart(string data)
                => new PathPart(data);

            [MethodImpl(Inline)]
            public static implicit operator string(PathPart data)
                => data.Text;

            [MethodImpl(Inline)]
            public static PathPart from(string src)
                => new PathPart(src);

            [MethodImpl(Inline)]
            public PathPart(string name)
                => Text = name;

            [MethodImpl(Inline)]
            public PathPart(params char[] name)
                => Text = new string(name);

            public ReadOnlySpan<char> View
            {
                [MethodImpl(Inline)]
                get => Text;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Text?.Trim() ?? EmptyString;

            [MethodImpl(Inline)]
            public PathPart[] Split(char delimiter)
                => Text.SplitClean(delimiter).Select(from);

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => text.empty(Text);
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => text.nonempty(Text) && Text.Length > 0;
            }

            public static PathPart Empty
            {
                [MethodImpl(Inline)]
                get => new PathPart(EmptyString);
            }

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public PathPart Replace(char src, char dst)
                => Text.Replace(src,dst);

            public override int GetHashCode()
                => Text.GetHashCode();

            [MethodImpl(Inline)]
            public bool Equals(PathPart src)
                => string.Equals(Text, src.Text, NoCase);

            public override bool Equals(object src)
                => src is PathPart x && Equals(x);

            [MethodImpl(Inline)]
            public PathPart Remove(string substring)
                => Text.Remove(substring);

            [MethodImpl(Inline)]
            public bool Contains(string substring)
                => Text.Contains(substring);

            /// <summary>
            /// Determines whether the filename, including the extension, ends with a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool EndsWith(string substring)
                => Text.EndsWith(substring, NoCase);
        }
    }
}