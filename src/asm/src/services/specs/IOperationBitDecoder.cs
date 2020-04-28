//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    
    using static Seed;
    using static Memories;

    public interface IOperationBitDecoder : IService
    {
        Option<AsmInstructionList> Decode(OperationBits src);

        IEnumerable<AsmInstructionList> Decode(IEnumerable<OperationBits> operations);
    }
}