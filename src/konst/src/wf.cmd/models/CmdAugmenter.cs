//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [CmdAugmenter]
    public abstract class CmdAugmenter<T,C> : WfService<T,ICmdAugmenter<C>>, ICmdAugmenter<C>
        where T : CmdAugmenter<T,C>, new()
        where C : struct, ICmd<C>
    {
        public abstract ref C Augment(ref C cmd);

        public CmdBuilder Builder=> Wf.CmdBuilder();
    }

    public class CmdAugmenterAttribute : Attribute
    {

    }
}