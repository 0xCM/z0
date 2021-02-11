//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IApiInstructionCoverter
    {
        Index<ApiInstruction> Convert(ApiCodeBlock code, Index<IceInstruction> src);
    }
}