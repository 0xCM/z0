//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileKinds
    {
        [MethodImpl(Inline)]
        public static FileKind<E> define<E>(E kind, StringRef ext)
            where E : unmanaged, Enum
                => new FileKind<E>(kind,ext);

        [MethodImpl(Inline)]
        public static FileKind<E> define<E>(E kind, string ext)
            where E : unmanaged, Enum
                => new FileKind<E>(kind, ext);

        [MethodImpl(Inline)]
        public static StringRef ext<E,K>(K kind = default)
            where E : unmanaged, Enum
            where K : unmanaged, IFileKind
                => kind.Ext;
    }
}