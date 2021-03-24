//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IPartExecutor
    {
        Type ExecutorType {get;}

        void Run();

        void Run(ExecutorContext context);
    }

    public interface IPartExecutor<P> : IPartExecutor
        where P : IPartExecutor<P>
    {
        Type IPartExecutor.ExecutorType
            => typeof(P);
    }
}