//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.AsmSpecs;

    using static zfunc;

    class t_asm_main : t_asm_explicit<t_asm_main>
    {

        protected override void OnExecute(in AsmBuffers buffers)
        {                    
            // buffer_client(Context);
            // capture_shifter(buffers);
            // capture_shuffler(buffers);
            // capture_constants(buffers);
            // binary_imm(buffers);
            //archive_selected(buffers);        
            //archive_context(buffers);            
            //iter(hosts, EncodingParser.Parse);            

            // const string uritext = "hex://logix/LogicEngine?eval#eval_vcmp_expr128_g[8u]()";
            // var uri = OpUri.Parse(uritext);
            // print(uri);

                    
            var workflow = Context.CaptureWorkflow();
            workflow.Execute().Force();
        }

        static void buffer_client(IAsmContext context)
        {
            var state = new List<CaptureState>();
            var f = typeof(gmath).Method(nameof(gmath.alteven))
                                 .MapRequired(m => m.GetGenericMethodDefinition()
                                 .MakeGenericMethod(typeof(byte)));

            var decoder = context.Decoder(); 

            using var rawout = RawTestWriter(context);            
            using var hexout = HexTestWriter(context);
            using var asmout = AsmTestWriter(context);            
                        
            void OnExecute(in AsmBuffers buffers)
            {            
                var capture = context.Capture(buffers.Capture);
                var captured = capture.Capture(buffers.Exchange, f);
                hexout.Write(captured);
                rawout.Write(captured);
                asmout.Write(decoder.DecodeFunction(captured));
                Claim.eq(captured.RawBits.Length, state.Count);
            }

            void OnCaptureEvent(in CaptureEventData data)
            {
                if(data.EventKind != CaptureEventKind.Complete)
                {
                    print($"{data.CaptureState}", SeverityLevel.HiliteBL);
                    state.Add(data.CaptureState);
                }
            }

            var composition = context.BufferedClient(OnExecute);
            using var buffers = context.Buffers(OnCaptureEvent);
            composition.Execute(buffers);

            var stateBytes = state.Select(s => s.Payload).ToArray();
        }

        void archive_selected(in AsmBuffers buffers)
        {
            var archive = Context.Archiver();
            archive.Archive(AssemblyId.Root);
        }

        void archive_context(in AsmBuffers buffers)
        {
            var archive = Context.Archiver();
            var selection = from c in Context.Compostion.Catalogs
                            where !c.IsEmpty && c.AssemblyId != AssemblyId.Data
                            orderby c.AssemblyId
                            select c.AssemblyId;
            foreach(var id in selection)
                archive.Archive(id);    
        }

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => ginx.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        AsmFormatConfig AsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        void capture_constants(in AsmBuffers buffers)
        {
            var src = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));

            using var rawout = RawTestWriter(Context);            
            using var hexout = HexTestWriter(Context);
            using var asmout = AsmTestWriter(Context);            
            
            var decoder = Context.Decoder();         
            var capture = Context.Capture(buffers.Capture);
            
            var data = capture.Capture(buffers.Exchange, src);        
            hexout.Write(data);
            rawout.Write(data);
            asmout.Write(decoder.DecodeFunction(data));
        }

        void capture_shifter(in AsmBuffers buffers)
        {
            var src = shifter(4);

            using var rawout = RawTestWriter(Context);            
            using var hexout = HexTestWriter(Context);
            using var asmout = AsmTestWriter(Context);            

            var capture = Context.Capture(buffers.Capture);
            var decoder = Context.Decoder();         
            
            var data = capture.Capture(buffers.Exchange, src.Identify(), src);
            hexout.Write(data);
            rawout.Write(data);
            asmout.Write(decoder.DecodeFunction(data));
            
        }

        void capture_shuffler(in AsmBuffers buffers)
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);

            using var rawout = RawTestWriter(Context);            
            using var hexout = HexTestWriter(Context);
            using var asmout = AsmTestWriter(Context);            

            var capture = Context.Capture(buffers.Capture);
            var decoder = Context.Decoder();         

            var fData = capture.Capture(buffers.Exchange, f.Identify(), f);
            hexout.Write(fData);
            rawout.Write(fData);
            asmout.Write(decoder.DecodeFunction(fData));

            var gData = capture.Capture(buffers.Exchange, g.Identify(), g);
            hexout.Write(gData);
            rawout.Write(fData);
            asmout.Write(decoder.DecodeFunction(gData));
        }

        void binary_imm(in AsmBuffers buffers)
        {
            var w = n256;
            var name = nameof(dinx.vblend8x16);
            var imm = (byte)Blend8x16.LRLRLRLR;

            var provider = ImmOpProviders.provider(VK.vk256<ushort>(),FK.op(n2));
            var x = Random.CpuVector<ushort>(w);
            var y = Random.CpuVector<ushort>(w);
            
            var method = Intrinsics.Vectorized<ushort>(w, false, name).Single();            
            var dynop = provider.CreateOp(method,imm);
            var f = dynop.DynamicOp;
            var z1 = f.Invoke(x,y);
            var decoder = Context.Decoder(false);
            var captured = CaptureServices.Operations.Capture(buffers.Exchange, dynop.Id, dynop);
            var asm = decoder.DecodeFunction(captured);        

            iter(asm.Instructions, i => Trace(i));  

            var g = buffers.MainExec.BinaryOp<Fixed256>(asm.Code);
            var z3 = g(x,y).ToVector<ushort>();
            Claim.eq(z1,z3);
        }


        IEnumerable<string> PrimalBitLogicOps
            => items("and", "or", "xor", "nand", "nor", "xnor",
                "impl","nonimpl", "cimpl", "cnonimpl");

        void bitlogic_match(in AsmBuffers buffers)
        {
            var names = PrimalBitLogicOps;
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(FixedWidth.W8, FixedWidth.W16, FixedWidth.W32, FixedWidth.W64);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                primal_match(buffers, n, w, k);                        
        }

        void primal_match(in AsmBuffers buffers, string name, FixedWidth w, NumericKind kind)
        {
            var catalog = AssemblyId.GMath;
            var dSrc = nameof(math);
            var gSrc = nameof(gmath);

            var dId = OpId.numeric(name, kind, false);
            var gId = OpId.numeric(name, kind, true);

            var dArchive = Context.CodeArchive(catalog, dSrc);
            var gArchive = Context.CodeArchive(catalog, gSrc);

            var d = dArchive.Read(dId).Single();
            var g = gArchive.Read(gId).Single();

            Claim.yea(binop_match(buffers, w,d,g));                                     
        }

        bit binop_match(in AsmBuffers buffers, FixedWidth w, AsmCode a, AsmCode b)
        {
            switch(w)
            {
                case FixedWidth.W8:
                    binop_match(buffers, n8,a,b);
                    break;

                case FixedWidth.W16:
                    binop_match(buffers, n16,a,b);
                    break;

                case FixedWidth.W32:
                    binop_match(buffers, n32,a,b);
                    break;

                case FixedWidth.W64:
                    binop_match(buffers, n64,a,b);
                    break;

                case FixedWidth.W128:
                    binop_match(buffers, n128,a,b);
                    break;

                case FixedWidth.W256:
                    binop_match(buffers, n256, a, b);
                    break;

                default:
                    Claim.fail();
                break;
            }
            return bit.On;
        }

        protected void binop_match(in AsmBuffers buffers, N8 w, AsmCode a, AsmCode b)
        {
            var f = buffers.LeftExec.BinaryOp(w, a);
            var g = buffers.RightExec.BinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in AsmBuffers buffers, N16 w, AsmCode a, AsmCode b)
        {
            var f = buffers.LeftExec.BinaryOp(w, a);
            var g = buffers.RightExec.BinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in AsmBuffers buffers, N32 w, AsmCode a, AsmCode b)
        {
            var f = buffers.LeftExec.BinaryOp(w, a);
            var g = buffers.RightExec.BinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in AsmBuffers buffers, N64 w, AsmCode a, AsmCode b)
        {
            var f = buffers.LeftExec.BinaryOp(w, a);
            var g = buffers.RightExec.BinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in AsmBuffers buffers, N128 w, AsmCode a, AsmCode b)
        {
            var f = buffers.LeftExec.BinaryOp(w, a);
            var g = buffers.RightExec.BinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in AsmBuffers buffers, N256 w, AsmCode a, AsmCode b)
        {
            var f = buffers.LeftExec.BinaryOp(w, a);
            var g = buffers.RightExec.BinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }
    }
}
