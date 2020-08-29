//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct AB
    {
        [MethodImpl(Inline)]
        public static ConfiguredStep<T> configure<T>(T step, params WfStepArg[] args)
            where T : struct, IWfStep<T>
                => new ConfiguredStep<T>(step, args);

        [MethodImpl(Inline)]
        public static DataBroker<K,C,T> broker<K,C,T>(IWfShell wf, int capacity, IndexFunction<K> xf)
            where K : unmanaged, Enum
                => new DataBroker<K,C,T>(wf, capacity, xf);
    }
}