//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;


    [StructLayout(LayoutKind.Sequential)]
    public struct RuleSpec
    {
        public RuleId RuleId;

        public TableSpan<RuleOperand> Operands;

        public RuleEffect Effect;
    }
}