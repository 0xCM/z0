//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Seed;

    public interface IReportSink : ISink<IReport>
    {
        void Deposit<R>(IReport<R> src)
            where R : IRecord<R>;
    }
}