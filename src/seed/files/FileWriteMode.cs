//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    /// <summary>
    /// Defines the available stream-writer modes
    /// </summary>
    public enum FileWriteMode
    {
        Overwrite = 0,

        Append = 1
    }
}