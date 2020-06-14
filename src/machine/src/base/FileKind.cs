//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
    public readonly struct FileKind<E> : IFileKind<E>
        where E : unmanaged, Enum
    {
        public E Kind {get;}

        public asci8 Ext {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator FileKind(FileKind<E> src)
            => new FileKind(Control.eStore(src.Kind, out var _), src.Ext);

        [MethodImpl(Inline)]
        public FileKind(E kind, asci8 ext)
        {
            Kind = kind;
            Ext = ext;
        }    
    }

    public readonly struct FileKind
    {        
        public ulong Kind {get;}

        public asci8 Ext {get;}

        [MethodImpl(Inline)]
        public FileKind(ulong kind, asci8 ext)
        {
            Kind = kind;
            Ext = ext;
        }
    }
}