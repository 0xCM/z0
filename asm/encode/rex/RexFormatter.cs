//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
 
    using static root;         

    using RF = RexFieldIndex;   

    readonly struct RexFormatter : INumericFormatter<RexPrefix>
    {
        public static INumericFormatter<RexPrefix> Default => default(RexFormatter);

        [MethodImpl(Inline)]
        public string Format(RexPrefix src, NumericBase @base)
            => src.Scalar.Format(@base);

        [MethodImpl(Inline)]
        public string Format(RexPrefix src)
            => $"{RF.Code}:{src.Code} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";

        [MethodImpl(Inline)]
        public NumericFormatter<RexPrefix> Concretize()
            => new NumericFormatter<RexPrefix>(this);       
    }
}