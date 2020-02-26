//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using Z0.AsmSpecs;

    public static class AsmServiceMessages
    {
        public static AppMsg CatalogEmitted(IOperationCatalog catalog)
            => appMsg($"Successfully emitted {catalog.CatalogName} catalog");

        public static AppMsg CatalogEmissionFailed(IOperationCatalog catalog)
            => appMsg($"Error occurred while emitting catalog {catalog.CatalogName}",SeverityLevel.Error);

        public static AppMsg NoClosures(GenericOpSpec op)        
            => appMsg($"No closure was found for {op.Id}", SeverityLevel.Warning);

        public static AppMsg Emitting(Type host)
            => appMsg($"Emitting operations defined by {host.Name}", SeverityLevel.Babble);

        public static AppMsg Emitting(AsmFunctionGroup src)
            => appMsg($"Emitting {src.Id}");

        public static AppMsg Emitted(CaptureTokenGroup src)
            => appMsg($"Emitted {src.Uri}");

        public static AppMsg Emitted(CaptureToken src)
            => appMsg($"Emitted {src.Uri}", SeverityLevel.Babble);

        public static AppMsg Emitting(GenericOpSpec op)        
            => appMsg($"Emitting operation {op.Id}", SeverityLevel.Babble);

        public static AppMsg Emitting(ClosedOpSpec closure)        
            => appMsg($"Emitting closure {closure.Id}", SeverityLevel.Babble);

        public static AppMsg Emitting(DirectOpSpec op)        
            => appMsg($"Emitting {op.Id}", SeverityLevel.Babble);

        public static AppMsg EmissionMismatch(OpIdentity id, int incount, int outcount)
            => appMsg($"In/out mismatch on function group {id}, in = {incount}, out = {outcount}", SeverityLevel.Warning);

        public static AppMsg EmittingCatalog(IOperationCatalog catalog)        
            => appMsg($"Emitting catalog {catalog.CatalogName} from catalog emitter", SeverityLevel.Info);

        public static AppMsg CapturingImmediates(GenericOpSpec op)        
            => appMsg($"Capturing {op.Id} generic immediates for kinds {op.Kinds.Select(k => k.ToString()).Concat(text.comma())}", SeverityLevel.Babble);

        public static AppMsg Decoded(AsmFunction f)        
            => appMsg($"Decoded function {f.Id}", SeverityLevel.Babble);

        public static AppMsg Decoding(OpIdentity id, MethodInfo m)        
            => appMsg($"Decoding  method {m.DisplayName()} with identity {id}", SeverityLevel.Babble);

        public static AppMsg DescriptorConflit(CaptureToken src)
            => appMsg($"The descriptor with uri {src.Uri} conflicts with an existing descriptor", SeverityLevel.Warning);
            
        public static AppMsg EmittingImmSpecializations(IOpSpec op, IEnumerable<byte> immediates)        
            => appMsg($"Emitting immediates specializations {immediates.FormatHexList()} for {op.Id}", SeverityLevel.Babble);
        
        public static AppMsg InstructionSizeMismatch(MemoryAddress location, int offset, int actual, int reported)
            => appMsg(text.concat(
                $"The encoded instruction length does not match the reported instruction length:", 
                $"address = {location}, datalen = {reported}, offset = {offset}, bytelen = {reported}"));

        public static AppMsg InstructionBlockSizeMismatch(MemoryRange origin, int actual, int reported)
            => appMsg(text.concat(
                $"The encoded instruction block length does not match the reported total instruction length:", 
                $"origin = {origin}, block length = {reported}, reported length = {reported}"));

    }
}