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
    public readonly struct FileExt
    {        
        public readonly StringRef Name;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileExt(string src)           
            => new FileExt(src);

        [MethodImpl(Inline)]
        public FileExt(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public FileExt(StringRef name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name.Text;
    }
}