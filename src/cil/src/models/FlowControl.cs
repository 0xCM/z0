//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct CilModel
    {
        public enum FlowControl : byte
        {
            Branch = 0,

            Break = 1,

            Call = 2,

            Cond_Branch = 3,

            Meta = 4,

            Next = 5,

            Phi = 6,

            Return = 7,

            Throw = 8,
        }
    }
}