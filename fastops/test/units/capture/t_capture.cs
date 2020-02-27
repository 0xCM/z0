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
            void OnEvent(in CaptureEventData data)
            {
                var state = data.CaptureState;
                data.Captured.OnSome(s => Trace(s.TermCode)).OnNone(() => Trace(state));
            }
            
            var exchange = CaptureServices.Exchange(OnEvent);
            var control = exchange.Operations;
            
            
            var src = Intrinsics.Direct.Where(m => m.Name == nameof(dinx.vand)).First();
            control.Capture(exchange, src.Identify(), src);

        }
    }
}