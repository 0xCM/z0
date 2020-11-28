//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static z;

    class Control : IDisposable
    {
        public static void Main(params string[] args)
        {
            try
            {
                CaptureWorkflow.run(args);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}