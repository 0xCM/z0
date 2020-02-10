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


    public sealed class t_capture : t_fastops<t_capture>
    {    
        public void capture_1()
        {
            var stats1 = CaptureStatsSink.Create(stats => Trace($"stats1: {stats}"));

            var control = CaptureServices.Control(stats1);
            var exchange = control.CreateExchange();            
            
            var src = Intrinsics.Direct.Where(m => m.Name == nameof(dinx.vand));
            foreach(var method in src)
            {
                control.Capture(exchange, method.Identify(), method);
            }

        }
    }
}