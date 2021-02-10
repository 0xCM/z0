//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;


    using static Part;

    partial struct FS
    {
        const string FolderJoinPattern = "{0}/{1}";

        const string FileJoinPattern = "{0}/{1}";

        const string SearchAll = "*.*";

        public readonly struct FolderPath : IFsEntry<FolderPath>, ILocation<FolderPath>
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

            public FolderPath(PathPart name)
            {
                if(name.EndsWith(Chars.FSlash) || name.EndsWith(Chars.BSlash))
                    Name = name.RemoveLast();
                else
                    Name = name;
            }

            [MethodImpl(Inline)]
            public static FolderPath operator +(FolderPath a, FolderName b)
                => new FolderPath(Z0.text.format(FolderJoinPattern, a.Name, b.Name));

            [MethodImpl(Inline)]
            public static FilePath operator +(FolderPath a, FileName b)
                => new FilePath(Z0.text.format(FileJoinPattern, a.Name, b.Name));

            public FilePath[] Match(string pattern = null)
                => Directory.EnumerateFiles(Name, pattern ?? SearchAll).Array().Select(x => FS.path(x));

            public FilePath[] Exclude(string substring, string match = null)
                => Z0.text.nonempty(substring) ? Match(match).Where(f => !f.Name.Contains(substring)) : Match(match);

            public FilePath[] Files(FileExt ext, bool recurse = false)
                => Files(this, ext, recurse);

            public FS.Files Files(bool recurse, params FileExt[] ext)
                => Files(this, recurse, ext);

            /// <summary>
            /// Nonrecursively enumerates all files in the folder
            /// </summary>
            public FS.Files AllFiles
                => Directory.Exists(Name)
                ? files(Directory.EnumerateFiles(Name).Map(path))
                : FS.Files.Empty;

            public FS.Files Files(string pattern, bool recurse)
                => Exists
                ? files(Directory.EnumerateFiles(Name, pattern, option(recurse)).Map(path))
                : FS.Files.Empty;

            public FS.Files Files(FileExt[] ext, bool recurse)
                => Exists
                ? EnumerateFiles(recurse).Array()
                : FS.Files.Empty;

            public FS.Files Files(bool recurse)
                => Exists
                ? files(Directory.EnumerateFiles(Name, SearchAll, option(recurse)).Map(path))
                : FS.Files.Empty;

            public FolderPath[] SubDirs(bool recurse = false)
                => Directory.Exists(Name)
                ? Directory.EnumerateDirectories(Name, SearchAll, option(recurse)).Map(dir)
                : sys.empty<FolderPath>();

            public Deferred<FilePath> EnumerateFiles(bool recurse)
                => Seq.defer(EnumerateFiles(this, recurse));

            public Deferred<FilePath> EnumerateFiles(FileExt[] ext, bool recurse)
                => Seq.defer(EnumerateFiles(this, recurse, ext));

            public Deferred<FilePath> EnumerateFiles(FileExt ext, bool recurse)
                => Seq.defer(EnumerateFiles(this, ext, recurse));

            public Deferred<FilePath> EnumerateFiles(string pattern, bool recurse)
                => Seq.defer(EnumerateFiles(this,pattern, recurse));

            /// <summary>
            /// Nonrecursively enumerates part-owned folder files
            /// </summary>
            /// <param name="part">The owning part</param>
            /// <param name="ext">The extension to match</param>
            public FS.Files Files(PartId part, FileExt ext)
                => Files(ext).Where(f => f.IsOwner(part));

            /// <summary>
            /// Enumerates part-owned folder files
            /// </summary>
            /// <param name="part">The owning part</param>
            /// <param name="ext">The extension to match</param>
            public FS.Files Files(PartId part, FileExt ext, bool recurse)
                => Files(ext, recurse).Where(f => f.IsOwner(part));

            /// <summary>
            /// Nonrecursively enumerates host-owned folder files
            /// </summary>
            /// <param name="part">The owning part</param>
            /// <param name="ext">The extension to match</param>
            public FS.Files Files(ApiHostUri host, FileExt ext)
                => Files(ext).Where(f => f.IsHost(host));

            /// <summary>
            /// Just the one
            /// </summary>
            FolderPath[] One
                => new FolderPath[]{this};

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

            [MethodImpl(Inline)]
            public string Format(PathSeparator sep)
                => Name.Format(sep);

            public override string ToString()
                => Format();

            public static FolderPath Empty
                => new FolderPath(PathPart.Empty);

            [MethodImpl(Inline)]
            static SearchOption option(bool recurse)
                => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            [MethodImpl(Inline)]
            public static implicit operator Z0.FolderPath(FolderPath src)
                => Z0.FolderPath.Define(src.Name);

            static FilePath[] Files(FolderPath src, bool recurse, params FileExt[] ext)
                => ext.SelectMany(x => Directory.EnumerateFiles(src.Name, x.SearchPattern, option(recurse))).Map(FS.path);

            static FilePath[] Files(FolderPath src, FileExt ext, bool recurse = false)
                => src.Exists ? Directory.GetFiles(src.Name, ext.SearchPattern, option(recurse)).Map(FS.path) : sys.empty<FilePath>();

            static IEnumerable<FilePath> EnumerateFiles(FolderPath src, string pattern, bool recurse)
            {
                if(src.Exists)
                    foreach(var file in Directory.EnumerateFiles(src.Name, pattern, option(recurse)))
                        yield return path(file);
            }

            static IEnumerable<FilePath> EnumerateFiles(FolderPath src, bool recurse, FileExt[] ext)
            {
                if(!src.Exists)
                    return Deferred<FilePath>.Empty;

                var selected =
                        from x in ext
                        where src.Exists
                        from f in Directory.EnumerateFiles(src.Name, x.SearchPattern, option(recurse))
                        select  path(f);
                return selected;
            }

            static IEnumerable<FilePath> EnumerateFiles(FolderPath src, FileExt ext, bool recurse = false)
            {
                if(src.Exists)
                    foreach(var file in Directory.GetFiles(src.Name, ext.SearchPattern, option(recurse)))
                        yield return path(file);
            }

            static IEnumerable<FilePath> EnumerateFiles(FolderPath src, bool recurse)
            {
                if(src.Exists)
                    foreach(var file in Directory.EnumerateFiles(src.Name, SearchAll, option(recurse)))
                        yield return path(file);
            }
        }
    }
}