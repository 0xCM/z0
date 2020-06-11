//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ICallInfo
    {                
        MemoryAddress Source {get;}

        MemoryAddress Target {get;}

        byte InstructionSize {get;}

        MemoryAddress TargetOffset {get;}

        BinaryCode Encoded {get;}        
    }

}