//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IIntegralLoop<I>
        where I : unmanaged
    {
        void Step(I i);
    }

    public interface ILoopHost<H,I> : IIntegralLoop<I>
        where I : unmanaged
        where H : struct, ILoopHost<H,I>
    {

    }
}