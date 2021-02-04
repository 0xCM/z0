//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmStatement
    {
        AsmMnemonic Mnemonic {get;}
    }

    public interface IAsmStatement<A> : IAsmStatement
        where A : unmanaged
    {
        Args<A> Args {get;}
    }

    public interface IAsmStatement<A,B> : IAsmStatement
        where A : unmanaged
        where B : unmanaged
    {
        Args<A,B> Args {get;}

    }

    public interface IAsmStatement<A,B,C> : IAsmStatement
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
    {
        Args<A,B,C> Args {get;}

    }

    public interface IAsmStatement<A,B,C,D> : IAsmStatement
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged
    {
        Args<A,B,C,D> Args {get;}
    }
}