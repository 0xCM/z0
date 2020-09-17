//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;

    [ApiHost]
    public unsafe readonly partial struct Pointers
    {
        public unsafe readonly struct Delegates
        {        
            [SuppressUnmanagedCodeSecurity]
            public delegate void Receiver<T>(T* pSrc)
                where T : unmanaged;
        }
    }
}