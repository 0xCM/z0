//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IAsmOps
    {
        /// <summary>
        /// The number of arguments accepted by the operand
        /// </summary>
        byte Count {get;}
    }

    /// <summary>
    /// Characterizes a operand sequence reification of length 1
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [Free]
    public interface IAsmOps<F,A> : IAsmOps
        where F : struct, IAsmOps<F,A>
        where A : unmanaged, IAsmOp
    {
        byte IAsmOps.Count
            => 1;

        A this[N0 n] {get;}

        A First => this[n0];
    }

    public interface IAsmOps<F,A,B> : IAsmOps
        where F : struct, IAsmOps<F,A,B>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
    {
        byte IAsmOps.Count
            => 2;

        A this[N0 n] {get;}

        B this[N1 n] {get;}

        A First => this[n0];

        B Second => this[n1];
    }

   [Free]
   public interface IAsmOps<F,A,B,C> : IAsmOps
        where F : struct, IAsmOps<F,A,B,C>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
    {
        byte IAsmOps.Count
            => 3;

        A this[N0 n] {get;}

        B this[N1 n] {get;}

        C this[N2 n] {get;}

        A First => this[n0];

        B Second => this[n1];

        C Third => this[n2];
    }

    [Free]
    public interface IAsmOps<F,A,B,C,D> : IAsmOps
        where F : struct, IAsmOps<F,A,B,C,D>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
        where D : unmanaged, IAsmOp
    {
        byte IAsmOps.Count
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