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

    /// <summary>
    /// Represents a fully-qualified path to a file on the local machine
    /// </summary>
    public class FilePath : PathComponent<FilePath>
    {        
        /// <summary>
        /// Lonely, so
        /// </summary>
        public static FilePath[] None => Control.array<FilePath>();

        [MethodImpl(Inline)]
        public static FilePath Define(string name) 
            => new FilePath(name);

        [MethodImpl(Inline)]
        public static FileName GetFileName(string path)
            => FileName.Define(Path.GetFileName(path));

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

        /// <summary>
        /// Just the one
        /// </summary>
        FilePath[] One => Control.array(this);

        /// <summary>
        /// Determines whether the modeled file exists on disk
        /// </summary>
        public bool Exists
            => File.Exists(Name);

        public FileName FileName
            => FileName.Define(Path.GetFileName(Name));

        public FolderPath FolderPath
            => FolderPath.Define(Path.GetDirectoryName(Name));

        public FolderName FolderName
            => FolderName.Define(Directory.GetParent(FolderPath.Name).Name);

        public FileExtension Ext
            => FileName.Ext;

        public string FullPath
            => Name;
        
        public bool Rooted
            => Path.IsPathRooted(Name);
        
        public FilePath RenameFile(FileName src)
            => FolderPath + src;
    
        /// <summary>
        /// Determines whether the filename is of the form {owner}.{.}.{*}
        /// </summary>
        /// <param name="owner">The owner to test</param>
        public bool OwnedBy(PartId owner)
            => FileName.OwnedBy(owner);

        /// <summary>
        /// Determines whether the filename is of the form {owner}.{host}.{*}
        /// </summary>
        /// <param name="owner">The owner to test</param>
        public bool OwnedBy(ApiHostUri host)
            => FileName.OwnedBy(host);

        /// <summary>
        /// Determines whether the path contains a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        public bool Contains(string substring)
            => Name.Contains(substring, NoCase);

        /// <summary>
        /// Determines whether the path begins with a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        public bool StartsWith(string substring)
            => Name.StartsWith(substring, NoCase);

        /// <summary>
        /// Determines whether the path ends with a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        public bool EndsWith(string substring)
            => Name.EndsWith(substring, NoCase);

        public FilePath WithExtension(FileExtension ext)
            => FolderPath + FileName.Define(Path.ChangeExtension(Path.GetFileName(FullPath), ext.Name));                
    }
}