//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFileProcessor
    {
        Outcome Process(FS.FilePath src, FS.FilePath dst);
    }

    public interface IFileProcessor<S,T> : IFileProcessor
        where S : struct, IFilePath<S>, IFileType<S>
        where T : struct, IFilePath<T>, IFileType<T>
    {
        Outcome Process(S src, T dst);
    }
}