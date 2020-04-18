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
    using static NumericKinds;
    using static BufferSeqId;
    
    public class AsmChecks : IAsmChecks
    {
        public IAsmContext Context {get;}
        
        IPolyrand Random => Context.Random;
        
        readonly int RepCount;

        public static AsmChecks Create(IAsmContext context)
            => new AsmChecks(context);

        ICheck Claim => Z0.Claim.Checker;

        AsmChecks(IAsmContext context)
        {
            this.Context = context;
            this.RepCount = 128;
        }                

        protected ICaptureArchive CodeArchive 
            => Context.CaptureArchive(
                Env.Current.LogDir + FolderName.Define("test"), 
                FolderName.Define("data"), 
                FolderName.Define(GetType().Name)
                );

        protected IBitArchiveWriter CodeWriter([Caller] string caller = null)
        {            
            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.Hex));
            return Context.BitArchiveWriter(dstPath);
        }

        protected IBitArchiveWriter HexWriter([Caller] string caller = null)
        {            

            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.Raw));
            return Context.BitArchiveWriter(dstPath);
        }

        protected IAsmFunctionWriter FunctionWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            var format = AsmFormatConfig.New.WithFunctionTimestamp();
            return Context.AsmWriter(dst,format);
        }

        protected ApiHostUri Math
            => ApiHostUri.FromHost(typeof(math));
        
        protected ApiHostUri GMath
            => ApiHostUri.FromHost(typeof(gmath));

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Moniker that identifies the operation under test</param>
        string CaseName(OpIdentity id)
            => OpUriBuilder.TestCase(GetType(),id);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        string CaseName(string fullname)
            => OpUriBuilder.TestCase(GetType(), fullname);

        protected OpIdentity TestOpName<T>(string basename, T t = default)
            where T : unmanaged
                => Identify.NumericOp($"{basename}_asm",typeof(T).NumericKind());


        protected TestCaseRecord TestAsmMatch<T>(in BufferSeq buffers, BinaryOp<T> f, in IdentifiedCode src)
            where T : unmanaged
        {
                      
            //var g = AsmBuffer.BinaryOp(asm.Typed<T>());
            var g = buffers[Main].EmitBinaryOp<T>(src);

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, src.Id);
        }

        protected IdentifiedCode ReadAsm(PartId id, ApiHostUri host, OpIdentity m)
            => Context.HostBitsArchive(id,host).Read(m).Single().ToApiCode();

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="id">The action name</param>
        private TestCaseRecord TestAction(Action f, OpIdentity id)
        {
            
            var name = CaseName(id);
            var clock = counter(true);
            try
            {
                f();
                return TestCaseRecord.Define(name, true, clock);
            }
            catch(Exception e)
            {
                term.errlabel(e, id.Identifier);
                return TestCaseRecord.Define(name, false, clock);                
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        private TestCaseRecord TestAction(Action f, string name)
        {
            var succeeded = true;
            
            var clock = counter(true);
            try
            {
                f();
                return TestCaseRecord.Define(name, true, clock);
            }
            catch(Exception e)
            {
                term.errlabel(e, name);
                return TestCaseRecord.Define(name, true, clock);
            }
        }

        /// <summary>
        /// Verifies that two 8-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord CheckMatch(BinaryOp8 f, OpIdentity fId, BinaryOp8 g, OpIdentity gId)
        {
            var w = w8;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 16-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord CheckMatch(BinaryOp16 f, OpIdentity fId, BinaryOp16 g, OpIdentity gId)
        {
            var w = w16;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord CheckMatch(BinaryOp32 f, OpIdentity fId, BinaryOp32 g, OpIdentity gId)
        {
            var w = w32;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 64-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord CheckMatch(BinaryOp64 f, OpIdentity fId, BinaryOp64 g, OpIdentity gId)
        {
            var w = w64;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    var a = f(x,y);
                    var b = g(x,y);
                    Claim.eq(a,b);
                }
            }

            return TestAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 128-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord CheckMatch(BinaryOp128 f, OpIdentity fId, BinaryOp128 g, OpIdentity gId)
        {
            var w = w128;
            
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 128-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord CheckMatch(BinaryOp256 f, OpIdentity fId, BinaryOp256 g, OpIdentity gId)
        {
            var w = w256;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, CaseName($"{fId}~/~{gId}"));
        }

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

        IEnumerable<string> PrimalBitLogicOps
            => seq("and", "or", "xor", "nand", "nor", "xnor",
                "impl","nonimpl", "cimpl", "cnonimpl");

        void bitlogic_match(in BufferSeq buffers)
        {
            var names = PrimalBitLogicOps;
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(TypeWidth.W8, TypeWidth.W16, TypeWidth.W32, TypeWidth.W64);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                primal_match(buffers, n, w, k);                        
        }

        void primal_match(in BufferSeq buffers, string name, TypeWidth w, NumericKind kind)
        {
            var catalog = PartId.GMath;
            var dSrc = ApiHostUri.FromHost(typeof(math));
            var gSrc = ApiHostUri.FromHost(typeof(gmath));

            var dId = Identify.Op(name, kind, false);
            var gId = Identify.Op(name, kind, true);

            var dArchive = Context.HostBitsArchive(catalog, dSrc);
            var gArchive = Context.HostBitsArchive(catalog, gSrc);

            var d = dArchive.Read(dId).Single().ToApiCode();
            var g = gArchive.Read(gId).Single().ToApiCode();

            Claim.require(binop_match(buffers, w,d,g));                                     
        }

        bit binop_match(in BufferSeq buffers, TypeWidth w, IdentifiedCode a, IdentifiedCode b)
        {
            switch(w)
            {
                case TypeWidth.W8:
                    binop_match(buffers, w8,a,b);
                    break;

                case TypeWidth.W16:
                    binop_match(buffers, w16,a,b);
                    break;

                case TypeWidth.W32:
                    binop_match(buffers, w32,a,b);
                    break;

                case TypeWidth.W64:
                    binop_match(buffers, w64,a,b);
                    break;

                case TypeWidth.W128:
                    binop_match(buffers, w128,a,b);
                    break;

                case TypeWidth.W256:
                    binop_match(buffers, w256, a, b);
                    break;

                default:
                    Claim.fail();
                break;
            }
            return bit.On;
        }

        protected void binop_match(in BufferSeq buffers, W8 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, W16 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, W32 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, W64 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, W128 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, W256 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }


        void capture_constants(in BufferSeq buffers)
        {
            var src = typeof(gmath).Method(nameof(BitMask.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
        
            var control = MemberCaptureControl.New(Context);
            var exchange = CaptureExchange.Create(control, buffers.Buffer(0), buffers.Buffer(1));
            var capture = Context.Capture();
            var decoder = Context.AsmFunctionDecoder();            
            var captured = capture.Capture(exchange, src.Identify(), src).Require();
            
            using var rawout = HexWriter();            
            using var hexout = CodeWriter();
            using var asmout = FunctionWriter();            
            
            hexout.WriteCode(captured.Code);
            rawout.WriteHexLine(captured);
            asmout.Write(decoder.DecodeCaptured(captured).Require());
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

            using var rawout = HexWriter();            
            using var hexout = CodeWriter();
            using var asmout = FunctionWriter();         

            var control = MemberCaptureControl.New(Context);
            var exchange = CaptureExchange.Create(control, buffers.Buffer(0), buffers.Buffer(1));
            var capture = Context.Capture();
            var decoder = Context.AsmFunctionDecoder();

            var fCaptured = capture.Capture(exchange, f.Identify(), f).Require();
            hexout.WriteCode(fCaptured.Code);
            rawout.WriteHexLine(fCaptured);
            asmout.Write(decoder.DecodeCaptured(fCaptured).Require());

            var gCaptured = capture.Capture(exchange, g.Identify(), g).Require();
            hexout.WriteCode(gCaptured.Code);
            rawout.WriteHexLine(fCaptured);
            asmout.Write(decoder.DecodeCaptured(gCaptured).Require());
        }
        
        MethodInfo Method => default;
        
        void binary_imm(in BufferSeq buffers)
        {
            var w = w256;
            var name = nameof(dvec.vblend8x16);
            var imm = (byte)Blend8x16.LRLRLRLR;

            var provider = Context.V256BinaryOpImmInjector<ushort>();
            var x = Random.CpuVector<ushort>(w);
            var y = Random.CpuVector<ushort>(w);
            
            //var method = Intrinsics.Vectorized<ushort>(w, false, name).Single();      
            var capture = Context.Capture();
            var control = MemberCaptureControl.New(Context);
            var exchange = CaptureExchange.Create(control, buffers.Buffer(0), buffers.Buffer(1));
            var decoder = Context.AsmFunctionDecoder();

            var method = Method;
            var dynop = provider.EmbedImmediate(method,imm);
            var f = dynop.DynamicOp;
            var z1 = f.Invoke(x,y);
            var captured = capture.Capture(exchange, dynop.Id, dynop).Require();
            var asm = decoder.DecodeCaptured(captured);        

            var exec = buffers[2];
            var g = exec.EmitFixedBinaryOp<Fixed256>(asm.Require().Code);
            var z3 = g(x,y).ToVector<ushort>();
            Claim.veq(z1,z3);
        }

        void CheckImm(in BufferSeq buffers, in CaptureExchange exchange)
        {
            CheckBinaryImm<uint>(buffers, exchange, w128, nameof(dvec.vblend4x32), (byte)Blend4x32.LRLR);    
            CheckBinaryImm<uint>(buffers, exchange, w128, nameof(dvec.vblend8x32), (byte)Blend8x32.LRLRLRLR);    
            CheckUnaryImm<ushort>(buffers, exchange, w256, nameof(dvec.vbsll), 3);        
        }

        void CheckBinaryImm<T>(in BufferSeq buffers, in CaptureExchange exchange, W128 w, string name, byte imm)
            where T : unmanaged
        {            
            var provider = Context.V128BinaryOpImmInjector<T>();

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            //var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var capture = Context.Capture();
            var decoder = Context.AsmFunctionDecoder();

            var method = Method;
            var dynop = provider.EmbedImmediate(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            var captured = capture.Capture(exchange, dynop.Id, dynop).Require();            
            var asm = decoder.DecodeCaptured(captured);

            // Trace(asm.Id);
            // iter(asm.Instructions, i => Trace(i));  

            var f = buffers[Main].EmitFixedBinaryOp<Fixed128>(asm.Require().Code);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.veq(z1,z2);
        }

        void CheckBinaryImm<T>(in CaptureExchange exchange, BufferToken buffer, W256 w, string name, byte imm)
            where T : unmanaged
        {            
            var provider = Context.V256BinaryOpImmInjector<T>();

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            //var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var method = Method;            
            var dynop = provider.EmbedImmediate(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            
            var decoder = Context.AsmFunctionDecoder();
            var captured = Context.Capture().Capture(in exchange, dynop.Id, dynop).Require();            
            var asm = decoder.DecodeCaptured(captured).Require();

            // Trace(asm.Id);
            // iter(asm.Instructions, i => Trace(i));  

            var f = buffer.EmitFixedBinaryOp<Fixed256>(asm.Code);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.veq(z1,z2);
        }
        
        void CheckUnaryImm<T>(in BufferSeq buffers, in CaptureExchange exchange, W256 w, string name, byte imm)
            where T : unmanaged
        {            
            //var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            
            var method = Method;            
            var provider = Context.V256UnaryOpImmInjector<T>();

            
            var dynop = provider.EmbedImmediate(method,imm);

            var x = Random.CpuVector<T>(w);
            var z1 = dynop.DynamicOp.Invoke(x);
            
            var decoder = Context.AsmFunctionDecoder();
            var capture = Context.Capture().Capture(in exchange, dynop.Id, dynop).Require();            
            var asm = decoder.DecodeCaptured(capture).Require();

            var f = buffers[Main].EmitFixedUnaryOp<Fixed256>(capture.Code);
            var z2 = f(x.ToFixed()).ToVector<T>();
            Claim.veq(z1,z2);
        }

        void vector_match(in BufferSeq buffers, string name, TypeWidth w, NumericKind kind)
        {
            var catalog = PartId.GVec;
            
            var idD = Identify.Op(name, w, kind, false);
            var idG = Identify.Op(name, w, kind, true);

            var d = Context.HostBitsArchive(catalog, ApiHost.Create<dvec>().UriPath).Read(idD).Single();
            var g = Context.HostBitsArchive(catalog, ApiHost.Create<gvec>().UriPath).Read(idG).Single();

            Claim.require(binop_match(buffers, w,d,g));
        }

        // public void vadd_check(in BufferSeq buffers)
        // {
        //     var catalog = PartId.GVec;
        //     var host = ApiHost.Create<dvec>().UriPath;
        //     var name = nameof(dvec.vadd);

        //     vadd_check<byte>(buffers, w128, ReadAsm(catalog, host, name, w128, z8));            
        //     vadd_check<ushort>(buffers, w128, ReadAsm(catalog, host, name, w128,z16));
        //     vadd_check<uint>(buffers, w128, ReadAsm(catalog, host, name, w128,z32));
        //     vadd_check<ushort>(buffers, w256, ReadAsm(catalog, host, name, w256,z16));
        //     vadd_check<uint>(buffers, w256, ReadAsm(catalog, host, name, w256,z32));
        // }


        public void vector_bitlogic_match(in BufferSeq buffers)
        {
            var names = array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(TypeWidth.W128, TypeWidth.W256);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                vector_match(buffers, n, w, k);                        
        }

        void vadd_check<T>(in BufferSeq buffers, W128 w, ApiBits asm)
            where T : unmanaged
        {            
            var f = buffers[Main].EmitFixedBinaryOp(w,asm);            
            TestMatch<T>(gvec.vadd, f, asm.Id);
        }


        void vadd_check<T>(in BufferSeq buffers, W256 w, ApiBits asm)
            where T : unmanaged
        {            
            var f = buffers[Main].EmitFixedBinaryOp(w,asm);
            TestMatch<T>(gvec.vadd, f, asm.Id);
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

            using var rawout = HexWriter();            
            using var hexout = CodeWriter();
            using var asmout = FunctionWriter();            

            var decoder = Context.AsmFunctionDecoder();
            var captured = Context.Capture().Capture(Context.CaptureExchange(), src.Identify(), src);
            var decoded = captured.OnSome(c => decoder.DecodeCaptured(c));                    
        }

        AsmFormatConfig AsmFormat
            => AsmFormatConfig.New.WithoutFunctionTimestamp();


        /// <summary>
        /// Verifies that two 128-bit vectorized binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord TestMatch<T>(BinaryOp<Vector128<T>> f, BinaryOp128 g, OpIdentity name)
            where T : unmanaged
        {
            void check()
            {
                var w = w128;
                var t = default(T);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    Claim.veq(f(x,y), g.Apply(x,y));
                }            
            }

            return TestAction(check, name);      
        }

        /// <summary>
        /// Verifies that two 256-bit vectorized binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected TestCaseRecord TestMatch<T>(BinaryOp<Vector256<T>> f, BinaryOp256 g, OpIdentity name)
            where T : unmanaged
        {
            void check()
            {
                var w = w256;
                var t = default(T);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    Claim.veq(f(x,y), g.Apply(x,y));
                }
            }      

            return TestAction(check, name);      
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
            var archive =  Context.HostBitsArchive(PartId.GVec);
            var source = archive.ToInstructionSource(Context, Context.AsmFormat);
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
            var direct = Context.HostBitsArchive(id, dSrc);
            var generic = Context.HostBitsArchive(id, gSrc);

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

         void CheckUnaryOp<F>(in BufferSeq dst, in FixedAsm<F> a, in FixedAsm<F> b)
            where F : unmanaged, IFixed
        {                        

            var f = dst[Left].EmitFixedUnaryOp<F>(a.Code.ToApiCode());
            var g = dst[Right].EmitFixedUnaryOp<F>(b.Code.ToApiCode());            

            var stream = Random.FixedStream<F>();
            if(stream == null)
                Claim.fail($"random stream null!");

            var points = stream.Take(RepCount);
            iter(points, x => Claim.eq(f(x), g(x)));            
        }

    #if Megacheck

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