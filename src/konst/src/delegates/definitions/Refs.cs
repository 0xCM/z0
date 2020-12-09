//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial class Delegates
    {
        [Free]
        public delegate ref T RefProjector<S,T>(in T src, ref T dst);

        [Free]
        public delegate int RefComparer<T>(in T key, in T value);

    }
}