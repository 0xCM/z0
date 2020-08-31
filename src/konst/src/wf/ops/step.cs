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

    partial struct AB
    {
        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="host">The reifying type</param>
        [MethodImpl(Inline)]
        public static WfStepId step(Type host)
            => id(host);

        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="host">The reifying type</param>
        [MethodImpl(Inline)]
        public static WfStepId step(Type control, Type effect)
            => id(control,effect);

        /// <summary>
        /// Defines a workflow step id
        /// </summary>
        /// <param name="caller">The invoking member</param>
        /// <typeparam name="T">The host type</typeparam>
        [MethodImpl(Inline)]
        public static WfStepId<T> step<T>()
            where T : struct, IWfStep<T>
                => id<T>();
    }
}