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
        public readonly struct FileName : IEntry<FileName>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public static FileName operator +(FileName a, FileExt b)
                => file(text.format("{0}.{1}",a,b));

            public FileExt Ext
            {
                [MethodImpl(Inline)]
                get => new FileExt(Path.GetExtension(Name.Name));
            }

            public FileName WithoutExtension
            {
                [MethodImpl(Inline)]
                get => FS.file(Path.GetFileNameWithoutExtension(Name));
            }

            [MethodImpl(Inline)]
            public FileName(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public FileName(PathPart name, FileExt ext)
                => Name = text.format(ExtPattern, name, ext);

            public bool HasExtension
            {
                [MethodImpl(Inline)]
                get => Path.GetExtension(z.span(Name.Name)).Length != 0;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }

            /// <summary>
            /// Specifies the file's owning part, if any
            /// </summary>
            public PartId Owner
                => PartIdParser.single(WithoutExtension.Name.Remove("z0."));

            public static FileName Empty
            {
                [MethodImpl(Inline)]
                get => new FileName(PathPart.Empty);
            }

            /// <summary>
            /// Determines whether the name of a file is of the form {owner}.{host}.{*}
            /// </summary>
            /// <param name="host">The owner to test</param>
            public bool HostedBy(ApiHostUri host)
                => Name.Name.StartsWith(string.Concat(host.Owner.Format(), Chars.Dot, host.Name.ToLower(), Chars.Dot));

            const string ExtPattern = "{0}.{1}";

            const string Pattern = "{0}";

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();

        }
    }
}