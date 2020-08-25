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
        [MethodImpl(Inline)]
        public static WfStepId step<T>()
            where T : struct, IWfStep<T>
        {
            var t = typeof(T);
            if(t.Tagged<StepAttribute>())
            {
                return AB.step(t.Tag<StepAttribute>().Value.Host);
            }
            else
                return AB.step(typeof(void));
        }
    }
}