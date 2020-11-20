//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly struct RenderFunctions
    {
        [Free]
        public delegate bool Canonical<S,T>(in S src, out T dst);

    }


}