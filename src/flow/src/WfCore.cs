//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct Flow
    {
        /// <summary>
        /// Defines a workflow step id
        /// </summary>
        /// <param name="caller">The invoking member</param>
        /// <typeparam name="T">The host type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfStepId<H> step<H>([CallerFilePath] string caller = null,  H t = default)
            where H : struct
                => new WfStepId<H>(typeof(H), caller);

        /// <summary>
        /// Defines a workflow step id
        /// </summary>
        /// <param name="caller">The host type</param>
        /// <param name="caller">The invoking member</param>
        [MethodImpl(Inline), Op]
        public static WfStepId step(Type host, [CallerFilePath] string caller = null)
            => new WfStepId(host, caller);
    }

}