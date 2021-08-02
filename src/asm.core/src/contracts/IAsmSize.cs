//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmCodes;

    public interface IAsmSize
    {
        BitWidth Width {get;}

        AsmSizeKind Kind {get;}

    }

    public interface IAsmSize<T> : IAsmSize
        where T : unmanaged
    {
    }
}