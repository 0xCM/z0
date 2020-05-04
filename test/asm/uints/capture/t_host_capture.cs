//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Seed;


    public sealed class t_host_capture : t_asm<t_host_capture>
    {    
        public void capture_math()
        {
            var service = AsmWorkflows.Create(Context).HostCaptureService(DataDir);
            var uri = ApiHostUri.FromHost<math>();
            var capture = service.CaptureHost(uri,true);

            Claim.eq(capture.Extracts.Length, capture.Parsed.Length);
            Claim.eq(capture.Extracts.Length, capture.Decoded.Length);
        }
    }
}