//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public interface IMemoryFiles : IWfStateless<IMemoryFiles>
    {
        ReadOnlySpan<T> Read<T>(in MemoryFile file, MemoryAddress src, uint count)
            where T : struct;

        ref readonly T Read<T>(MemoryAddress src)
            where T : struct;

        MemoryFileInfo Describe(in MemoryFile src);

        MemoryFile Open(FS.FilePath src);

        MappedFiles Map(FS.FolderPath src);

        ReadOnlySpan<byte> Read(MemoryAddress src, ByteSize size);

    }
}