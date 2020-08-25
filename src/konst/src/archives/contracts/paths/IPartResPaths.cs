//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IPartResPaths : IAppPaths
    {
        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FolderPath ResRoot
            => LogRoot + FolderName.Define("respack/content");

        FolderPath ResTables
            => ResRoot + FolderName.Define("tables");

        FolderPath ResIndex
            => ResRoot + FolderName.Define("index");

        FolderPath AsmResTables
            => ResTables + FolderName.Define("asm");
    }
}