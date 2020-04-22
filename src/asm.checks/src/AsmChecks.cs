//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.IO;
    using System.Reflection;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Asm;

    using static Seed;
    using static Memories;
    using static time;
    using static BufferSeqId;

    using K = Kinds;
    
    public interface ITestCapture : ITester
    {
        TestCaseRecord TestImm<T>(in CaptureExchange exchange, BufferToken buffer, W256 w, K.BinaryOpClass k, MethodInfo src, byte imm)
            where T : unmanaged;        
    }

    public class AsmChecks : ITestDynamic, ITestCapture
    {
        public IAsmContext Context {get;}
                
        readonly int RepCount;

        public static AsmChecks Create(IAsmContext context)
            => new AsmChecks(context);

        AsmChecks(IAsmContext context)
        {
            this.Context = context;
            this.RepCount = 128;
        }                

        public IPolyrand Random => Context.Random;

        public ICheck Check => ICheck.Checker;

        ICheck Claim => ICheck.Checker;

        public IDynamicOps Dynamic => Context.Dynamic;

        ITestDynamic Me => this;

        ICaptureArchive CodeArchive 
            => Context.CaptureArchive(
                Env.Current.LogDir + FolderName.Define("test"), 
                FolderName.Define("data"), 
                FolderName.Define(GetType().Name)
                );

        public TestCaseRecord TestImm<T>(in CaptureExchange exchange, BufferToken buffer, W256 w, K.BinaryOpClass k, MethodInfo src, byte imm)
            where T : unmanaged
        {            
            var label = Checks.CaseName<T>(src.Name);

            void check(in CaptureExchange xchange)
            {
                var injector = Dynamic.BinaryInjector<T>(w);
                var f = injector.EmbedImmediate(src, imm);

                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);            
                var v1 = f.DynamicOp.Invoke(x,y);
                
                var asm = CaptureAsm(xchange, f).Require();
                var h = Dynamic.EmitFixedBinary(buffer, w, asm.Code);
                var v2 = h(x.ToFixed(),y.ToFixed()).ToVector<T>();
                Claim.veq(v1,v2);
            }

            var clock = time.counter(true);

            try
            {
                check(exchange);
                return TestCaseRecord.Define(label, true, clock);
            }
            catch(Exception e)
            {
                term.errlabel(e, label);
                return TestCaseRecord.Define(label, false, clock);
            }                                    
        }

        protected IBitArchiveWriter HexWriter([Caller] string caller = null)
        {            
            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.Hex));
            return Context.BitArchiveWriter(dstPath);
        }

        protected IAsmFunctionWriter AsmWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            var format = AsmFormatConfig.New.WithFunctionTimestamp();
            return Context.AsmWriter(dst,format);
        }

        static K.UnaryOpClass Unary => default;

        static K.BinaryOpClass Binary => default;

        static K.TernaryOpClass Ternary => default;
        
        ICaptureService Capture => Context.CaptureService;

        ICaptureControl CaptureControl => Context.CaptureControl;

        IAsmFunctionDecoder Decoder => Context.Decoder;

        IAsmFormatter Formatter => Context.Formatter;

        ITestDynamic Checks => this;

        CaptureExchange Exchange(in BufferSeq buffers)   
            => CaptureExchange.Create(CaptureControl, buffers[Left], buffers[Right]);     

        Option<AsmFunction> CaptureAsm<D>(in CaptureExchange exchange, DynamicDelegate<D> src)
            where D : Delegate
                => from capture in Capture.Capture(exchange, src.Id, src)
                from asm in Decoder.Decode(capture)
                select asm;

        public TestCaseRecord TestMatch<T>(in BufferSeq buffers, BinaryOp<T> f, in IdentifiedCode src)
            where T : unmanaged
        {                                  
            var g = Dynamic.EmitBinaryOp<T>(buffers[Main],src);
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return Checks.TestAction(check, src.Id);
        }

        protected IdentifiedCode ReadAsm(PartId id, ApiHostUri host, OpIdentity m)
            => Context.HostBits(id,host).Read(m).Single().ToApiCode();

        public ITestFixedMatch TestFixed => this;

        IEnumerable<string> PrimalBitLogicOps
            => seq("and", "or", "xor", "nand", "nor", "xnor",
                "impl","nonimpl", "cimpl", "cnonimpl");

        // void bitlogic_match(in BufferSeq buffers)
        // {
        //     var names = PrimalBitLogicOps;
        //     var kinds = NumericKind.Integers.DistinctKinds();
        //     var widths = array(TypeWidth.W8, TypeWidth.W16, TypeWidth.W32, TypeWidth.W64);
        //     foreach(var n in names)
        //     foreach(var w in widths)
        //     foreach(var k in kinds)
        //         TestPrimalMatch(buffers, n, w, k);                        
        // }

        IHostBitsArchive HostBits(ApiHostUri host)
            => Context.HostBits(host.Owner, host);

        // TestCaseRecord TestPrimalMatch(in BufferSeq buffers, string name, TypeWidth w, NumericKind kind)
        // {
        //     var catalog = PartId.GMath;
        //     var dSrc = ApiHostUri.FromHost(typeof(math));
        //     var gSrc = ApiHostUri.FromHost(typeof(gmath));

        //     var dId = Identify.Op(name, kind, false);
        //     var gId = Identify.Op(name, kind, true);

        //     var dArchive = Context.HostBits(catalog, dSrc);
        //     var gArchive = Context.HostBits(catalog, gSrc);

        //     var d = dArchive.Read(dId).Single().ToApiCode();
        //     var g = gArchive.Read(gId).Single().ToApiCode();

        //     return TestMatch(buffers, Binary, w,d,g);
        // }

        void capture_constants(in BufferSeq buffers)
        {
            var src = typeof(gmath).Method(nameof(BitMask.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
                
            var exchange = CaptureExchange.Create(CaptureControl, buffers[Left], buffers[Right]);
            var captured = Capture.Capture(exchange, src.Identify(), src).Require();
            
            using var hexout = HexWriter();
            using var asmout = AsmWriter();            
            
            hexout.WriteCode(captured.Code);
            asmout.Write(Decoder.Decode(captured).Require());
        }

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => gvec.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        void capture_shuffler(in BufferSeq buffers)
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);

            using var hexout = HexWriter();
            using var asmout = AsmWriter();         
    
            var exchange = CaptureExchange.Create(CaptureControl, buffers[Left], buffers[Right]);

            var fCaptured = Capture.Capture(exchange, f.Identify(), f).Require();
            hexout.WriteCode(fCaptured.Code);
            asmout.Write(Decoder.Decode(fCaptured).Require());

            var gCaptured = Capture.Capture(exchange, g.Identify(), g).Require();
            hexout.WriteCode(gCaptured.Code);
            asmout.Write(Decoder.Decode(gCaptured).Require());
        }
                
        void binary_imm(in BufferSeq buffers, MethodInfo method)
        {
            var w = w256;
            var name = nameof(dvec.vblend8x16);
            var imm = (byte)Blend8x16.LRLRLRLR;

            var injector = Dynamic.BinaryInjector<ushort>(w);
            var x = Random.CpuVector<ushort>(w);
            var y = Random.CpuVector<ushort>(w);
            
            var exchange = CaptureExchange.Create(CaptureControl, buffers[Left], buffers[Right]);

            var f = injector.EmbedImmediate(method,imm);
            var v1 = f.DynamicOp.Invoke(x,y);
            var captured = Capture.Capture(exchange, f.Id, f).Require();
            var asm = Decoder.Decode(captured).Require();        

            

            var g = buffers[Main].EmitFixedBinaryOp<Fixed256>(asm.Code);
            var v2 = g(x,y).ToVector<ushort>();
            Claim.veq(v1,v2);
        }

        // void CheckImm(in BufferSeq buffers, in CaptureExchange exchange)
        // {
        //     CheckBinaryImm<uint>(buffers, exchange, w128, nameof(dvec.vblend4x32), (byte)Blend4x32.LRLR);    
        //     CheckBinaryImm<uint>(buffers, exchange, w128, nameof(dvec.vblend8x32), (byte)Blend8x32.LRLRLRLR);    
        //     CheckUnaryImm<ushort>(buffers, exchange, w256, nameof(dvec.vbsll), 3);        
        // }

        public void CheckBinaryImm<T>(in BufferSeq buffers, in CaptureExchange exchange, W128 w, MethodInfo method, byte imm)
            where T : unmanaged
        {            
            var injector = Dynamic.BinaryInjector<T>(w);

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            var capture = Context.Capture();
            var decoder = Context.AsmFunctionDecoder();

            var dynop = injector.EmbedImmediate(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            var captured = capture.Capture(exchange, dynop.Id, dynop.DynamicOp).Require();            
            var asm = decoder.Decode(captured).Require();

            var f = buffers[Main].EmitFixedBinaryOp<Fixed128>(asm.Code);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.veq(z1,z2);
        }
        
        public void CheckUnaryImm<T>(in BufferSeq buffers, in CaptureExchange exchange, W256 w, MethodInfo method, byte imm)
            where T : unmanaged
        {            
            var k = Unary;
            var injector = Dynamic.UnaryInjector<T>(w);                        
            var dynop = injector.EmbedImmediate(method,imm);

            var x = Random.CpuVector<T>(w);
            var v1 = dynop.DynamicOp.Invoke(x);
            
            var capture = Capture.Capture(exchange, dynop.Id, dynop).Require();            
            var asm = Decoder.Decode(capture).Require();

            var f = Dynamic.EmitFixedUnary<Fixed256>(buffers[Main], capture.Code);
            var v2 = f(x.ToFixed()).ToVector<T>();
            Claim.veq(v1,v2);
        }

        TestCaseRecord TestVectorMatch(in BufferSeq buffers, string name, TypeWidth w, NumericKind kind)
        {
            var catalog = PartId.GVec;
            
            var idD = Identify.Op(name, w, kind, false);
            var idG = Identify.Op(name, w, kind, true);

            var d = Context.HostBits(catalog, ApiHost.Create<dvec>().UriPath).Read(idD).Single();
            var g = Context.HostBits(catalog, ApiHost.Create<gvec>().UriPath).Read(idG).Single();

            return Me.Match(buffers, Binary, w,d,g);
        }

        public TestCaseRecord[] vector_bitlogic_match(in BufferSeq buffers)
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


        void datares_check(in BufferSeq buffers)
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Data.Resources)
                Claim.eq(d.Location, ptr(d.GetBytes()));
        }

 
        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        void capture_shifter(in BufferSeq buffers)
        {
            var src = shifter(4);

            using var hexout = HexWriter();
            using var asmout = AsmWriter();            

            var captured = Capture.Capture(Context.CaptureExchange(), src.Identify(), src);
            var decoded = captured.OnSome(c => Decoder.Decode(c));                    
        }


        static int activations;
        
        static void OnMnemonid(Instruction i)
        {            
            activations++;
        }

        static int listcount = 0;
        
        static AsmInstructionList Pipe(AsmInstructionList src)
        {        
            listcount++;
            return src;
        }

        [MethodImpl(Inline)]
        static unsafe ulong ptr(ReadOnlySpan<byte> src)
            => (ulong)Unsafe.AsPointer(ref Unsafe.AsRef(in head(src)));

        void RunPipe()
        {
            var archive =  Context.HostBits(PartId.GVec);
            var source = archive.ToInstructionSource(Context);
            var trigger = AsmMnemonicTrigger.Define(Mnemonic.Vinserti128, OnMnemonid);
            var triggers = AsmTriggerSet.Define(trigger);
            var flow =  Context.InstructionFlow(source, triggers);
            var pipe = AsmInstructionPipe.From(Pipe); 
            var results = flow.Flow(pipe).Force();

            var count = 0;
            foreach(var result in results)
            {
                foreach(var i in result)
                {
                    if(trigger.CanFire(i))
                        count++;
                }
            }            
        }

        void Run50(in BufferSeq buffers)
        {
            var dSrc = ApiHostUri.FromHost(typeof(math));
            var gSrc = ApiHostUri.FromHost(typeof(gmath));

            var id = PartId.GMath;
            var direct = Context.HostBits(id, dSrc);
            var generic = Context.HostBits(id, gSrc);

            foreach(var a in direct.Read().WithParameterCount(1))
            {                
                var code = a.ToApiCode();
                if(a.AcceptsParameter(NumericKind.U8))
                    Me.CheckFixedMatch<Fixed8>(buffers, Unary, code, code);
                else if(a.AcceptsParameter(NumericKind.U16))
                    Me.CheckFixedMatch<Fixed16>(buffers, Unary, code,code);
                else if(a.AcceptsParameter(NumericKind.U32))
                    Me.CheckFixedMatch<Fixed32>(buffers, Unary, code, code);
                else if(a.AcceptsParameter(NumericKind.U64))
                    Me.CheckFixedMatch<Fixed64>(buffers, Unary, code, code);
            }
        }


    #if Megacheck

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, BinaryOp<byte> primal, BinaryOp<byte> generic, NK<byte> kind)
        {
            var results = list<TestCaseRecord>();
            var w = w8;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w,ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, BinaryOp<sbyte> primal, BinaryOp<sbyte> generic, 
            NK<sbyte> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w8;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, in IdentifiedCode dCode, in IdentifiedCode gCode, 
            BinaryOp<sbyte> primal, BinaryOp<sbyte> generic, NK<sbyte> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w8;

            var id = Identify.NumericOp(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, dCode);
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, gCode);
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<ushort> primal, BinaryOp<ushort> generic, NK<ushort> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w16;

            var id = Identify.NumericOp(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<short> primal, BinaryOp<short> generic, NK<short> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w16;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<uint> primal, BinaryOp<uint> generic, NK<uint> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w32;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<int> primal, BinaryOp<int> generic, NK<int> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w32;
            var id = Identify.NumericOp(name, kind, false);

            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<long> primal, BinaryOp<long> generic, NK<long> kind)
        {            
            var results = list<TestCaseRecord>();

            var w = w64;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<ulong> primal, BinaryOp<ulong> generic, U64 kind)
        {            
            var results = list<TestCaseRecord>();

            var w = w64;
            var id = Identify.Op(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        public void add_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.add);

            var dSrc = ApiHostUri.FromHost(typeof(math));
            var gSrc = ApiHostUri.FromHost(typeof(gmath));

            var dArchive = Context.HostBitsArchive(PartId.GMath, dSrc);
            var gArchive = Context.HostBitsArchive(PartId.GMath, gSrc);
            var dAdd = dArchive.Read("add").Select(x => x.ToApiCode()).ToArray();
            var gAdd = gArchive.Read("add_g").Select(code => code.WithIdentity(code.Id.WithoutGeneric()).ToApiCode()).ToArray();
            Claim.eq(dAdd.Length, gAdd.Length);
            for(var i=0; i< dAdd.Length; i++)
            {
                var d = dAdd[i];
                var g = gAdd[i];
                var opname = d.Id;
                switch(opname)
                {
                    case "add_8i_8i":
                        megacheck(buffers, name, d, g, math.add, gmath.add, i8);
                    break;                       
                }                
            }
        }

        public void sub_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.sub);
            megacheck(buffers, name, math.sub, gmath.sub, u8);              
            megacheck(buffers, name, math.sub, gmath.sub, i8);              
            megacheck(buffers, name, math.sub, gmath.sub, u16);              
            megacheck(buffers, name, math.sub, gmath.sub, i16);              
            megacheck(buffers, name, math.sub, gmath.sub, u32);            
            megacheck(buffers, name, math.sub, gmath.sub, i32);            
            megacheck(buffers, name, math.sub, gmath.sub, u64);            
            megacheck(buffers, name, math.sub, gmath.sub, i64);            
        }

        void mul_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.mul);
            megacheck(buffers, name, math.mul, gmath.mul, u8);              
            megacheck(buffers, name, math.mul, gmath.mul, i8);              
            megacheck(buffers, name, math.mul, gmath.mul, u16);              
            megacheck(buffers, name, math.mul, gmath.mul, i16);              
            megacheck(buffers, name, math.mul, gmath.mul, u32);            
            megacheck(buffers, name, math.mul, gmath.mul, i32);            
            megacheck(buffers, name, math.mul, gmath.mul, u64);            
            megacheck(buffers, name, math.mul, gmath.mul, i64);            
        }

        public void and_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.and);
            megacheck(buffers, name, math.and, gmath.and, u8);              
            megacheck(buffers, name, math.and, gmath.and, i8);              
            megacheck(buffers, name, math.and, gmath.and, u16);              
            megacheck(buffers, name, math.and, gmath.and, i16);              
            megacheck(buffers, name, math.and, gmath.and, u32);            
            megacheck(buffers, name, math.and, gmath.and, i32);            
            megacheck(buffers, name, math.and, gmath.and, u64);            
            megacheck(buffers, name, math.and, gmath.and, i64);            
        }

        public void xor_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.xor);
            megacheck(buffers, name, math.xor, gmath.xor, u8);              
            megacheck(buffers, name, math.xor, gmath.xor, i8);              
            megacheck(buffers, name, math.xor, gmath.xor, u16);              
            megacheck(buffers, name, math.xor, gmath.xor, i16);              
            megacheck(buffers, name, math.xor, gmath.xor, u32);            
            megacheck(buffers, name, math.xor, gmath.xor, i32);            
            megacheck(buffers, name, math.xor, gmath.xor, u64);            
            megacheck(buffers, name, math.xor, gmath.xor, i64);            
        }

        public void nand_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.nand);
            megacheck(buffers, name, math.nand, gmath.nand, u8);              
            megacheck(buffers, name, math.nand, gmath.nand, i8);              
            megacheck(buffers, name, math.nand, gmath.nand, u16);              
            megacheck(buffers, name, math.nand, gmath.nand, i16);              
            megacheck(buffers, name, math.nand, gmath.nand, u32);            
            megacheck(buffers, name, math.nand, gmath.nand, i32);            
            megacheck(buffers, name, math.nand, gmath.nand, u64);            
            megacheck(buffers, name, math.nand, gmath.nand, i64);            
        }


        public void xnor_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.xnor);
            megacheck(buffers, name, math.xnor, gmath.xnor, u8);              
            megacheck(buffers, name, math.xnor, gmath.xnor, i8);              
            megacheck(buffers, name, math.xnor, gmath.xnor, u16);              
            megacheck(buffers, name, math.xnor, gmath.xnor, i16);              
            megacheck(buffers, name, math.xnor, gmath.xnor, u32);            
            megacheck(buffers, name, math.xnor, gmath.xnor, i32);            
            megacheck(buffers, name, math.xnor, gmath.xnor, u64);            
            megacheck(buffers, name, math.xnor, gmath.xnor, i64);            
        }


    #endif
    }
}