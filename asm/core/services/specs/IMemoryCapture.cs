//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IMemoryCapture : IService
    {
        Option<MemoryExtract> Extract(MemoryAddress src);        

        Option<MemoryExtract> Parse(MemoryExtract src);

        Option<AsmInstructionList> Decode(MemoryExtract src);
                        
        Option<ParsedMemoryCapture> Capture(MemoryAddress src);        

    }
}