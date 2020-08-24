//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AB
    {
        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="host">The reifying type</param>
        [MethodImpl(Inline), Op]
        public static WfStepId step(Type host)
            => new WfStepId(host, host.Name, token(WfPartKind.Step, host));

        /// <summary>
        /// Defines a workflow step id
        /// </summary>
        /// <param name="caller">The invoking member</param>
        /// <typeparam name="T">The host type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfStepId<H> step<H>(Type host)
            where H : struct
                => new WfStepId<H>(host, host.Name, token(WfPartKind.Step, host));
    }
}