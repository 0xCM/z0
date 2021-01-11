//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        public static ClrAssembly EntryAssembly
        {
            [MethodImpl(Inline)]
            get => Assembly.GetEntryAssembly();
        }
    }
}