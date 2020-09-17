//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public interface IWfFileEmission<E>
        where E : struct, IWfEvent<E>
    {
        FS.FilePath Path {get;}
    }
}