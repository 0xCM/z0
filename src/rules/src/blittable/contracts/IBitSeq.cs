//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBitSeq
    {
        Span<byte> Edit {get;}

        ReadOnlySpan<byte> View {get;}

        BitWidth Width => View.Length*8;
    }

    [Free]
    public interface IBitSeq<T> : IBitSeq
        where T : unmanaged
    {
        T Storage {get;}
    }
}