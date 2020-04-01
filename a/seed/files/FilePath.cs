//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Seed;

    public enum FileWriteMode
    {
        Overwrite = 0,

        Append = 1
    }

    /// <summary>
    /// Represents a fully-qualified path to a file on the local machine
    /// </summary>
    public class FilePath : PathComponent<FilePath>
    {        
        [MethodImpl(Inline)]
        public static FilePath Define(string name) => new FilePath(name);

        public static FilePath operator + (FilePath a, FileName b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public static FilePath operator + (FilePath a, FolderName b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public static FilePath operator + (FilePath a, FileExtension b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public static FilePath operator + (FilePath a, FilePath b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public FilePath(){}

        public FilePath(string name)
            : base(name)
        {

        }

        public FileName FileName
            => FileName.Define(Path.GetFileName(Name));

        public FolderPath FolderPath
            => FolderPath.Define(Path.GetDirectoryName(Name));

        public FolderName FolderName
            => FolderName.Define(Directory.GetParent(FolderPath.Name).Name);

        public string FullPath
            => Name;

        public Option<FileExtension> Extension
            => FileName.Extension;
        
        public bool Rooted
            => Path.IsPathRooted(Name);
        
        public FilePath RenameFile(FileName src)
            => FolderPath + src;
    
        public FilePath WithExtension(FileExtension ext)
            => FolderPath + FileName.Define(Path.ChangeExtension(Path.GetFileName(FullPath), ext.Name));                
    }
}