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
        /// <param name="control">The controller type</param>
        [MethodImpl(Inline)]
        public static WfStepId step(Type control)
            => new WfStepId(control, control);

        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="control">The contoller type</param>
        /// <param name="effect">The effector type</param>
        [MethodImpl(Inline), Op]
        public static WfStepId step(Type control, Type effect)
            => new WfStepId(control, effect);

        /// <summary>
        /// Defines a workflow step id predicated on a parametric controller type
        /// </summary>
        /// <typeparam name="T">The host type</typeparam>
        [MethodImpl(Inline)]
        public static WfStepId<T> step<T>()
            where T : struct, IWfStep<T>
                => default;
    }
}