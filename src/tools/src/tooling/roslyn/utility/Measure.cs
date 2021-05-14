//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/source-indexer
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    partial struct CodeSolutions
    {
        public sealed class Measure : IDisposable
        {
            private readonly Stopwatch stopwatch = Stopwatch.StartNew();
            private readonly string title;

            public static IDisposable Time(string title)
            {
                return new Measure(title);
            }

            private Measure(string title)
            {
                this.title = title;
            }

            public void Dispose()
            {
                Debug.WriteLine(title + ": " + stopwatch.Elapsed);
            }
        }
    }
}