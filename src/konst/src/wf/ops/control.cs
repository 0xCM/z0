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
        [MethodImpl(Inline), Op]
        public static WfStepControl control(WfStepId id, Action fx)
            => new WfStepControl(id, fx);

        [MethodImpl(Inline)]
        public static WfStepControl<H> control<H>(Action fx)
            where H : struct, IWfStep<H>
                => new WfStepControl<H>(fx);
    }
}