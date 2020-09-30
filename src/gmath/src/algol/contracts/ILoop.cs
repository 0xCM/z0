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

    public interface ILoopAction<I>
    {
        void Step(I i);
    }

    public interface ILoopHost<H,I> : ILoopAction<I>
        where H : struct, ILoopHost<H,I>
    {

    }
}