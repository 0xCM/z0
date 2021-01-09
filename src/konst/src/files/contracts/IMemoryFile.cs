//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IMemoryFile : IDisposable
    {
        FS.FilePath Path {get;}

        ByteSize Size {get;}

        MemoryAddress BaseAddress {get;}

        ReadOnlySpan<byte> View(ulong offset, ByteSize size);

        ReadOnlySpan<byte> View();

        ReadOnlySpan<T> View<T>();

        ReadOnlySpan<T> View<T>(uint tOffset, uint tCount);

        MemoryFileInfo Description {get;}
    }

    public interface IMemoryFile<F> : IMemoryFile, IComparable<F>
        where F : IMemoryFile<F>
    {


    }
}
