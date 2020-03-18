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

    static class ControlMessages
    {
        public static AppMsg ExecutingHost(IAssemblyResolution host)
            => appMsg($"{now().ToLexicalString()} Executing {host.Name}");

        public static AppMsg FinishedHostExecution(IAssemblyResolution host, double runtime)
            => appMsg($"{now().ToLexicalString()} Finished {host.Name} execution after {runtime} ms");

        public static AppMsg ExecutingSuites()
            => appMsg($"{now().ToLexicalString()} Executing test suites");

        public static AppMsg FinishedSuiteExecution(double runtime)
            => appMsg($"{now().ToLexicalString()} Completed test suite execution after {runtime} ms");

        public static AppMsg CatalogNotFound(AssemblyId id)        
            => appMsg($"Operation catalog was not found for assembly {id}", AppMsgKind.Warning);

        public static AppMsg CatalogEmpty(IApiCatalog catalog)        
            => appMsg($"Operation catalog {catalog.CatalogName} is empty", AppMsgKind.Warning);

        public static AppMsg DispatchingCatalogWorkers()        
            => appMsg($"Dispatching catalog workers", AppMsgKind.Babble);

        public static AppMsg DispatchingCatalogWorker(IApiCatalog catalog)        
            => appMsg($"Dispatching {catalog.CatalogName} worker", AppMsgKind.Info);

        public static AppMsg CollectingStats(IApiCatalog catalog)        
            => appMsg($"Collecting {catalog.CatalogName} catalog statistics", AppMsgKind.Info);

    }
}