//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Reflection;
    
    using static Seed;
    using static Memories;
    using static BufferSeqId;

    using K = Kinds;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public class AsmChecks : ITestAsm
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

        ICheckVectors Claim => CheckVectors.Checker;

        ITestAsm Me => this;

        ICaptureArchive CodeArchive => Me.CaptureArchive(ExecutingApp);

        protected IUriCodeWriter HexWriter([Caller] string caller = null)
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
                
        IAsmFunctionDecoder Decoder => Context.Decoder;

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => gvec.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        void capture_shuffler()
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);

            using var hexout = HexWriter();
            using var asmout = AsmWriter();         
    
            var fCaptured = Me.Capture(f.Identify(), f).Require();
            hexout.Write(fCaptured.HostedBits);
            asmout.WriteAsm(Decoder.Decode(fCaptured).Require());

            var gCaptured = Me.Capture(g.Identify(), g).Require();
            hexout.Write(gCaptured.HostedBits);
            asmout.WriteAsm(Decoder.Decode(gCaptured).Require());
        }

        static K.BinaryOpClass Binary => default;

        TestCaseRecord TestVectorMatch(BufferTokens dst, string name, TypeWidth w, NumericKind kind)
        {
            var dId = Identify.Op(name, w, kind, false);
            var gId = Identify.Op(name, w, kind, true);            
            var archive = UriHexArchive.Create(CodeArchive.CodeDir);
            var dBits = archive.Read(ApiHost.Create<dvec>().UriPath).Where(x => x.Id == dId).Single();
            var gBits = archive.Read(ApiHost.Create<gvec>().UriPath).Where(x => x.Id == gId).Single();
            return Me.Match(Binary, w, dBits, gBits, dst);
        }

        public TestCaseRecord[] vector_bitlogic_match(BufferTokens buffers)
        {
            var names = array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(TypeWidth.W128, TypeWidth.W256);
            var dst = new TestCaseRecord[names.Length * widths.Length * kinds.Count];
            var i = 0;
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                dst[i++] =TestVectorMatch(buffers, n, w, k);                        
            return dst;
        }
    }
}