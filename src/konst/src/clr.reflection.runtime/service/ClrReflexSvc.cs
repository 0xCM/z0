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
    using static z;

    [ApiHost(ApiNames.ClrQuerySvc)]
    public readonly partial struct ClrQuerySvc
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static Reflected reflected(IWfShell wf)
            => new Reflected(wf);

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