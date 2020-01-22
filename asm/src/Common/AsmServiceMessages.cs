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
        
    using static zfunc;

    static class AsmServiceMessages
    {
        public static AppMsg NoClosures(GenericOpInfo op)        
            => appMsg($"No closure was found for {op.Id}", SeverityLevel.Warning);

        public static AppMsg Emitting(Type host)
            => appMsg($"Emitting operations defined by {host.Name}", SeverityLevel.Babble);

        public static AppMsg Emitting(GenericOpInfo op)        
            => appMsg($"Emitting operation {op.Id}", SeverityLevel.Babble);

        public static AppMsg Emitting(OpClosure closure)        
            => appMsg($"Emitting operation closure {closure.Id}", SeverityLevel.Babble);

        public static AppMsg Emitting(DirectOpInfo op)        
            => appMsg($"Emitting operation {op.Id}", SeverityLevel.Babble);

        public static AppMsg EmittingCatalog(IOperationCatalog catalog)        
            => appMsg($"Emitting catalog {catalog.CatalogName} from catalog emitter", SeverityLevel.Info);

        public static AppMsg Emitted(AsmDescriptor descriptor)        
            => appMsg($"Emitted {descriptor.Uri}", SeverityLevel.Babble);

        public static AppMsg EmittingImmSpecializations(OpInfo op, IEnumerable<byte> immediates)        
            => appMsg($"Emitting immediates specializations {immediates.FormatHexList()} for {op.Id}", SeverityLevel.Babble);
    }
}