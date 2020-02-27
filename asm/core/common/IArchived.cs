//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IArchived
    {
        int Sequence {get;}

        object Content {get;}

    }

    public interface IArchived<T> : IArchived
    {
        new T Content {get;}

        object IArchived.Content
            => Content;
    }
}
