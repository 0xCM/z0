//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.PortableExecutable;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]

    public interface IImageReader : IDisposable
    {
        PEReader PeReader {get;}

        Ptr<byte> BasePointer {get;}

        ulong ImageSize {get;}

        PEHeaders PeHeaders {get;}

        CoffHeader CoffHeader {get;}

        ReadOnlySpan<SectionHeader> SectionHeaders {get;}

        PEMemoryBlock SectonData(DirectoryEntry src);

        ReadOnlySpan<byte> Read(PEMemoryBlock src);
    }
}