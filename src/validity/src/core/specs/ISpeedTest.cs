//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    public interface ISpeedTest : IService
    {
        void Measure<T>(UnaryOp<T> f, UnaryOp<T> cf, string opname)
            where T : unmanaged;        

        void Measure<T>(BinaryOp<T> cf, BinaryOp<T> f, string opname)
            where T : unmanaged;            
    }

    public interface ISpeedTestSink : IRecordSink<BenchmarkRecord>          
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Deposit(BenchmarkRecord.Define(opcount, duration, name));
    }
}