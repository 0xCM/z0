//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISized
    {
        BitSize StorageWidth {get;}

        BitSize DataWidth
            => StorageWidth;

        ByteSize StorageSize
            => (ulong)StorageWidth/8ul;
    }
}