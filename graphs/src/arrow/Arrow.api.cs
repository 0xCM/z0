//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    

    public static class Arrow
    {
        public static Arrow<A> Define<A>(params A[] nodes)
            where A : IEquatable<A>
                => new Arrow<A>(nodes);

        public static Arrow<A> Connect<A>(Arrow<A> head, Arrow<A> tail)
            where A : IEquatable<A>
                => new Arrow<A>(head,tail);
                
        internal static Arrow<A> Connect<A>(A[] src, A[] dst)
            where A : IEquatable<A>
                => new Arrow<A>(src,dst);        
    }

}