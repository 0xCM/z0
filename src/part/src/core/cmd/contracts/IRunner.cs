//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRunner
    {
        void Run();
    }

    public interface IRunner<T>
    {
        void Run(in T spec);
    }
}