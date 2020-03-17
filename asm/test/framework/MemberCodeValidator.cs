//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;


    public class MemberCodeValidator : IAsmWorkflowService
    {
        
        public IAsmWorkflowContext Context {get;}

        public MemberCodeValidator(IAsmWorkflowContext context)
        {
            this.Context = context;
        }


        public void Validate(in BufferSeq buffers, in ApiMemberCode api)
        {
            

        }
    
    }
}