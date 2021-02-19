//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;

    public interface IAsmOpererands
    {
        /// <summary>
        /// The number of arguments accepted by the operand
        /// </summary>
        byte Count {get;}
    }

    public interface IAsmOperands<F,A> : IAsmOpererands
        where F : struct, IAsmOperands<F,A>
        where A : unmanaged, IAsmOp
    {
        byte IAsmOpererands.Count
            => 1;

        A this[N0 n] {get;}

        A First => this[n0];
    }

    public interface IAsmOperands<F,A,B> : IAsmOpererands
        where F : struct, IAsmOperands<F,A,B>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
    {

        byte IAsmOpererands.Count
            => 2;

        A this[N0 n] {get;}

        B this[N1 n] {get;}

        A First => this[n0];

        B Second => this[n1];
    }

    public interface IAsmOperands<F,A,B,C> : IAsmOpererands
        where F : struct, IAsmOperands<F,A,B,C>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
    {
        byte IAsmOpererands.Count
            => 3;

        A this[N0 n] {get;}

        B this[N1 n] {get;}

        C this[N2 n] {get;}

        A First => this[n0];

        B Second => this[n1];

        C Third => this[n2];
    }

    public interface IAsmOperands<F,A,B,C,D> : IAsmOpererands
        where F : struct, IAsmOperands<F,A,B,C,D>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
        where D : unmanaged, IAsmOp
    {
        byte IAsmOpererands.Count
            => 4;

        A this[N0 n] {get;}

        B this[N1 n] {get;}

        C this[N2 n] {get;}

        D this[N3 n] {get;}

        A First => this[n0];

        B Second => this[n1];

        C Third => this[n2];

        D Fourth => this[n3];
    }
}