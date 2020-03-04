//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using Z0.Asm;

    public interface IAsmInstructionFormatter
    {

        string FormatInstruction(in MemoryAddress @base, in AsmInstructionInfo src);        
    }
}