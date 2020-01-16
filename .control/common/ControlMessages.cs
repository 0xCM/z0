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

        public static AppMsg EmittingHostOps(Type host)
            => appMsg($"Emitting operations defined by {host.Name}");
         
        public static AppMsg ExecutingHost(IAssemblyDesignator host)
            => appMsg($"{now().ToLexicalString()} Executing {host.Name}");

        public static AppMsg FinishedHostExecution(IAssemblyDesignator host, double runtime)
            => appMsg($"{now().ToLexicalString()} Finished {host.Name} execution after {runtime} ms");

        public static AppMsg ExecutingSuites()
            => appMsg($"{now().ToLexicalString()} Executing test suites");

        public static AppMsg FinishedSuiteExecution(double runtime)
            => appMsg($"{now().ToLexicalString()} Completed test suite execution after {runtime} ms");
    }
}