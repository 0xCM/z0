//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct LlvmRecords
    {
        [MethodImpl(Inline)]
        public static dag<L,R> dag<L,R>(L left, R right)
            where L : ITerm
            where R : ITerm
                => new dag<L,R>(left,right);

        [MethodImpl(Inline)]
        public static dag<L,EmptyTerm> dag<L>(L left)
            where L : ITerm
                => new dag<L,EmptyTerm>(left,default);
    }
}