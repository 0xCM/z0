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

    partial struct Workflow
    {
        /// <summary>
        /// Creates an identifier for a workflow step
        /// </summary>
        /// <param name="control">The controller type</param>
        [MethodImpl(Inline), Op]
        public static WfStepId step(Type control)
            => new WfStepId(control);


        /// <summary>
        /// Defines a workflow step id predicated on a parametric controller type
        /// </summary>
        /// <typeparam name="T">The host type</typeparam>
        [MethodImpl(Inline)]
        public static WfStepId<T> step<T>()
            where T : new()
                => default;
    }
}