//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FS;

    public interface IFile : ITextual
    {
        FS.FilePath Path {get;}

        string ITextual.Format()
            => Path.Name;
    }
}