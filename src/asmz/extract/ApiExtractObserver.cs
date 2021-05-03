//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public class ApiExtractObserver
    {
        readonly IWfRuntime Wf;

        public ApiExtractObserver(IWfRuntime wf)
        {

        }

        public void HostResolved(in ResolvedHost src)
        {

        }

        public void PartResolved(in ResolvedPart src)
        {

        }

        public void MemberParsed(in ApiMemberExtract src, in ApiMemberCode dst)
        {

        }

        public void MemberDecoded(in ApiMemberCode src, in AsmRoutine dst)
        {

        }

        public void ParseFailure(in ApiMemberExtract src)
        {

        }
    }
}