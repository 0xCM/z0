//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;

    partial struct HandleTypes
    {
        public readonly struct ProcessHandle : IHandle<ProcessHandle>
        {
            public MemoryAddress Address {get;}

            public bool IsOwner {get;}

            [MethodImpl(Inline)]
            internal ProcessHandle(IntPtr handle, bool own = true)
            {
                Address = handle;
                IsOwner  = own;
            }
        }

    }
}