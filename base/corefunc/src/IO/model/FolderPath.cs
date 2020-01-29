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

    using static zfunc;

    /// <summary>
    /// Represents a fully-qualified path to a folder on the local machine
    /// </summary>
    public class FolderPath : PathComponent<FolderPath>
    {        
        public static FolderPath operator + (FolderPath lhs, FolderName rhs)
            => FolderPath.Define(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FolderPath lhs, FileName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FolderPath operator + (FolderPath lhs, RelativeLocation rhs)
            => FolderPath.Define(Path.Join(lhs.Name, rhs.Name));

        public static FolderPath Define(string Name)
            => new FolderPath(Name);

        public FolderPath(string Name)
            : base(Name)
        {

        }

        public string FullPath
            => Name;

        public IEnumerable<FolderPath> Subfolders
            => from d in Directory.EnumerateDirectories(Name) select FolderPath.Define(d);

        /// <summary>
        /// Enumerates all files contained in the folder with a specified extension
        /// </summary>
        public IEnumerable<FilePath> Files(FileExtension ext, bool recursive = false)        
            => recursive ? Recurse(ext) : from f in Directory.GetFiles(FullPath, $"*.{ext}") select FilePath.Define(f);

        IEnumerable<FilePath> Recurse(FileExtension ext)        
            => from d in Directory.EnumerateDirectories(FullPath)
               from f in Directory.GetFiles(d,$"*.{ext}")
               select FilePath.Define(f);             

        /// <summary>
        /// Enumerates the files contained in the folder with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The text to match</param>
        public IEnumerable<FilePath> Files(FileExtension ext, string match)        
            => from f in Files(ext)
                where f.FileName.Name.Contains(match) 
                select f;
        
    }
}