//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Konst;
    using static BufferSeqId;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public class AsmChecks : TTestAsm
    {
        public IAsmContext Context {get;}

        public BufferTokens Buffers {get;}

        readonly BufferAllocation BufferAlloc;

        public ICaptureExchange CaptureExchange {get;}

        internal AsmChecks(IAsmContext context)
        {
            Context = context;
            Buffers = Z0.Buffers.sequence(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureCore, Buffers[Aux3]);
        }

        public void Dispose()
        {
            BufferAlloc.Dispose();
        }

        TTestAsm Me => this;

        public ref readonly BufferToken this[BufferSeqId index]
            => ref Buffers[index];

        IPartCaptureArchive CodeArchive
            => Me.CaptureArchive(Part.ExecutingPart);

        protected IFileStreamWriter HexWriter([Caller] string caller = null)
        {
            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.HexLine));
            return Archives.Services.MemberCodeWriter(dstPath);
        }

        protected AsmWriter AsmWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            var format = AsmFormatSpec.WithFunctionTimestamp;
            return AsmCore.Services.AsmWriter(dst,format);
        }
    }
}