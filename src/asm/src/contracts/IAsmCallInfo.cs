//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IMachineCallInfo
    {
        MemoryAddress Source {get;}

        MemoryAddress Target {get;}

        byte InstructionSize {get;}

        MemoryAddress TargetOffset {get;}

        BinaryCode Encoded {get;}
    }
}