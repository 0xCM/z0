//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a type with specified width; this includes types of variable width,
    /// in which case, the <see cref='ISized.StorageWidth'> is zero
    /// </summary>
    [Free]
    public interface ISized
    {
        BitSize StorageWidth {get;}

        BitSize DataWidth
            => StorageWidth;

        ByteSize StorageSize
            => StorageWidth.Bytes;
    }
}