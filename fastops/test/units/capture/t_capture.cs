//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using System.Runtime.CompilerServices;
    using static zfunc;

    class TestEventSink : AppService, ICaptureEventSink
    {
        public TestEventSink(ITestContext context)
            : base(context)
        {

        }
        public void Accept(in CaptureEventInfo info)
        {
            
        }

    }


    public sealed class t_capture : t_fastops<t_capture>
    {
     
        public void capture_1()
        {
            var src = Intrinsics.Direct.Where(m => m.Name == nameof(dinx.vand));
            var stats = CaptureStatsSink.Create(stats => Trace(stats));
            //var control = CaptureServices.Control(new TestEventSink(this));
            var control = CaptureServices.Control(stats);
            var exchange = control.CreateExchange();            
            
            foreach(var method in src)
            {
                Trace(method.Identify());
                control.Capture(method,exchange);
            }

        }

    }

}