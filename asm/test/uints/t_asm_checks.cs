//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static HK;
    using AsmSpecs;

    public class t_asm_checks : t_asm<t_asm_checks>, IExplicitTest
    {           
        public void Execute()
        {

        }

        void CheckImm(in AsmBuffers buffers)
        {
            CheckBinaryImm<uint>(buffers, n128, nameof(dinx.vblend4x32), (byte)Blend4x32.LRLR);    
            CheckBinaryImm<uint>(buffers, n128, nameof(dinx.vblend8x32), (byte)Blend8x32.LRLRLRLR);    
            CheckUnaryImm<ushort>(buffers, n256, nameof(dinx.vbsll), 3);        
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

        AsmFormatConfig AsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        public void CheckCapture(in AsmBuffers buffers)
        {
            var name = nameof(ginx.vcimpl);         
            var width = n256;                        
            var args = NumericKind.Integers.DistinctKinds().Map(arg => arg.ToClrType().Require());
            var generic = Intrinsics.VectorizedGeneric(width,name).CloseGenericMethods(args);
            var direct = Intrinsics.VectorizedDirect(width,name);
            var selected = direct.Union(generic).ToArray();            
            var path = Capture(buffers, selected,name);
            var hex = Context.CodeReader().Read(path);
            
            var hexD = hex.Where(h => !h.Id.IsGeneric).ToDictionary(x => x.Id);
            var hexG = hex.Where(h => h.Id.IsGeneric).ToDictionary(x => x.Id);
                                        
            foreach(var k in hexG.Keys)
            {
                var gHex = hexG[k];
                var dHex = hexD[k.WithoutGeneric()];
                var pairing = pair(gHex, dHex);

                var gcell = from seg in gHex.Id.Segment(1)
                            let t = seg.SegKind
                            select t;
                var dcell = from seg in dHex.Id.Segment(1)
                            let t = seg.SegKind
                            select t;

                var dseg = dHex.Id.Segment(1);
                //Trace($"{gcell} :: {dcell}");
            }
            
        }

        FilePath Capture(in AsmBuffers buffers, MethodInfo[] methods, string subject)
        {
            using var hex = HexTestWriter(subject);
            using var asm = AsmTestWriter(subject);

            var capture = Context.Capture(buffers.Capture);
            
            capture.CaptureBits(buffers.Exchange, methods,hex);
            capture.CaptureAsm(buffers.Exchange, methods,asm);
            return hex.TargetPath;            
        }

        FilePath Capture(in AsmBuffers buffers, MethodInfo[] defs, Type[] args, string subject)
        {
            using var hex = HexTestWriter(subject);
            using var asm = AsmTestWriter(subject);

            var capture = Context.Capture(buffers.Capture);
                                    
            var selection = from def in defs
                            from arg in args                            
                            select def.MakeGenericMethod(arg);
            var selected = selection.ToArray();
            
            capture.CaptureBits(buffers.Exchange, selected,hex);
            capture.CaptureAsm(buffers.Exchange, selected,asm);
            return hex.TargetPath;            
        }

        void RunPipe(in AsmBuffers buffers)
        {
            var archive =  Context.CodeArchive(AssemblyId.Intrinsics);
            var source = archive.ToInstructionSource();
            var trigger = AsmMnemonicTrigger.Define(Mnemonic.Vinserti128, OnMnemonid);
            var triggers = AsmTriggerSet.Define(trigger);
            var flow =  Context.Flow(source, triggers);
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
            
            TraceCaller($"{listcount} instruction lists were processed out of {source.Instructions.Count()} available");
            TraceCaller($"Trigger activate {activations} times");
        }

        void CheckBinaryImm(in AsmBuffers buffers)
        {
            var w = n256;
            var name = nameof(dinx.vblend8x16);
            var imm = (byte)Blend8x16.LRLRLRLR;

            var provider = ImmOpProviders.provider(HK.vk256<ushort>(),HK.opfk(n2));
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

        void CheckBinaryImm<T>(in AsmBuffers buffers, N128 w, string name, byte imm)
            where T : unmanaged
        {            
            var provider = ImmOpProviders.provider(HK.vk128<T>(), HK.opfk(n2));

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var dynop = provider.CreateOp(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            var decoder = Context.Decoder(false);
            var captured = CaptureServices.Operations.Capture(buffers.Exchange, dynop.Id, dynop);            
            var asm = decoder.DecodeFunction(captured);

            Trace(asm.Id);
            iter(asm.Instructions, i => Trace(i));  

            var f = buffers.MainExec.BinaryOp<Fixed128>(asm.Code);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.eq(z1,z2);
        }

        void CheckBinaryImm<T>(in CaptureExchange exchange, ExecBufferToken buffer, N256 w, string name, byte imm)
            where T : unmanaged
        {            
            var provider = ImmOpProviders.provider<T>(HK.vk256<T>(), HK.opfk(n2));

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var dynop = provider.CreateOp(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            
            var decoder = Context.Decoder(false);
            var captured = CaptureServices.Operations.Capture(in exchange, dynop.Id, dynop);            
            var asm = decoder.DecodeFunction(captured);

            Trace(asm.Id);
            iter(asm.Instructions, i => Trace(i));  

            var f = buffer.BinaryOp<Fixed256>(asm.Code);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.eq(z1,z2);
        }

        void CheckUnaryImm<T>(in AsmBuffers buffers, N256 w, string name, byte imm)
            where T : unmanaged
        {            
            var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var provider = ImmOpProviders.provider<T>(HK.vk256<T>(), HK.opfk(n1));

            
            var dynop = provider.CreateOp(method,imm);

            var x = Random.CpuVector<T>(w);
            var z1 = dynop.DynamicOp.Invoke(x);
            
            var decoder = Context.Decoder(false);
            var capture = CaptureServices.Operations.Capture(in buffers.Exchange, dynop.Id, dynop);            
            var asm = decoder.DecodeFunction(capture);

            Trace(asm.Id);
            iter(asm.Instructions, i => Trace(i));  

            var f = buffers.MainExec.UnaryOp<Fixed256>(capture.Code);
            var z2 = f(x.ToFixed()).ToVector<T>();
            Claim.eq(z1,z2);
        }


        void Run50(in AsmBuffers buffers)
        {
            var id = AssemblyId.GMath;
            var direct = Context.CodeArchive(id, nameof(math));
            var generic = Context.CodeArchive(id, nameof(gmath));

            foreach(var a in direct.Read().Where(asm => asm.ParameterCount() == 1))
            {                
                if(a.AcceptsParameter(NumericKind.U8))
                {
                    var af = a.ToFixed<Fixed8>();
                    var bf = a.ToFixed<Fixed8>();
                    CheckUnaryOp(buffers, af, bf);
                }
                if(a.AcceptsParameter(NumericKind.U32))
                {
                    var af = a.ToFixed<Fixed32>();
                    var bf = a.ToFixed<Fixed32>();
                    CheckUnaryOp(buffers, af, bf);
                }
                else if(a.AcceptsParameter(NumericKind.U64))
                {
                    var af = a.ToFixed<Fixed64>();
                    var bf = a.ToFixed<Fixed64>();
                    CheckUnaryOp(buffers, af, bf);
                }

            }

        }


        void CheckUnaryOp<T>(in AsmBuffers buffers, AsmCode src, Func<T,T> f)
            where T : unmanaged, IFixed

        {            
            TraceCaller($"Checking {src.Id}");
            var g = (FixedFunc<T,T>)buffers.MainExec.Load(src).UnaryOp(src.Id, typeof(FixedFunc<T,T>),typeof(T));
            var points = Random.Fixed<T>().Take(RepCount);
            iter(points, x => Claim.eq(f(x), g(x)));            
            
        }   
        
        void CheckUnaryOp<T>(in AsmBuffers buffers, in FixedAsm<T> a, in FixedAsm<T> b)
            where T : unmanaged, IFixed
        {            
            TraceCaller($"Checking {a.Id} == {b.Id} match");
            
            var f = (FixedFunc<T,T>)buffers.LeftExec.Load(a.Code).UnaryOp(a.Id, typeof(FixedFunc<T,T>),typeof(T));
            var g = (FixedFunc<T,T>)buffers.RightExec.Load(b.Code).UnaryOp(b.Id, typeof(FixedFunc<T,T>),typeof(T));

            var stream = Random.Fixed<T>();
            if(stream == null)
                Claim.fail($"random stream null!");

            var points = stream.Take(RepCount);
            iter(points, x => Claim.eq(f(x), g(x)));            

        }

        void CheckUnaryFunc(in AsmBuffers buffers, AsmCode src)
        {            
            var nk =  NumericType.parseKind(src.Id.TextComponents.Second()).Require();
            switch(nk)
            {
                case NumericKind.I8:
                    var f8i = buffers.MainExec.UnaryOp<Fixed8>(src);
                    Trace((sbyte)f8i((sbyte) -9));
                    break;
                case NumericKind.U8:
                    var f8u = buffers.MainExec.UnaryOp<Fixed8>(src);
                    Trace(f8u((byte) 7));
                    break;
                case NumericKind.I16:
                    var f16i = buffers.MainExec.UnaryOp<Fixed16>(src);
                    Trace((short)f16i((short) -17));
                    break;
                case NumericKind.U16:
                    var f16u = buffers.MainExec.UnaryOp<Fixed16>(src);
                    Trace(f16u((ushort) 15));
                    break;                    
                case NumericKind.I32:
                    var f32i = buffers.MainExec.UnaryOp<Fixed32>(src);
                    Trace((int)f32i((int) -33));
                    break;
                case NumericKind.U32:
                    var f32u = buffers.MainExec.UnaryOp<Fixed32>(src);
                    Trace(f32u((uint) 31));
                    break;                    
                case NumericKind.I64:
                    var f64i = buffers.MainExec.UnaryOp<Fixed64>(src);
                    Trace((long)f64i((long) -65));
                    break;
                case NumericKind.U64:
                    var f64u = buffers.MainExec.UnaryOp<Fixed64>(src);
                    Trace(f64u((ulong) 63));
                    break;                                    
            }
        }

        void CheckBinaryFunc(in AsmBuffers buffers, AsmCode src)
        {
            var kind = NumericType.parseKind(src.Id.TextComponents.Last());
            if(kind.IsNone())
                return;

            switch(kind.Value)
            {
                case NumericKind.I8:
                    var f8i = buffers.MainExec.BinaryOp<Fixed8>(src);
                    Trace(f8i(5,7));
                    break;
                case NumericKind.U8:
                    var f8u = buffers.MainExec.BinaryOp<Fixed8>(src);
                    Trace(f8u(5,7));
                    break;
                case NumericKind.I16:
                    var f16i = buffers.MainExec.BinaryOp<Fixed16>(src);
                    Trace(f16i(3,6));
                    break;
                case NumericKind.U16:
                    var f16u = buffers.MainExec.BinaryOp<Fixed16>(src);
                    Trace(f16u(12,12));
                    break;                    
                case NumericKind.I32:
                    var f32i = buffers.MainExec.BinaryOp<Fixed32>(src);
                    Trace(f32i(10,10));
                    break;
                case NumericKind.U32:
                    var f32u = buffers.MainExec.BinaryOp<Fixed32>(src);
                    Trace(f32u(20,10));
                    break;                    
                case NumericKind.I64:
                    var f64i = buffers.MainExec.BinaryOp<Fixed64>(src);
                    Trace(f64i(50,50));
                    break;
                case NumericKind.U64:
                    var f64u = buffers.MainExec.BinaryOp<Fixed64>(src);
                    Trace(f64u(13,13));
                    break;                    
                default:
                    Trace($"{kind}");
                    break;
            }
        }

        public void datares_check(in AsmBuffers buffers)
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Data.Resources)
                Claim.eq(d.Location, location(d.GetBytes()));
        }

        public void vadd_check(in AsmBuffers buffers)
        {
            var catalog = AssemblyId.Intrinsics;
            var subject = nameof(dinx);
            var name = nameof(dinx.vadd);

            vadd_check(buffers, n128, ReadAsm(catalog, subject, name, n128, z8));            
            vadd_check(buffers, n128, ReadAsm(catalog, subject, name, n128,z16));
            vadd_check(buffers, n128, ReadAsm(catalog, subject, name, n128,z32));
            vadd_check(buffers, n256, ReadAsm(catalog, subject, name, n256,z16));
            vadd_check(buffers, n256, ReadAsm(catalog, subject, name, n256,z32));
        }

        public void add_megacheck(in AsmBuffers buffers)
        {
            var name = nameof(math.add);
            
            var dArchive = Context.CodeArchive(AssemblyId.GMath, nameof(math));
            var gArchive = Context.CodeArchive(AssemblyId.GMath, nameof(gmath));
            var dAdd = dArchive.Read("add").ToArray();
            var gAdd = gArchive.Read("add_g").Select(code => code.WithIdentity(code.Id.WithoutGeneric())).ToArray();
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
                        Trace($"Verified {d}");
                    break;                       
                }                
            }
        }

        public void sub_megacheck(in AsmBuffers buffers)
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

        void mul_megacheck(in AsmBuffers buffers)
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

        public void and_megacheck(in AsmBuffers buffers)
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

        public void xor_megacheck(in AsmBuffers buffers)
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

        public void nand_megacheck(in AsmBuffers buffers)
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


        public void xnor_megacheck(in AsmBuffers buffers)
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

        public void vector_bitlogic_match(in AsmBuffers buffers)
        {
            var names = array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(FixedWidth.W128, FixedWidth.W256);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                vector_match(buffers, n, w, k);                        
        }

        IEnumerable<string> PrimalBitLogicOps
            => items("and", "or", "xor", "nand", "nor", "xnor",
                "impl","nonimpl", "cimpl", "cnonimpl");

        void primal_bitlogic_match(in AsmBuffers buffers)
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

            var dId = Identity.operation(name, kind, false);
            var gId = Identity.operation(name, kind, true);

            var dArchive = Context.CodeArchive(catalog, dSrc);
            var gArchive = Context.CodeArchive(catalog, gSrc);

            var d = dArchive.Read(dId).Single();
            var g = gArchive.Read(gId).Single();

            Claim.yea(binop_match(buffers, w,d,g));                         

            
        }

        void vector_match(in AsmBuffers buffers, string name, FixedWidth w, NumericKind kind)
        {
            var catalog = AssemblyId.Intrinsics;
            
            var idD = Identity.operation(name, w, kind, false);
            var idG = Identity.operation(name, w, kind, true);

            var d = Context.CodeArchive(catalog, nameof(dinx)).Read(idD).Single();
            var g = Context.CodeArchive(catalog, nameof(ginx)).Read(idG).Single();

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
        
        void vadd_check<T>(in AsmBuffers buffers, N128 w, TypedAsm<T> asm)
            where T : unmanaged
        {            
            var f = buffers.MainExec.BinaryOp(w,asm);            
            CheckMatch<T>(ginx.vadd, f, asm.Id);
        }

        void vadd_check<T>(in AsmBuffers buffers, N256 w, TypedAsm<T> asm)
            where T : unmanaged
        {            
            var f = buffers.MainExec.BinaryOp(w,asm);
            CheckMatch<T>(ginx.vadd, f, asm.Id);
        }
    }
}