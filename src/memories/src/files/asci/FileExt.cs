//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an asci4 file extension
    /// </summary>
    public readonly struct FileExt : IFileExt<asci8>
    {        
        public asci8 Name {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsBlank;
        }

        public asci16 SearchPattern 
        {
            [MethodImpl(Inline)]
            get => IsEmpty ? "*.*" : $"*{Name}";
        }

        [MethodImpl(Inline)]
        public static implicit operator FileExt(string src)           
            => new FileExt(src);

        [MethodImpl(Inline)]
        public FileExt(asci8 name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name.Text;
    }
}