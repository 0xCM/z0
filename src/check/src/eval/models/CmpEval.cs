//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct CmpEval<T>
    {
        public ComparisonKind Kind;

        public T A;

        public T B;

        public bit Result;

        public SuccessCode Success;
    }
}