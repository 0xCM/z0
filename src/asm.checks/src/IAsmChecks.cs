//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IAsmChecks : IService
    {
        void Execute(in BufferSeq buffers, ApiMemberCode code);        

        void Execute(in BufferSeq buffers, ApiMemberCode[] code);        
    }

}