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
        public static AppMsg NoClosures(FastGenericInfo op)        
            => appMsg($"No closure was found for {op.Id}", SeverityLevel.Warning);

        public static AppMsg CatalogNotFound(AssemblyId id)        
            => appMsg($"Operation catalog was not found for assembly {id}", SeverityLevel.Warning);

        public static AppMsg Emitting(Type host)
            => appMsg($"Emitting operations defined by {host.Name}", SeverityLevel.Babble);

        public static AppMsg Emitting(FastGenericInfo op)        
            => appMsg($"Emitting operation {op.Id}", SeverityLevel.Babble);

        public static AppMsg Emitting(FastOpClosure closure)        
            => appMsg($"Emitting operation closure {closure.Id}", SeverityLevel.Babble);

        public static AppMsg Emitting(FastDirectInfo op)        
            => appMsg($"Emitting operation {op.Id}", SeverityLevel.Babble);

        public static AppMsg EmittingImmResolutions(FastOpInfo op)        
            => appMsg($"Emitting selected immediates for {op.Id}", SeverityLevel.Babble);
    }
}