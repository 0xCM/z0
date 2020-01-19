//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using static zfunc;

    public class NoCodeException : Exception
    {
        public NoCodeException(string method)
            : base($"No code was found for the method ${method}")
        {
            this.MethodName = method;
        }

        public string MethodName {get;}        
    }
}