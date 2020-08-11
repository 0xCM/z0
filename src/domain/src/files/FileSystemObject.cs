//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileSystemObject : IEquatable<FileSystemObject>, ITextual
    {
        const string FormatPattern = "{0}: {1}";

        public readonly FileSystemObjectKind Kind; 

        public readonly AsciEncoded Name;       
        
        [MethodImpl(Inline)]
        public FileSystemObject(string name, FileSystemObjectKind kind)
        {
            Name = name;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(FormatPattern, Kind, Name);

        [MethodImpl(Inline)]
        public bool Equals(FileSystemObject src)
            => Name.Equals(src.Name);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Name.GetHashCode();
    
        public override bool Equals(object src)        
            => src is FileSystemObject x && Equals(x);
    }
}