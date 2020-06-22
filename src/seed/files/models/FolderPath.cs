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
    public partial class FolderPath : IPathComponent<FolderPath>
    {        
        /// <summary>
        /// The full path name
        /// </summary>
        public string Name {get;}

        public static FolderPath Empty 
            => Define(string.Empty);

        /// <summary>
        /// Just the one
        /// </summary>
        FolderPath[] One 
            => new FolderPath[]{this};

        /// <summary>
        /// The name of the folder sans path
        /// </summary>
        public FolderName FolderName 
        {
            [MethodImpl(Inline)]
            get => new FolderName(Directory.GetParent(Name).Name);
        }
        
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

        public static FolderPath operator + (FolderPath path, RelativeLocation location)
            => FolderPath.Define(string.Concat(path.WithoutSeparatorSuffix.Name, FilePathSep, location.Name));

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
        /// Defines a subdirectory path
        /// </summary>
        /// <param name="name">The subdirectory name</param>
        [MethodImpl(Inline)]
        public FolderPath SubDir(FolderName name)
            => this + name;

        /// <summary>
        /// Defines a relative subdirectory path
        /// </summary>
        /// <param name="name">The subdirectory name</param>
        [MethodImpl(Inline)]
        public FolderPath SubDir(RelativeLocation name)
            => this + name;             

        /// <summary>
        /// Nonrecursively enumerates the folder's subfolders
        /// </summary>
        public FolderPath[] SubDirs
            => Directory.Exists(Name) 
            ? Directory.EnumerateDirectories(Name).Map(FolderPath.Define) 
            : Root.array<FolderPath>();

        /// <summary>
        /// Nonrecursively enumerates all files in the folder
        /// </summary>
        public FilePath[] AllFiles
            => Directory.EnumerateFiles(Name).Map(FilePath.Define);
                
        /// <summary>
        /// The folder path sans trailing separator
        /// </summary>
        public FolderPath WithoutSeparatorSuffix
            => Define(Path.TrimEndingDirectorySeparator(Name));        

        /// <summary>
        /// Nonrecursively enumerates files in the directory, if it exists, that match a specified extension
        /// </summary>
        /// <param name="ext">The extension to match</param>
        public FilePath[] Files(FileExtension ext)
            => Exists.IfSome(() => Directory.GetFiles(Name, ext.SearchPattern).Map(FilePath.Define), FilePath.None);

        /// <summary>
        /// Nonrecursively enumerates part-owned folder files
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="ext">The extension to match</param>
        public FilePath[] Files(PartId part, FileExtension ext)
            => Files(ext).Where(f => f.OwnedBy(part));

        /// <summary>
        /// Nonrecursively enumerates host-owned folder files
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="ext">The extension to match</param>
        public FilePath[] Files(ApiHostUri host, FileExtension ext)
            => Files(ext).Where(f => f.HostedBy(host));

        /// <summary>
        /// Enumerates files in the folder, with optional recursion, that match a specified extension
        /// </summary>
        /// <param name="ext">The extension to match</param>
        /// <param name="recursive">Whether to enumerate recursively</param>
        public IEnumerable<FilePath> Files(FileExtension ext, bool recursive)        
            => recursive ? Recurse(ext) : Files(ext);

        /// <summary>
        /// Nonrecursively enumerates folder files owned by a specified part
        /// </summary>
        /// <param name="part">The owning part</param>
        public FilePath[] Files(PartId part)
            => AllFiles.Where(f => f.OwnedBy(part));

        /// <summary>
        /// Nonrecursively enumerates folder files with names (including the extension) that contain a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        public FilePath[] Files(string substring)        
            => AllFiles.Where(f => f.FileName.Contains(substring));
            
        /// <summary>
        /// Nonrecursively Enumerates folder files that match a specified exension and with names that contain a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        public FilePath[] Files(FileExtension ext, string substring)        
            => Files(ext).Where(f => f.FileName.Name.Contains(substring));

        /// <summary>
        /// Enumerates the files in the folder, with optional recursion, owned by a specified parth and which match a specified extension
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="ext">The extension to match</param>
        /// <param name="recursive">Whether to enumerate recursively</param>
        public IEnumerable<FilePath> Files(PartId part, FileExtension ext, bool recursive)
            => recursive ? Recurse(part, ext) 
                : from f in Files(ext)
                  where f.OwnedBy(part)
                  select f;
        
        IEnumerable<FilePath> Recurse(FileExtension ext)        
            => from d in (One).Union(SubDirs)
               from f in d.Files(ext)
                  select f;
        
        IEnumerable<FilePath> Recurse(PartId owner, FileExtension ext)        
            => from d in (One).Union(SubDirs)
               from f in d.Files(ext)
                where f.OwnedBy(owner)
               select f;

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