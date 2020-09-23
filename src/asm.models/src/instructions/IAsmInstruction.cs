//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface IAsmInstruction
    {
        MemoryAddress IP {get;}

        MemoryAddress NextIp {get;}

        MemoryAddress Base {get;}

        Mnemonic Mnemonic {get;}
    }

    public interface IAsmInstruction<T> : IAsmInstruction
        where T : struct, IAsmInstruction<T>
    {

    }


    public interface IAsmHandler<H>
        where H : struct, IAsmHandler<H>
    {
        void Handle<T>(in T src)
            where T : struct, IAsmInstruction<T>;
    }
}