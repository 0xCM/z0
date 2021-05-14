//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct CodeSolutions
    {
        public class InvalidSolutionFileException : Exception
        {
            public InvalidSolutionFileException()
            {
            }

            public InvalidSolutionFileException(string message) : base(message)
            {
            }

            public InvalidSolutionFileException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
}
