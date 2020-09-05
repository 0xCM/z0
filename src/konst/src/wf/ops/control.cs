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

    partial struct Flow
    {
        [MethodImpl(Inline), Op]
        public static WfStepControl control(WfStepId id, Action fx)
            => new WfStepControl(id, fx);

        [MethodImpl(Inline)]
        public static WfStepControl<H> control<H>(Action fx)
            where H : IWfStep<H>, new()
                => new WfStepControl<H>(fx);
    }
}