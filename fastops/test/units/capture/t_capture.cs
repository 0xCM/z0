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

    class CaptureStatsSink : AppService, ICaptureStateSink
    {
        public CaptureStatsSink(ITestContext context)
            : base(context)
        {

        }

        public void Accept(in CaptureState src)
        {
            AppContext.PostMessage(src.ToString());
        }
    }

    public sealed class t_capture : t_fastops<t_capture>
    {
        void OnReceipt(in CaptureState state)
        {
            Trace(state);
        }

        PointReceiver<CaptureState> StateReceiver => OnReceipt;

        public void capture_1()
        {
            var src = Intrinsics.DirectMethods.Where(m => m.Name == nameof(dinx.vand));
            var control = NativeServices.CaptureControl(new CaptureStatsSink(this));
            var exchange = control.CreateExchange();
            
            
            foreach(var method in src)
            {
                Trace(method.Identify());
                control.RunCapture(method,exchange);
            }

        }

    }

}