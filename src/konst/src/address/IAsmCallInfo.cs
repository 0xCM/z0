//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAsmCallInfo
    {                
        MemoryAddress Source {get;}

        MemoryAddress Target {get;}

        byte InstructionSize {get;}

        MemoryAddress TargetOffset {get;}

        BinaryCode Encoded {get;}        
    }
}