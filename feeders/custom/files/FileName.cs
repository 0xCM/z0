//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Custom;

    /// <summary>
    /// Defines a file name along with the extension in isolation 
    /// and without ascribing additional path content
    /// </summary>
    public class FileName : PathComponent<FileName>
    {        
        [MethodImpl(Inline)]
        public static FileName Define(string name)
            => new FileName(name);

        [MethodImpl(Inline)]
        public static FileName Define(string name, string ext)
            => new FileName(name,ext);

        [MethodImpl(Inline)]
        public static FileName Define(string name, FileExtension ext)
            => new FileName(name, ext.Name);

        public static FileName Timestamped(FileName src)
        {
            var first = new DateTime(2019,1,1);
            var current = DateTime.Now;
            var elapsed = (long) (current - first).TotalMilliseconds;
            var timestamped = src.Rename($"{src.NoExtension}-{elapsed}");
            return timestamped;            
        }

        [MethodImpl(Inline)]
        public static FilePath Timestamped(FilePath src)
            => src.RenameFile(Timestamped(src.FileName));
        
        public static FileName operator + (FileName name, FileExtension ext)
            => FileName.Define($"{name.Name}.{ext.Name}");

        public FileName()
        {

        }

        public FileName(string name)
            : base(name)
            {

            }

        public FileName(string name, string ext)
            : base($"{name}.{ext}")
            {

            }

        public Option<FileExtension> Extension
            => Path.HasExtension(Name) 
            ? FileExtension.Define(Path.GetExtension(Name)) 
            : Option.none<FileExtension>();

        /// <summary>
        /// The name of the file without the extension
        /// </summary>
        public string NoExtension 
            => Path.GetFileNameWithoutExtension(Name);
        
        public FileName Rename(string newName)
        {
            var ext = Extension.MapValueOrElse(x =>  x.Name, () => string.Empty);
            var renamed = FileName.Define($"{newName}{ext}");
            return renamed;            
        }

        public FileName WithExtension(FileExtension ext)
            => Define(NoExtension,ext);
    }
}