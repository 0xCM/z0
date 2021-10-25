//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    public abstract class BinaryFunction<A,B,C> : Function<Paired<A,B>,C>
    {
        public override C Eval(Paired<A,B> src)
            => Eval(src.Left, src.Right);

        public abstract C Eval(A a, B b);
    }    
}