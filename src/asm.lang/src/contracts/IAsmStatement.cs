//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmStatement
    {
        AsmMnemonicCode Mnemonic {get;}
    }

    public interface IAsmStatement<A> : IAsmStatement
        where A : unmanaged, IAsmOp
    {
        Args<A> Args {get;}
    }

    public interface IAsmStatement<A,B> : IAsmStatement
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
    {
        Args<A,B> Args {get;}

    }

    public interface IAsmStatement<A,B,C> : IAsmStatement
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
    {
        Args<A,B,C> Args {get;}

    }

    public interface IAsmStatement<A,B,C,D> : IAsmStatement
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
        where D : unmanaged, IAsmOp
    {
        Args<A,B,C,D> Args {get;}
    }
}