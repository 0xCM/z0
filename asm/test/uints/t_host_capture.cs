//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    public sealed class t_host_capture : t_asm<t_host_capture>
    {    

        public void capture_1()
        {
            var service =  Context.HostCaptureService();
            var uri = ApiHostUri.FromHost<math>();
            
        }
    }
}