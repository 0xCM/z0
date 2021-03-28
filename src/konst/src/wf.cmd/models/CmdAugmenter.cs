//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class CmdAugmenter<T,C> : WfService<T>, ICmdAugmenter<C>
        where T : CmdAugmenter<T,C>, new()
        where C : struct, ICmd<C>
    {
        public abstract ref C Augment(ref C cmd);

        public WfCmdBuilder Builder
            => Wf.CmdBuilder();
    }
}