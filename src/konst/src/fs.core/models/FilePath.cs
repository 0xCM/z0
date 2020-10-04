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
    using static z;

    partial struct FS
    {
        public readonly struct FilePath : IEntry<FilePath>
        {
            public PathPart Name {get;}

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

            public static FilePath Empty
                => new FilePath(PathPart.Empty);

            [MethodImpl(Inline)]
            public static FileName operator +(FilePath a, FileExt b)
                => file(text.format("{0}.{1}",a,b));

            [MethodImpl(Inline)]
            public FilePath(PathPart name)
                => Name = name;

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
            /// Determines whether the filename is of the form {owner}.{host}.{*}
            /// </summary>
            /// <param name="owner">The owner to test</param>
            [MethodImpl(Inline)]
            public bool HostedBy(ApiHostUri host)
                => FileName.HostedBy(host);

            /// <summary>
            /// Determines whether the filename is of the form {owner}.{.}.{*}
            /// </summary>
            /// <param name="owner">The owner to test</param>
            [MethodImpl(Inline)]
            public bool OwnedBy(PartId owner)
                => owner == FileName.Owner;

            /// <summary>
            /// Specifies the file's owning part, if any
            /// </summary>
            public PartId Owner
            {
                [MethodImpl(Inline)]
                get => FileName.Owner;
            }

            [MethodImpl(Inline)]
            public bool Is(FileExt ext)
                => string.Compare(Ext.Name.Text, ext.Name.Text, NoCase) == 0;

            public FilePath ChangeExtension(FileExt ext)
                => FolderPath + FS.file(Path.ChangeExtension(Path.GetFileName(Name), ext.Name));

            public string ReadText()
                => File.ReadAllText(Name);

            public FilePath Timestamped()
                => timestamped(this);

            [MethodImpl(Inline)]
            public FilePath Replace(char src, char dst)
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
            public string Format(PathSeparator sep)
                => Name.Format(sep);

            [MethodImpl(Inline)]
            public FileUri ToUri()
                => new FileUri(this);

            public override string ToString()
                => Format();
        }
    }
}