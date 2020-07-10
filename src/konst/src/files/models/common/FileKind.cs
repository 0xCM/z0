//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
    public readonly struct FileKind<E>
        where E : unmanaged, Enum
    {
        public readonly E Kind;

        public readonly StringRef Ext;
        
        [MethodImpl(Inline)]
        public static implicit operator FileKind(FileKind<E> src)
            => new FileKind(EnumValue.e32u(src.Kind), src.Ext);

        [MethodImpl(Inline)]
        public FileKind(E kind, StringRef ext)
        {
            Kind = kind;
            Ext = ext;
        }    
    }

    public readonly struct FileKind
    {        
        public readonly uint Kind;

        public readonly StringRef Ext;

        [MethodImpl(Inline)]
        public FileKind(uint kind, StringRef ext)
        {
            Kind = kind;
            Ext = ext;
        }
    }
}