//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct DecodeParsedStep
    {   
        public const WfStepKind Kind = WfStepKind.DecodeParsed;
        
        public const string Name = nameof(DecodeParsed);
    }
}