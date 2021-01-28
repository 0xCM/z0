//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILoop<I>
        where I : unmanaged
    {
        void Step(I i);
    }

    public interface ILoop<H,I> : ILoop<I>
        where I : unmanaged
        where H : struct, ILoop<H,I>
    {

    }
}