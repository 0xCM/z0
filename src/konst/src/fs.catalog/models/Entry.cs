//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        public readonly struct Entry : IEquatable<Entry>, ITextual
        {
            const string FormatPattern = "{0}: {1}";

            public readonly ObjectKind Kind;

            public readonly AsciEncoded Name;

            [MethodImpl(Inline)]
            public Entry(string name, ObjectKind kind)
            {
                Name = name;
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public string Format()
                => text.format(FormatPattern, Kind, Name);

            [MethodImpl(Inline)]
            public bool Equals(Entry src)
                => Name.Equals(src.Name);

            public override string ToString()
                => Format();

            public override int GetHashCode()
                => Name.GetHashCode();

            public override bool Equals(object src)
                => src is Entry x && Equals(x);
        }
    }
}