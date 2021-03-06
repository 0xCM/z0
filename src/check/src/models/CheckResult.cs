//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CheckResult
    {
        public ClaimKind Claim {get;}

        /// <summary>
        /// The operation under test
        /// </summary>
        public OpUri Operation {get;}

        public Index<dynamic> Operands {get;}

        public bool Passed {get;}

        [MethodImpl(Inline)]
        public CheckResult(ClaimKind kind, OpUri subject, Index<dynamic> operands, bool passed)
        {
            Operands = operands;
            Operation = subject;
            Passed = passed;
            Claim = kind;
        }
    }
}