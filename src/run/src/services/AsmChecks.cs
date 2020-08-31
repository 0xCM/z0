//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Konst;
    using static BufferSeqId;

    public class AsmChecks : IAsmTester
    {
        public IAsmContext Context {get;}

        public BufferTokens Tokens {get;}

        readonly BufferAllocation BufferAlloc;

        public ICaptureExchange CaptureExchange {get;}

        public AsmChecks(IAsmContext context)
        {
            Context = context;
            Tokens = Z0.Buffers.sequence(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = CaptureExchangeProxy.create(Context.CaptureCore, Tokens[Aux3]);
        }

        public void Dispose()
        {
            BufferAlloc.Dispose();
        }

        public ref readonly BufferToken this[BufferSeqId index]
            => ref Tokens[index];

        // IPartCapturePaths CodeArchive
        //     => Me.CaptureArchive(Part.ExecutingPart);

        // protected IArchiveWriter HexWriter([Caller] string caller = null)
        // {
        //     var dstPath = CodeArchive.HexPath(FileName.define($"{caller}", FileExtensions.HexLine));
        //     return Archives.writer<MemberCodeWriter>(dstPath);
        // }

        // protected AsmWriter AsmWriter([Caller] string caller = null)
        // {
        //     var dst = CodeArchive.AsmPath(FileName.define($"{caller}", FileExtensions.Asm));
        //     var format = AsmFormatSpec.WithFunctionTimestamp;
        //     return AsmCore.Services.AsmWriter(dst,format);
        // }
    }
}