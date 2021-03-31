//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;

    using api = AsmBytes;

    public interface IAsmInstruction
    {
        AsmHexCode Encoded {get;}

        ReadOnlySpan<byte> Data {get;}

        ReadOnlySpan<AsmByte> Bytes {get;}

        uint4 Size {get;}
    }


    public interface IAsmInstruction<T> : IAsmInstruction
        where T : unmanaged
    {
        new T Encoded {get;}

        AsmHexCode IAsmInstruction.Encoded
            => api.hexcode(Encoded);
    }

    public interface IAsmInstruction<H,T> : IAsmInstruction<T>
        where H : unmanaged, IAsmInstruction<H,T>
        where T : unmanaged
    {

    }
}