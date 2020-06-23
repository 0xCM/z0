//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static Konst;
    using static BufferSeqId;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public class AsmChecks : TTestAsm
    {
        public static AsmChecks Create(IAsmContext context)
            => new AsmChecks(context);

        public IAsmContext Context {get;}

        public BufferTokens Buffers {get;}

        readonly BufferAllocation BufferAlloc;

        public ICaptureExchange CaptureExchange {get;}

        AsmChecks(IAsmContext context)
        {
            Context = context;
            Buffers = BufferSeq.alloc(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureCore, Buffers[Aux3], Buffers[Aux4]);
        }                
        
        public void Dispose()
        {
            BufferAlloc.Dispose();            
        }

        TTestAsm Me => this;

        TCaptureArchive CodeArchive 
            => Me.CaptureArchive(Part.ExecutingPart);

        protected IMemberCodeWriter HexWriter([Caller] string caller = null)
        {            
            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.Hex));
            return Archives.Services.UriCodeWriter(dstPath);
        }

        protected IAsmFunctionWriter AsmWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            var format = AsmFormatSpec.WithFunctionTimestamp;
            return AsmCore.Services.AsmWriter(dst,format);
        }
    }
}