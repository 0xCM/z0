//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static OpaqueApiClass;

    partial struct proxy
    {
        public static Assembly EntryAssembly
        {
            [MethodImpl(Options), Opaque(GetEntryAssembly)]
            get => Assembly.GetEntryAssembly();
        }
    }
}