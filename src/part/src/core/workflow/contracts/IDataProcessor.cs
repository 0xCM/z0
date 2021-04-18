//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDataProcessor
    {
        Outcome Process(in dynamic src, out dynamic dst);
    }

    public interface IDataProcessor<S> : IDataProcessor
    {
        Outcome Process(in S src, out dynamic dst);

        Outcome IDataProcessor.Process(in dynamic src, out dynamic dst)
            => Process((S)src, out dst);

    }

    public interface IDataProcessor<S,T> : IDataProcessor<S>
    {
        Outcome Process(in S src, out T dst);

        Outcome IDataProcessor<S>.Process(in S src, out dynamic dst)
        {
            var outcome = Process(src, out var _dst);
            dst = _dst;
            return outcome;
        }
    }
}