//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;
    using static z;

    [Free]
    public interface IMultiplex
    {
        IBuildArchive BuildArchive {get;}
    }
}