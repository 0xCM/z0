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
        
    using static Root;

    static class ControlMessages
    {
        public static AppMsg ExecutingHost(IApiAssembly host)
            => msg($"{time.now().ToLexicalString()} Executing {host.Name}");

        public static AppMsg FinishedHostExecution(IApiAssembly host, double runtime)
            => msg($"{time.now().ToLexicalString()} Finished {host.Name} execution after {runtime} ms");

        public static AppMsg ExecutingSuites()
            => msg($"{time.now().ToLexicalString()} Executing test suites");

        public static AppMsg FinishedSuiteExecution(double runtime)
            => msg($"{time.now().ToLexicalString()} Completed test suite execution after {runtime} ms");

        public static AppMsg CatalogNotFound(AssemblyId id)        
            => msg($"Operation catalog was not found for assembly {id}", AppMsgKind.Warning);

        public static AppMsg CatalogEmpty(IApiCatalog catalog)        
            => msg($"Operation catalog {catalog.CatalogName} is empty", AppMsgKind.Warning);

        public static AppMsg DispatchingCatalogWorkers()        
            => msg($"Dispatching catalog workers", AppMsgKind.Babble);

        public static AppMsg DispatchingCatalogWorker(IApiCatalog catalog)        
            => msg($"Dispatching {catalog.CatalogName} worker", AppMsgKind.Info);

        public static AppMsg CollectingStats(IApiCatalog catalog)        
            => msg($"Collecting {catalog.CatalogName} catalog statistics", AppMsgKind.Info);
    }
}