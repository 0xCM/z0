//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a fully-qualified path to a folder on the local machine
    /// </summary>
    public partial class FolderPath : ITextual
    {
        /// <summary>
        /// The full path name
        /// </summary>
        public string Name {get;}

        public static FolderPath Empty
            => Define(string.Empty);

        /// <summary>
        /// Creates a folder path directly from text, with no intervening manipulation
        /// </summary>
        /// <param name="name">The source path</param>
        [MethodImpl(Inline)]
        public static FolderPath Define(string name)
            => new FolderPath(name);

        /// <summary>
        /// Combines a folder path with a subfolder name to form a new folder path
        /// </summary>
        /// <param name="path">The source path</param>
        /// <param name="folder">The subfolder to append</param>
        public static FolderPath operator + (FolderPath path, FolderName folder)
            => FolderPath.Define(string.Concat(path.WithoutSeparatorSuffix.Name, FilePathSep, folder.Name));

        /// <summary>
        /// Combines a folder path with a filename to form a file path
        /// </summary>
        /// <param name="path">The source path</param>
        /// <param name="file">The file name</param>
        public static FilePath operator + (FolderPath path, FileName file)
            => FilePath.Define(string.Concat(path.WithoutSeparatorSuffix.Name, FilePathSep, file.Name));

        [MethodImpl(Inline)]
        public static bool operator ==(FolderPath x, FolderPath y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(FolderPath x, FolderPath y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public FolderPath()
            => Name = string.Empty;

        [MethodImpl(Inline)]
        public FolderPath(string name)
            => Name = name;

        /// <summary>
        /// Specifies whether the represented directory actually exists within the file system
        /// </summary>
        public bool Exists
            => Directory.Exists(Name);

        /// <summary>
        /// The folder path sans trailing separator
        /// </summary>
        public FolderPath WithoutSeparatorSuffix
            => Define(Path.TrimEndingDirectorySeparator(Name));

        [MethodImpl(Inline)]
        public bool Equals(FolderPath src)
            => src != null && string.Compare(src.Name, Name, true) == 0;

        [MethodImpl(Inline)]
        public int CompareTo(FolderPath other)
            => Name.CompareTo(other?.Name ?? string.Empty);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentified src)
            => src is FolderPath p ? CompareTo(p) : -1;

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Name.GetHashCode();

        public override bool Equals(object src)
            => src is FolderPath me && Equals(me);
    }
}