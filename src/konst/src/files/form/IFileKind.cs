//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFileKind
    {
        StringRef Ext {get;}        
    }

    public interface IFileKind<E> : IFileKind
        where E : unmanaged, Enum
    {
        E Kind {get;}

    }

    public interface IFileKind<F,E> : IFileKind<E>
        where E : unmanaged, Enum
        where F : unmanaged, IFileKind<F,E>
    {

    }
}