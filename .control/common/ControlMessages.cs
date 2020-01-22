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

    static class ControlMessages
    {
        public static AppMsg ExecutingHost(IAssemblyDesignator host)
            => appMsg($"{now().ToLexicalString()} Executing {host.Name}");

        public static AppMsg FinishedHostExecution(IAssemblyDesignator host, double runtime)
            => appMsg($"{now().ToLexicalString()} Finished {host.Name} execution after {runtime} ms");

        public static AppMsg ExecutingSuites()
            => appMsg($"{now().ToLexicalString()} Executing test suites");

        public static AppMsg FinishedSuiteExecution(double runtime)
            => appMsg($"{now().ToLexicalString()} Completed test suite execution after {runtime} ms");

        public static AppMsg CatalogNotFound(AssemblyId id)        
            => appMsg($"Operation catalog was not found for assembly {id}", SeverityLevel.Warning);

        public static AppMsg CatalogEmpty(IOperationCatalog catalog)        
            => appMsg($"Operation catalog {catalog.CatalogName} is empty", SeverityLevel.Warning);

        public static AppMsg EmittingAsmArchives()        
            => appMsg($"Emitting assembly archives", SeverityLevel.Babble);

        public static AppMsg EmittingCatalog(IOperationCatalog catalog)        
            => appMsg($"Emitting {catalog.CatalogName} catalog from controller", SeverityLevel.Info);

    }
}