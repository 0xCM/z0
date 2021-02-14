//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmSigToken : ITextual
    {
        AsmSigOpKind Kind {get;}

        string Symbol {get;}

        string Description {get;}

        string ITextual.Format()
            => Symbol;
    }

    public interface IAsmSigToken<T> : IAsmSigToken
        where T : unmanaged, IAsmSigToken<T>
    {

    }
}