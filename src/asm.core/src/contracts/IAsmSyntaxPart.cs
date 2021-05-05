//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmSyntaxPart : ITextual
    {

    }

    public interface IAsmSyntaxPart<T> : IAsmSyntaxPart
        where T : IAsmSyntaxPart<T>
    {

    }
}