//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ProjectRunner
    {
        public class ExecResult
        {
            public string MethodName {get;set;}

            public string Outcome {get;set;}

            public string ErrorMessage {get;set;}

            public string ErrorStackTrace {get;set;}

            public string[] StandardOutput {get;set;}

            public string[] StandardError {get;set;}
        }
    }
}