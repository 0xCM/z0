//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    public enum FileCatalogEntryField : byte
    {
        FileExt,

        FileName,

        FolderName,

        FilePath
    }
}