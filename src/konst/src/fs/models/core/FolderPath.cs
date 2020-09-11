//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial struct FS
    {
        const string FolderJoinPattern = "{0}/{1}";

        const string FileJoinPattern = "{0}/{1}";

        public readonly struct FolderPath : IEntry<FolderPath>
        {
            public PathPart Name {get;}

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

            [MethodImpl(Inline)]
            public FolderPath(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public static FolderPath operator +(FolderPath a, FolderName b)
                => new FolderPath(text.format(FolderJoinPattern, a, b));

            [MethodImpl(Inline)]
            public static FilePath operator +(FolderPath a, FileName b)
                => new FilePath(text.format(FileJoinPattern, a, b));

            [MethodImpl(Inline)]
            static SearchOption option(bool recurse)
                => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            [MethodImpl(Inline)]
            public ListedFiles List(string pattern, bool recurse)
                => Directory.EnumerateFiles(Name, pattern, option(recurse))
                            .Array()
                            .Select(x => FS.path(pattern));

            public FilePath[] Match(string pattern = null)
                => Directory.EnumerateFiles(Name, pattern ?? "*.*").Array().Select(x => FS.path(x));

            public FilePath[] Exclude(string substring, string match = null)
                => text.nonempty(substring) ? Match(match).Where(f => !f.Name.Contains(substring)) : Match(match);

            /// <summary>
            /// Nonrecursively enumerates files in the directory, if it exists, that match a specified extension
            /// </summary>
            /// <param name="ext">The extension to match</param>
            public FilePath[] Files(FileExt ext)
                => Files(this, ext);

            /// <summary>
            /// Nonrecursively enumerates all files in the folder
            /// </summary>
            public Files AllFiles
                => Directory.EnumerateFiles(Name).Map(FS.path);

            public Files Files(string pattern, bool recurse)
                =>  Exists
                  ? Directory.EnumerateFiles(Name, pattern, recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Map(f => FS.path(f))
                  : sys.empty<FilePath>();

            public Files Files(bool recurse)
                => Exists
                 ? Directory.EnumerateFiles(Name, "*.*", recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Map(f => FS.path(f))
                 : sys.empty<FilePath>();

            /// <summary>
            /// Nonrecursively enumerates the folder's subfolders
            /// </summary>
            public FolderPath[] SubDirs
                => Directory.Exists(Name)
                ? Directory.EnumerateDirectories(Name).Map(x => FS.dir(x))
                : sys.empty<FolderPath>();

            /// <summary>
            /// Nonrecursively enumerates files in the directory, if it exists, that match a specified extension
            /// </summary>
            /// <param name="ext">The extension to match</param>
            static FilePath[] Files(FolderPath src, FileExt ext)
                => src.Exists ? Directory.GetFiles(src.Name, ext.SearchPattern).Map(FS.path) : sys.empty<FilePath>();

            static FilePath[] Files(FolderPath src, FileName name)
                => src.Exists ? Directory.GetFiles(src.Name, $"{name}").Map(FS.path) : sys.empty<FilePath>();

            /// <summary>
            /// Nonrecursively enumerates part-owned folder files
            /// </summary>
            /// <param name="part">The owning part</param>
            /// <param name="ext">The extension to match</param>
            static FilePath[] Files(FolderPath src, PartId part, FileExt ext)
                => Files(src, ext).Where(f => f.OwnedBy(part));

            /// <summary>
            /// Nonrecursively enumerates host-owned folder files
            /// </summary>
            /// <param name="part">The owning part</param>
            /// <param name="ext">The extension to match</param>
            static FilePath[] Files(FolderPath src, ApiHostUri host, FileExt ext)
                => Files(src,ext).Where(f => f.HostedBy(host));

            /// <summary>
            /// Enumerates files in the folder, with optional recursion, that match a specified extension
            /// </summary>
            /// <param name="ext">The extension to match</param>
            /// <param name="recursive">Whether to enumerate recursively</param>
            static IEnumerable<FilePath> Files(FolderPath src, FileExt ext, bool recursive)
                => recursive ? src.Recurse(ext) : Files(src,ext);

            /// <summary>
            /// Enumerates files in the folder, with optional recursion, that match a specified extension
            /// </summary>
            /// <param name="ext">The extension to match</param>
            /// <param name="recursive">Whether to enumerate recursively</param>
            static IEnumerable<FilePath> Files(FolderPath src, FileName name, bool recursive)
                => recursive ? src.Recurse(name) : Files(src,name);

            /// <summary>
            /// Nonrecursively Enumerates folder files that match a specified extension and with names that contain a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            static FilePath[] Files(FolderPath src, FileExt ext, string substring)
                => Files(src, ext).Where(f => f.FileName.Name.Contains(substring));

            /// <summary>
            /// Just the one
            /// </summary>
            FolderPath[] One
                => new FolderPath[]{this};

            IEnumerable<FilePath> Recurse(FileExt ext)
                => from d in (One).Union(SubDirs) from f in Files(d,ext) select f;

            IEnumerable<FilePath> Recurse(PartId owner, FileExt ext)
                => from d in (One).Union(SubDirs) from f in Files(d,ext) where f.OwnedBy(owner) select f;

            IEnumerable<FilePath> Recurse(FileName name)
                => from d in (One).Union(SubDirs) from f in Files(d,name) select f;


            /// <summary>
            /// Creates the represented directory in the file system if it doesn't exist
            /// </summary>
            /// <param name="dst">The target path</param>
            public FolderPath Create()
            {
                if(!Directory.Exists(Name))
                    Directory.CreateDirectory(Name);
                return this;
            }

            /// <summary>
            /// Specifies whether the represented directory actually exists within the file system
            /// </summary>
            public bool Exists
                => Directory.Exists(Name);

            public DirectoryInfo Info
            {
                [MethodImpl(Inline)]
                get => new DirectoryInfo(Name);
            }

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();

            public static FolderPath Empty
                => new FolderPath(PathPart.Empty);
        }
    }
}