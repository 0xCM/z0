//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmSigToken : ISyntaxToken<AsmSigOpKind>
    {

    }

    public interface IAsmSigToken<T> : IAsmSigToken
        where T : unmanaged, IAsmSigToken<T>
    {

    }
}