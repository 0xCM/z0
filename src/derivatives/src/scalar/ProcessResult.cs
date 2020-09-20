//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.Scalar
{
    public class ProcessResult
    {
        public ProcessResult(string output, string errors, int exitCode)
        {
            this.Output = output;
            this.Errors = errors;
            this.ExitCode = exitCode;
        }

        public string Output { get; }

        public string Errors { get; }

        public int ExitCode { get; }
    }
}