//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IProcessService
    {

    }

    public interface IProcessService<T> : IProcessService
    {


    }

    public interface IProcessWorker
    {

    }

    public interface IProcessWorker<S,T> : IProcessWorker
    {

    }
}