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

            public static FilePath Empty => new FilePath(PathPart.Empty);

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

            public FileExt FileExt
            {
                [MethodImpl(Inline)]
                get => FS.ext(Path.GetExtension(Name));
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

            public FilePath ChangeExtension(FileExt ext)
                => FolderPath + FS.file(Path.ChangeExtension(Path.GetFileName(Name), ext.Name));

            public string ReadText()
                => File.ReadAllText(Name);

            public FilePath Timestamped()
            {
                var name = FileName.WithoutExtension;
                var ext = FileExt;
                var stamped = FS.file(text.format("{0}.{1}.{1}", name, timestamp(), ext));
                return FolderPath + stamped;
            }

            [MethodImpl(Inline)]
            public FilePath Replace(char src, char dst)
                => new FilePath(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();
        }
    }
}