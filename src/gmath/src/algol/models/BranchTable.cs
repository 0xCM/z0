//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

   public ref struct BranchTable<S,T>
        where S : unmanaged
    {
        readonly Span<IBranchMap<S,T>> Branches;

        [MethodImpl(Inline)]
        public BranchTable(IBranchMap<S,T>[] src)
        {
            Branches = src;
        }
    }
}