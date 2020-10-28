//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Pipes
{
    using System;

    public class PipeNameLengthException : Exception
    {
        public PipeNameLengthException(string message)
            : base(message)
        {
        }
    }
}
