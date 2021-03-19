//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct UnaryEval<K,T>
    {
        public K Kind;

        public T A;

        public T Result;
    }

    public struct UnaryEval<K,T,R>
    {
        public K Kind;

        public T A;

        public R Result;
    }
}