//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IFileArchivePaths
    {
        FS.FolderPath Root {get;}
    }

    public interface IFileArchivePaths<H> : IFileArchivePaths
        where H : struct, IFileArchivePaths<H>
    {

    }
}