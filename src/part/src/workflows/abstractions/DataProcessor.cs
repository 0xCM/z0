//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class DataProcessor<S,T> : IDataProcessor<S,T>
    {
        public abstract Outcome Process(in S src, out T dst);
    }
}