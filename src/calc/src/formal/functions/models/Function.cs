//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    partial struct Functions
    {
        public abstract class Function<A,B>
        {
            public abstract B Eval(A a);
        }
    }
}