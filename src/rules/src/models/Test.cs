//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Test
    {
        public IPredicate Condition {get;}

        [MethodImpl(Inline)]
        public Test(IPredicate condition)
        {
            Condition = condition;
        }
    }
}