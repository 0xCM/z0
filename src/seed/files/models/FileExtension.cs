//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a file extension
    /// </summary>
    public class FileExtension : PathComponent<FileExtension>
    {
        /// <summary>
        /// Describes the sort of file identified by the extension
        /// </summary>
        public string Description {get;}
        
        public string SearchPattern => IsEmpty ? "*.*" : $"*{Name}";
        
        [MethodImpl(Inline)]
        public static FileExtension Define(string name)
            => new FileExtension(name);

        [MethodImpl(Inline)]
        public static FileExtension Define(string name, string description)
            => new FileExtension(name, description);

        public FileExtension()
        {
            Description = string.Empty;
        }

        [MethodImpl(Inline)]
        public FileExtension(string name)
            : base(name)
        {
            Description = string.Empty;
        }

        [MethodImpl(Inline)]
        public FileExtension(string name, string description)
            : base(name)
        {
            Description = description;
        }
    }
}