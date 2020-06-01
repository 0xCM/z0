//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    public interface IAsmCommand : IEncodedCommand
    {
        ReadOnlySpan<char> Body {get;}

        ReadOnlySpan<char> OpCode {get;}

        ReadOnlySpan<char> Instruction {get;}
    }

    public interface IAsmCommand<F> : IAsmCommand, IEncodedCommand<F>
        where F: struct, IAsmCommand<F>
    {

    }
}