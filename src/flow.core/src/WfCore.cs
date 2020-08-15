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
    public readonly partial struct WfCore
    {
        /// <summary>
        /// Identifies a step predicated on a specified type name and kind
        /// </summary>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>        
        [MethodImpl(Inline)]
        public static WfStepId step<K,T>(K kind, T type)
            where K : unmanaged, Enum
                => new WfStepId(z.uint64(kind), typeof(T).Name);

        [MethodImpl(Inline)]
        public static WfStepId step<K>(K kind, Type type)
            where K : unmanaged, Enum
                => new WfStepId(z.uint64(kind), type.Name);

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