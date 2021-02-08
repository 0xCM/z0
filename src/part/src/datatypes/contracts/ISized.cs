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
        BitSize Width {get;}
    }

    public interface ISized<T> : ISized
        where T : unmanaged
    {
        new T Width {get;}

        BitSize ISized.Width
            => memory.size<T>();
    }
}