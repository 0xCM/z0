//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmDataType<H> : IAsmKeyword<H,AsmSizeQualifier>
        where H : unmanaged, IAsmDataType<H>
    {

    }

}