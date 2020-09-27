//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static z;

    public interface IAsmArgs<F,A> : IAsmArgSequence<F,N1>
        where F : struct, IAsmArgs<F,A>
        where A : IAsmArg
    {
        A this[N0 n] {get;}

        A First  => this[n0];
    }

    public interface IAsmArgs<F,A,B> : IAsmArgSequence<F,N2>
        where F : struct, IAsmArgs<F,A,B>
        where A : IAsmArg
        where B : IAsmArg
    {

        A this[N0 n] {get;}

        B this[N1 n] {get;}

        A First  => this[n0];

        B Second  => this[n1];

    }

    public interface IAsmArgs<F,A,B,C> : IAsmArgSequence<F,N3>
        where F : struct, IAsmArgs<F,A,B,C>
        where A : IAsmArg
        where B : IAsmArg
        where C : IAsmArg
    {
        A this[N0 n] {get;}

        B this[N1 n] {get;}

        C this[N2 n] {get;}

        A First  => this[n0];

        B Second  => this[n1];

        C Third  => this[n2];
    }

    public interface IAsmArgs<F,A,B,C,D> : IAsmArgSequence<F,N4>
        where F : struct, IAsmArgs<F,A,B,C,D>
        where A : IAsmArg
        where B : IAsmArg
        where C : IAsmArg
        where D : IAsmArg
    {
        A this[N0 n] {get;}

        B this[N1 n] {get;}

        C this[N2 n] {get;}

        D this[N3 n] {get;}

        A First  => this[n0];

        B Second  => this[n1];

        C Third  => this[n2];

        D Fourth  => this[n3];
    }
}