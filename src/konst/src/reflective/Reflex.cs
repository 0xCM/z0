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

        [MethodImpl(Inline), Op]
        public static Reflected reflected(IWfShell wf)
            => new Reflected(wf);

        public static ReflectedKinds Kinds
            => default;

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