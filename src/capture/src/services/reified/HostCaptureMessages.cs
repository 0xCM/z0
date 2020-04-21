//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    static class HostCaptureMessages
    {        
        public static void ExtractionSuccess(this IHostCaptureService service, ApiHostUri host, FilePath dst)
            => service.Notify(AppMsg.Info($"Emitted extracted {host} operations to {dst}"));

        public static void ExtractionFailure(this IHostCaptureService service, ApiHostUri host, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => service.Notify(AppMsg.Error($"Error extracting {host} operations", caller, file, line));
    }
}