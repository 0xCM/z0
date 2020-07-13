//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFileKind
    {
        FileExt Ext {get;}        
    }

    public interface IFileKind<E> : IFileKind
        where E : unmanaged, Enum
    {
        E Classifier {get;}
    }
}