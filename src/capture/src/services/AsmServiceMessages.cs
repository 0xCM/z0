//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class AsmServiceMessages
    {        
        public static AppMsg InstructionSizeMismatch(MemoryAddress location, int offset, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction length does not match the reported instruction length:", 
                    $"address = {location}, datalen = {reported}, offset = {offset}, bytelen = {reported}"),
                        caller, file, line);
                        
        public static AppMsg InstructionBlockSizeMismatch(MemoryRange origin, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction block length does not match the reported total instruction length:", 
                    $"origin = {origin}, block length = {reported}, reported length = {reported}"),
                        caller, file, line);

        internal static void ExractedHost(this IHostCaptureService service, ApiHostUri host, FilePath dst)
            => service.Notify(AppMsg.Info($"Emitted extracted {host} operations to {dst}"));

        internal static void ExtractionFailed(this IHostCaptureService service, ApiHostUri host, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => service.Notify(AppMsg.Error($"Error extracting {host} operations", caller, file, line));


        public static AppMsg ExtractParseFailure(ApiHostUri host, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppMsg.Error($"Extract parse failure for {host}", caller, file, line);
        
        public static AppMsg ExtractParseFailure(OpUri op, ExtractTermCode code)
            => AppMsg.Warn($"Extract parse failure {code} for {op}");


    }
}