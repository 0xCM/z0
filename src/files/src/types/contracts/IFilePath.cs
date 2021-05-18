//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IFilePath<K> : IFile
        where K : struct, IFileType<K>
    {
        K FileType {get;}
    }

    /// <summary>
    /// Characterizes a classifiable file
    /// </summary>
    /// <typeparam name="K">The classifier type</typeparam>
    public interface IFilePath<F,K> : IFilePath<K>
        where F : struct, IFilePath<F,K>
        where K : struct, IFileType<K>
    {

    }
}