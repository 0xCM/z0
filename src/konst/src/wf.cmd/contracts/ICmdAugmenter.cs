//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICmdAugmenter
    {
        ICmd Augment(ICmd cmd);
    }

    public interface ICmdAugmenter<C> : ICmdAugmenter
        where C : struct, ICmd<C>
    {
        ref C Augment(ref C cmd);

        ICmd ICmdAugmenter.Augment(ICmd cmd)
        {
            var _cmd = (C)cmd;
            return Augment(ref _cmd);
        }
    }
}