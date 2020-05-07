//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IAsmBranch : INullaryKnown
    {
        MemoryAddress Base {get;}

        MemoryAddress IP {get;}

        MemoryAddress Target {get;}

        int Size {get;}

        bool IsNear {get;}
    }
}