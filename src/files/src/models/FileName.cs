//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;

    partial struct FS
    {
        public readonly struct FileName : IFsEntry<FileName>, IComparable<FileName>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FileName(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public FileName(PathPart name, FileExt ext)
                => Name = string.Format(ExtPattern, name, ext);

            public bool HasExtension
            {
                [MethodImpl(Inline)]
                get => Path.HasExtension(Name);
            }

            public FileExt FileExt
            {
                [MethodImpl(Inline)]
                get => HasExtension ? FS.ext(Path.GetExtension(Name)) : FileExt.Empty;
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

            public FileName WithoutExtension
            {
                [MethodImpl(Inline)]
                get => FS.file(Path.GetFileNameWithoutExtension(Name));
            }

            public FileName WithExtension(FS.FileExt ext)
                => this + ext;

            /// <summary>
            /// Specifies the file's owning part, if any
            /// </summary>
            public PartId Owner
                => part(this);

            /// <summary>
            /// Determines whether the name of a file is of the form {owner}.{*}
            /// </summary>
            /// <param name="host">The owner to test</param>
            [MethodImpl(Inline)]
            public bool IsOwner(PartId id)
                => id == Owner;

            /// <summary>
            /// Determines whether the name of a file is of the form {owner}.{host}.{*}
            /// </summary>
            /// <param name="host">The owner to test</param>
            public bool IsHost(ApiHostUri host)
                => Name.Text.StartsWith(string.Concat(host.Owner.Format(), Chars.Dot, host.Name.ToLower(), Chars.Dot));

            public FileName ChangeExtension(FileExt ext)
                => FS.file(Path.GetFileNameWithoutExtension(Name), ext);

            /// <summary>
            /// Determines whether the filename, begins with a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool StartsWith(string substring)
                => Name.StartsWith(substring);

            /// <summary>
            /// Determines whether the filename, including the extension, ends with a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool EndsWith(string substring)
                => Name.EndsWith(substring);

            /// <summary>
            /// Determines whether the filename, including the extension, contains a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool Contains(string substring)
                => Name.Contains(substring);

            [MethodImpl(Inline)]
            public bool Is(FileExt ext)
                => ext.Matches(this);

            public override int GetHashCode()
                => Name.GetHashCode();

            public bool Equals(FileName src)
                => Name == src.Name;

            public override bool Equals(object src)
                => src is FileName x && Equals(x);

            const string ExtPattern = "{0}.{1}";

            const string Pattern = "{0}";

            /// <summary>
            /// Converts this filename to a <see cref='FilePath'/>
            /// </summary>
            [MethodImpl(Inline)]
            public FilePath ToPath()
                => path(Name);

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();

           public int CompareTo(FileName src)
                => Name.CompareTo(src.Name);

            // [MethodImpl(Inline)]
            // public static implicit operator Z0.FileName(FileName src)
            //     => Z0.FileName.define(src.Name);

            [MethodImpl(Inline)]
            public static FileName operator +(FileName a, FileExt b)
                => new FileName(Z0.text.format("{0}.{1}", a.Name, b.Name));

            [MethodImpl(Inline)]
            public static bool operator ==(FileName a, FileName b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(FileName a, FileName b)
                => !a.Equals(b);

            public static FileName Empty
            {
                [MethodImpl(Inline)]
                get => new FileName(PathPart.Empty);
            }
        }
    }
}