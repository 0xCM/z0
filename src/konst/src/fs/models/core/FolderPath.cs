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

    using static Konst;

    partial struct FS
    {
        const string FolderJoinPattern = "{0}/{1}";

        const string FileJoinPattern = "{0}/{1}";

        public readonly struct FolderPath : IEntry<FolderPath>
        {
            public PathPart Name {get;}

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
            public FilePath[] Files
                => Directory.EnumerateFiles(Name, "*.*").Array().Select(x => FS.path(x));

            public FilePath[] Match(string pattern = null)
                => Directory.EnumerateFiles(Name, pattern ?? "*.*").Array().Select(x => FS.path(x));

            public FilePath[] Exclude(string substring, string match = null)
                => text.nonempty(substring) ? Match(match).Where(f => !f.Name.Contains(substring)) : Match(match);

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