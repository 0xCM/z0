//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Core;

    public static class AsmServices
    {                
        /// <summary>
        /// Instantiates a contextual function archive service that is specialized for an assembly and api host
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog identity</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IContext context, PartId catalog, string host)
            => AsmFunctionArchive.Create(context, catalog, host);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IContext context, ApiHostUri host, bool imm)
            => AsmFunctionArchive.Create(context, host, imm);
 
        [MethodImpl(Inline)]
        public static IMemoryCapture MemoryCapture(this IContext context, int? bufferlen = null)
            => MemoryCaptureService.Create(context, bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, byte[] buffer)
            => OpExtractParser.New(context, buffer);

        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, int? bufferlen = null)
            => OpExtractParser.New(context, bufferlen);

        [MethodImpl(Inline)]
        public static IAsmHostArchive HostArchive(this IContext context, ApiHostUri host)
            => AsmHostArchive.Create(context, host);    
    }
}