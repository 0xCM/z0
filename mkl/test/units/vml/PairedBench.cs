//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct PairedBench
    {
        public static readonly PairedBench Zero = Define(BenchmarkRecord.Empty, BenchmarkRecord.Empty);
        
        public static implicit operator PairedBench((BenchmarkRecord left, BenchmarkRecord right) src)
            => Define(src.left, src.right);

        public static PairedBench Define(BenchmarkRecord Left, BenchmarkRecord Right)
            => new PairedBench(Left,Right);

        public PairedBench(BenchmarkRecord Left, BenchmarkRecord Right)
        {
            if(Left.OpCount != Right.OpCount)
                throw new ArgumentException($"Operation counts not equal");
            this.Left = Left;
            this.Right = Right;
        }        

        public readonly BenchmarkRecord Left;
         

        public readonly BenchmarkRecord Right;

        public long OpCount
            => Left.OpCount;

        public override string ToString()
            => Format();

        public string Format(int? labelPad = null)
            => text.concat(Left.Format(labelPad), text.eol(), Right.Format(labelPad));            
    }
}