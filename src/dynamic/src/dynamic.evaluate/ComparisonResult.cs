//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Describes the outcome of a comparison operation
    /// </summary>
    public struct ComparisonResult<K,T,R>
    {
        public K Operator;

        public T Left;

        public T Right;

        public R Outcome;
    }
}