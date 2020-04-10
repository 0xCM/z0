//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAssemblyCapture : IService
    {
        ParsedExtract[] Parse(MemberExtract[] src);
        
        MemberExtract[] Extract(ApiHost host);        

        AsmFunction[] Decode(ApiHost host, ParsedMemberCode[] parsed);        
    }
}
