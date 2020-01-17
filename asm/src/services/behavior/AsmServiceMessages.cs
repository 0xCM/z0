//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using Z0.Designators;
    
    using static zfunc;


    public static class AsmServiceMessages
    {

        public static AppMsg EmittingHostOps(Type host)
            => appMsg($"Emitting operations defined by {host.Name}");

        public static AppMsg EmittingOp(FastGenericInfo op)        
            => appMsg($"Emitting generic op {op.Name}", SeverityLevel.Babble);

        public static AppMsg NoClosures(FastGenericInfo op)        
            => appMsg($"The generic op {op.Name} has no closures", SeverityLevel.Warning);

        public static AppMsg EmittingOp(FastDirectInfo op)        
            => appMsg($"Emitting direct op {op.Name}", SeverityLevel.Babble);

        public static AppMsg EmittingImmediateResolutions(FastOpInfo op)        
            => appMsg($"Emitting immediate resolutions for {op.Name}", SeverityLevel.Babble);

    }


}