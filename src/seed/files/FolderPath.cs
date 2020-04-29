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

    using static Seed;

    /// <summary>
    /// Represents a fully-qualified path to a folder on the local machine
    /// </summary>
    public class FolderPath : IPathComponent<FolderPath>
    {        
        const char PathSeparator = IPathComponent.Separator;

        public string Name {get;}

        /// <summary>
        /// Creates a folder path directly from text, with no intervening manipulation
        /// </summary>
        /// <param name="name">The source path</param>
        [MethodImpl(Inline)]
        public static FolderPath Define(string name)
            => new FolderPath(name);

        /// <summary>
        /// Searches for files wihthin folder (nonrecursively) that match a specified extension
        /// </summary>
        /// <param name="src">The directory to search</param>
        /// <param name="ext">The extension to match</param>
        public static IEnumerable<FilePath> MatchExension(FolderPath src, FileExtension ext)
            => from f in Directory.GetFiles(src.Name, $"*.{ext}") 
                  select FilePath.Define(f);

        /// <summary>
        /// Combines a folder path with a subfolder name to form a new folder path
        /// </summary>
        /// <param name="path">The source path</param>
        /// <param name="folder">The subfolder to append</param>
        public static FolderPath operator + (FolderPath path, FolderName folder)
            => FolderPath.Define(string.Concat(path.WithoutTrailingSeparator().Name, PathSeparator, folder.Name));

        /// <summary>
        /// Combines a folder path with a filename to form a file path
        /// </summary>
        /// <param name="path">The source path</param>
        /// <param name="file">The file name</param>
        public static FilePath operator + (FolderPath path, FileName file)
            => FilePath.Define(string.Concat(path.WithoutTrailingSeparator().Name, PathSeparator, file.Name));

        public static FolderPath operator + (FolderPath path, RelativeLocation location)
            => FolderPath.Define(string.Concat(path.WithoutTrailingSeparator().Name, PathSeparator, location.Name));

        public static bool operator ==(FolderPath x, FolderPath y)
            => x.Equals(y);

        public static bool operator !=(FolderPath x, FolderPath y)
            => !x.Equals(y);

        public FolderPath()
        {
            Name = string.Empty;
        }

        public FolderPath(string name)
        {   
            Name = name;
        }

        /// <summary>
        /// Consigns the folder and its contents to oblivion
        /// </summary>
        /// <param name="recursive">How sure are you?</param>
        public Option<int> Delete(bool recursive = true)
        {
            try
            {
                if(Exists)
                    Directory.Delete(Name, recursive);
                return 0;
            }
            catch(Exception e)
            {
                e.Report();
                return Option.none<int>();
            }
        }


        /// <summary>
        /// Creates a folder if it doesn't exist
        /// </summary>
        /// <param name="dst">The target path</param>
        public FolderPath CreateIfMissing()
        {   
            if(!Exists) 
                Directory.CreateDirectory(Name);
            return this;
        }

        /// <summary>
        /// Deletes all files in the directory, but neither does it recurse nor delete folders
        /// </summary>
        /// <param name="owners">If nonempty, restricts the deletion operation to only files owned by a specified owner</param>
        public FolderPath Clear(params PartId[] owners)
        {   
            if(Exists) 
            {
                if(owners.Length != 0)
                {
                    foreach(var owner in owners)
                        foreach(var file in OwnedFiles(owner))
                            file.Delete();
                }
                else
                {
                    foreach(var f in AllFiles)
                        f.Delete();
                }
            }
            return this;
        }

        /// <summary>
        /// Specifies whether the represented directory actually exists within the file system
        /// </summary>
        public bool Exists
            => Directory.Exists(Name);

        /// <summary>
        /// Enumerates the folder's direct descenddant folders
        /// </summary>
        public IEnumerable<FolderPath> Subfolders
            => from d in Directory.EnumerateDirectories(Name) 
                select FolderPath.Define(d);

        /// <summary>
        /// Enumerates all files in the folder
        /// </summary>
        public IEnumerable<FilePath> AllFiles
            => from f in Directory.EnumerateFiles(Name)
                select FilePath.Define(f);

        /// <summary>
        /// Enumerates the files contained in the folder with a specified extension
        /// </summary>
        public IEnumerable<FilePath> Files(FileExtension ext, bool recursive = false)        
            => recursive ? Recurse(ext) : MatchExension(ext);

        /// <summary>
        /// Enumerates the files contained in the folder that belong to a specified owner and which match a specified extension
        /// </summary>
        public IEnumerable<FilePath> Files(PartId owner, FileExtension ext, bool recursive = false)
            => recursive ? Recurse(owner, ext) 
                : from f in MatchExension(ext)
                  where f.OwnedBy(owner)
                  select f;

        /// <summary>
        /// Enumerates the files contained in the folder with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The text to match</param>
        public IEnumerable<FilePath> Files(FileExtension ext, string match)        
            => from f in Files(ext)
                where f.FileName.Name.Contains(match) 
                select f;

        IEnumerable<FilePath> MatchExension(FileExtension ext)
            => MatchExension(this, ext);

        IEnumerable<FolderPath> Directories
            => Directory.EnumerateDirectories(Name).Select(path => FolderPath.Define(path));

        IEnumerable<FilePath> Recurse(FileExtension ext)        
            => from d in (new FolderPath[]{this}).Union(Directories)
               from f in MatchExension(d, ext)
                  select f;

        bool OwnedBy(PartId owner, string path)
            => FilePath.GetFileName(path).OwnedBy(owner);
        
        IEnumerable<FilePath> OwnedFiles(PartId owner)
            => from f in Directory.GetFiles(Name) 
                where OwnedBy(owner,f)
                select FilePath.Define(f);

        IEnumerable<FilePath> Recurse(PartId owner, FileExtension ext)        
            => from d in (new FolderPath[]{this}).Union(Directories)
               from f in MatchExension(d, ext)
                where f.OwnedBy(owner)
               select f;
        
        public FolderPath WithoutTrailingSeparator()
            => Define(Path.TrimEndingDirectorySeparator(Name));        

        [MethodImpl(Inline)]
        public FolderPath WithSubFolder(FolderName folder)
            => this + folder;

        [MethodImpl(Inline)]
        public FolderPath WithSubFolder(RelativeLocation folder)
            => this + folder;             

        public bool Equals(FolderPath src)
            => src != null && string.Compare(src.Name, this.Name, true) == 0;
        
        public int CompareTo(FolderPath other)
            => Name.CompareTo(other?.Name ?? string.Empty);

        public string Format()
            => Name;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()        
            => Name.GetHashCode();

        public override bool Equals(object src)
            => src is FolderPath p && Equals(p);

        public int CompareTo(IIdentified src)
            => src is FolderPath p ? CompareTo(p) : -1;
    }
}