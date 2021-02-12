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
        BitWidth Width {get;}

        ByteSize Size => Width.Bytes;
    }

    public interface ISized<T> : ISized
        where T : unmanaged
    {
        new T Width {get;}

        BitWidth ISized.Width
            => memory.size<T>();
    }
}