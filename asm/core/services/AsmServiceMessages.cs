//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;


    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class AsmServiceMessages
    {
        public static AppMsg CatalogEmitted(IAssemblyCatalog catalog)
            => AppMsg.Define($"Successfully emitted {catalog.CatalogName} catalog",AppMsgKind.Info);

        public static AppMsg CatalogEmissionFailed(IAssemblyCatalog catalog, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppMsg.Error($"Error occurred while emitting catalog {catalog.CatalogName}", caller, file, line);

        public static AppMsg Emitted(AsmEmissionToken src)
            => AppMsg.Babble($"Emitted {src.Uri}");

        public static AppMsg EmissionMismatch(OpIdentity id, int incount, int outcount)
            => AppMsg.Warn($"In/out mismatch on function group {id}, in = {incount}, out = {outcount}");
        
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

        public static AppMsg ExractedHost(ApiHostUri host, FilePath dst)
            => AppMsg.Info($"Emitted extracted {host} operations to {dst}");

        public static AppMsg HostExtractionFailed(ApiHostUri host, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppMsg.Error($"Error extracting {host} operations", caller, file, line);

        public static AppMsg ParsedExtracts(ApiHostUri host, FilePath dst)
            => AppMsg.Info($"Emitted parsed {host} op extracts to {dst}");

        public static AppMsg ExtractParseFailure(ApiHostUri host, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppMsg.Error($"Extract parse failure for {host}", caller, file, line);
        
        public static AppMsg ExtractParseFailure(OpUri op, ExtractTermCode code)
            => AppMsg.Warn($"Extract parse failure {code} for {op}");
        
        public static AppMsg DuplicateWarning(ApiHostUri host, OpIdentity id)
            => AppMsg.Warn($"The host {host} defines operations with a duplicated identifer: {id}");
    }
}