//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public interface IAsmLayout
    {
        byte StorageSize {get;}

        ReadOnlySpan<byte> Content {get;}

        byte ContentSize
            => (byte)Content.Length;
    }

    public interface IAsmLayout<T> : IAsmLayout
        where T : unmanaged, IAsmLayout<T>
    {
        byte IAsmLayout.StorageSize
            => (byte)size<T>();
    }
}