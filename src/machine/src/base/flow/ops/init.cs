//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Workflows
    {        
        public static Workflows init(IAppContext context)
            => new Workflows(context);

        Workflows(IAppContext context)
        {
            Context = context;
            Correlation = 0;
            Known = z.array(
                WorkflowIdentity.define<MachineWorkflows>(PartId.Machine),                
                EmitResBytes.Identity
                );
        }
    }

}