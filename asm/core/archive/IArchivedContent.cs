//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IArchivedContent
    {
        int Sequence {get;}

        object Content {get;}

    }

    public interface IArchivedContent<T> : IArchivedContent
    {
        new T Content {get;}

        object IArchivedContent.Content
            => Content;
    }
}
