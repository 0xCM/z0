//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FS;

    public interface IFsEntry : ITextual
    {
        PathPart Name {get;}

        string ITextual.Format()
            => Name.Format();
    }

    public interface IFsEntry<F> : IFsEntry
        where F : struct, IFsEntry<F>
    {

    }
}