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
        public class Disposable : IDisposable
        {
            readonly string actionName;

            readonly Stopwatch stopwatch = Stopwatch.StartNew();

            private Disposable(string actionName)
            {
                this.actionName = actionName;
            }

            public static IDisposable Timing(string actionName)
            {
                Log.Write(actionName, ConsoleColor.DarkGray);
                return new Disposable(actionName);
            }

            public void Dispose()
            {
                var message = actionName + " complete. Took: " + stopwatch.Elapsed;
                Log.Write(message, ConsoleColor.Green);
            }
        }
    }
}
