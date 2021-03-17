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
        public readonly struct FilePath : IFsEntry<FilePath>, IComparable<FilePath>, ILocation<FilePath>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FilePath(PathPart name)
                => Name = name;

            public uint PathLength
            {
                [MethodImpl(Inline)]
                get => Name.Length;
            }

            public ReadOnlySpan<char> PathData
            {
                [MethodImpl(Inline)]
                get => Name.View;
            }

            public bool Exists
            {
                [MethodImpl(Inline)]
                get => File.Exists(Name);
            }

            public FileName FileName
            {
                [MethodImpl(Inline)]
                get => file(Path.GetFileName(Name));
            }

            public FileExt Ext
            {
                [MethodImpl(Inline)]
                get => FS.ext(Path.GetExtension(Name).TrimStart('.'));
            }

            public FolderPath FolderPath
            {
                [MethodImpl(Inline)]
                get => dir(Path.GetDirectoryName(Name));
            }

            public FolderName FolderName
            {
                [MethodImpl(Inline)]
                get => folder(Directory.GetParent(FolderPath.Name).Name);
            }

            public FileInfo Info
            {
                [MethodImpl(Inline)]
                get => new FileInfo(Name);
            }

            /// <summary>
            /// The size of the file in bytes
            /// </summary>
            public ByteSize Size
            {
                [MethodImpl(Inline)]
                get => Info.Length;
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
            {
                [MethodImpl(Inline)]
                get => FileName.Owner;
            }

            /// <summary>
            /// Determines whether the filename is of the form {owner}.{host}.{*}
            /// </summary>
            /// <param name="owner">The owner to test</param>
            [MethodImpl(Inline)]
            public bool IsHost(ApiHostUri host)
                => FileName.IsHost(host);

            /// <summary>
            /// Determines whether the filename is of the form {owner}.{.}.{*}
            /// </summary>
            /// <param name="owner">The owner to test</param>
            [MethodImpl(Inline)]
            public bool IsOwner(PartId part)
                => FileName.IsOwner(part);

            [MethodImpl(Inline)]
            public bool Is(FileExt ext)
                => Name.Text.EndsWith(ext.Name.Text, NoCase);

            [MethodImpl(Inline)]
            public bool Is(FileExt x1, FileExt x2)
                => Is(x1 + x2);

            [MethodImpl(Inline)]
            public bool IsNot(FileExt ext)
                => !Is(ext);

            [MethodImpl(Inline)]
            public bool IsNot(FileExt x1, FileExt x2)
                => !Is(x1,x2);


            public FilePath WithoutExtension
                => FolderPath + FileName.WithoutExtension;

            public FilePath ChangeExtension(FileExt ext)
                => WithoutExtension + ext;

            public string ReadText()
                => File.ReadAllText(Name);

            public FilePath Timestamped()
                => timestamped(this);

            [MethodImpl(Inline)]
            public FilePath Replace(char src, char dst)
                => new FilePath(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public FilePath Replace(string src, string dst)
                => new FilePath(Name.Replace(src,dst));

            /// <summary>
            /// Determines whether the filename, including the extension, ends with a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool EndsWith(string substring)
                => FileName.EndsWith(substring);

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            [MethodImpl(Inline)]
            public string Format(PathSeparator sep, bool quote = false)
                => quote ? TextRules.Format.enquote(Name.Format(sep)) : Name.Format(sep);

            [MethodImpl(Inline)]
            public FileUri ToUri()
                => new FileUri(this);

            public override string ToString()
                => Format();

            public int CompareTo(FilePath src)
                => Name.CompareTo(src.Name);


            [MethodImpl(Inline)]
            public static FilePath operator +(FilePath a, FileExt b)
                => new FilePath(Z0.text.format("{0}.{1}", a.Name, b.Name));

            public static FilePath Empty
            {
                [MethodImpl(Inline)]
                get => new FilePath(PathPart.Empty);
            }
        }
    }
}