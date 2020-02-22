//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public readonly struct OpTimePair
    {
        public static readonly OpTimePair Zero = Define(BenchmarkRecord.Empty, BenchmarkRecord.Empty);
        
        public static implicit operator OpTimePair((BenchmarkRecord left, BenchmarkRecord right) src)
            => Define(src.left, src.right);

        public static OpTimePair Define(BenchmarkRecord Left, BenchmarkRecord Right)
            => new OpTimePair(Left,Right);

        public OpTimePair(BenchmarkRecord Left, BenchmarkRecord Right)
        {
            if(Left.OpCount != Right.OpCount)
                throw new ArgumentException($"Operation counts not equal");
            this.Left = Left;
            this.LeftLabel = Left.Operation;
            this.Right = Right;
            this.RightLabel = Right.Operation;
        }
        
        public readonly BenchmarkRecord Left;

        public readonly string LeftLabel;
         
        public readonly BenchmarkRecord Right;

        public readonly string RightLabel;
        public long OpCount
            => Left.OpCount;

        public override string ToString()
            => Format();

        public string Format(int? labelPad = null)
            => concat(Left.Format(labelPad), eol(), Right.Format(labelPad));            
    }
}