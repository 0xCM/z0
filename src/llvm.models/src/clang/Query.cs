//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Query
    {
        public string Expression {get;}

        [MethodImpl(Inline)]
        public Query(string expr)
        {
            Expression = expr;
        }
    }
}