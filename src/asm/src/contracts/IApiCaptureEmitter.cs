//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IApiCaptureEmitter
    {
        AsmMemberRoutines Emit(ApiHostUri host, Index<ApiMemberExtract> src);
    }
}