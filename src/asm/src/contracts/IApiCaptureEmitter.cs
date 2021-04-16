//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IApiCaptureEmitter
    {
        AsmHostRoutines Emit(ApiHostUri host, Index<ApiMemberExtract> src);
    }
}