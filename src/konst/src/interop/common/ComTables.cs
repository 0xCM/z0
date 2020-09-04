//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Security;

    using static Konst;

    public readonly partial struct ComTables
    {
        public struct IUnknownVTable
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
        }
    }
}