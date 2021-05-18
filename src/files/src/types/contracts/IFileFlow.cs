//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IFileFlow
    {
        FS.FilePath SourcePath {get;}

        FileType SourceType {get;}

        FS.FilePath TargetPath {get;}

        FileType TargetType {get;}
    }

    public interface IFileFlow<S,T> : IFileFlow, IDataFlow<FilePath<S>,FilePath<T>>
        where S : struct, IFilePath<S>, IFileType<S>
        where T : struct, IFilePath<T>, IFileType<T>
    {
        FS.FilePath IFileFlow.SourcePath
            => Source;

        FS.FilePath IFileFlow.TargetPath
            => Target;

        FileType IFileFlow.SourceType
            => Source.FileType.Untyped;

        FileType IFileFlow.TargetType
            => Target.FileType.Untyped;
    }
}