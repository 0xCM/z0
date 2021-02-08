//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class App
    {
        public static void Main(params string[] args)
        {
            try
            {
                Capture.run(args);
                //ApiCaptureRunner.run(args);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend { }
}