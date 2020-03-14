//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public sealed class t_capture : t_asm<t_capture>
    {    
        public void capture_1()
        {
            void OnEvent(in AsmCaptureEvent data)
            {
                var state = data.CaptureState;
                //data.Captured.OnSome(s => Trace(s.TermCode)).OnNone(() => Trace(state));
            }
            
            var exchange = Context.ExtractExchange(OnEvent);
            var control = exchange.Operations;
            
            
            var src = Intrinsics.Direct.Where(m => m.Name == nameof(dvec.vand)).First();
            control.Capture(exchange, src.Identify(), src);

        }
    }
}