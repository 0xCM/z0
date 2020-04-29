//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;


    public sealed class t_host_capture : t_asm<t_host_capture>
    {    
        public void capture_math()
        {
            var service = AsmWorkflows.Contextual(Context).HostCaptureService(DataDir);
            var uri = ApiHostUri.FromHost<math>();
            var capture = service.CaptureHost(uri,true);

            NotifyConsole($"Extracted {capture.Extracts.Length} {uri} members");
            NotifyConsole($"Parsed {capture.Parsed.Length} {uri} members");
            NotifyConsole($"Decoded {capture.Decoded.Length} {uri} members");            
        }
    }
}