//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class MemoryReadException : Exception
    {
        public MemoryReadException(ulong address)
                : base(address.ToString())
        {

        }
    }
}