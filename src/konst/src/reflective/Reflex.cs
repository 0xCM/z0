//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiHost]
    public readonly partial struct Reflex
    {
        const BindingFlags BF = ReflectionFlags.BF_All;       

        public static Assembly EntryAssembly 
        {
            [MethodImpl(Inline), Op]
            get => sys.EntryAssembly;
        }

        public static Assembly ThisAssembly
        {
            [MethodImpl(Inline), Op]
            get => sys.ThisAssembly;
        }
    }
}