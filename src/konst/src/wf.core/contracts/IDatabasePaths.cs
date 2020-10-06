//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IDatabasePaths
    {
        /// <summary>
        /// The file database root
        /// </summary>
        FS.FolderPath DbRoot
            => FS.dir(@"j:\database");
    }
}