//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPartParser<P> : IArrayParser<P,PartId>
        where P : IParser<PartId>
    {
        PartId[] ParseValid(params string[] args);
    }
}