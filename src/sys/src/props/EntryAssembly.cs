//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct sys
    {
        public static Assembly EntryAssembly 
        {
            [MethodImpl(Options), Op]
            get => proxy.EntryAssembly;
        }

        public static Assembly ThisAssembly
        {
            [MethodImpl(Options), Op]
            get => proxy.ThisAssembly;
        }
    }
}