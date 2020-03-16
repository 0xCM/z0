//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static Root;
    using static Nats;
    using static time;
    using static NumericKinds;
    using static BufferSeqId;
    

    public class AsmChecks : IAsmChecks
    {
        public IAsmWorkflowContext Context {get;}

        readonly IAsmEvalDispatcher Executioner;

        readonly IAppMsgSink MsgSink;
        
        IPolyrand Random => Context.Random;
        
        readonly int RepCount;

        public static AsmChecks Create(IAsmWorkflowContext context, IAppMsgSink sink)
            => new AsmChecks(context,sink);

        AsmChecks(IAsmWorkflowContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.RepCount = 128;
            this.MsgSink = sink;
            this.Executioner = AsmEvalDispatcher.Create(context, sink);
        }                

        public void Execute(in BufferSeq buffers, ApiMemberCode code)
        {
            Executioner.EvalOperator(buffers, code);
        }

        public void Execute(in BufferSeq buffers, ApiMemberCode[] code)
        {
            Executioner.EvalOperators(buffers, code);
            //Executioner.EvalFixedOperators(buffers, code);
        }

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public IEnumerable<HostedMember> HostedMembers(in ApiHostUri host)
            => Context.FindHost(host).MapRequired(host => Context.MemberLocator().Hosted(host));

        /// <summary>
        /// Retrieves located members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public IEnumerable<LocatedMember> LocateMembers(in ApiHostUri host)
            => Context.FindHost(host).MapRequired(host => Context.MemberLocator().Located(host));

        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public ReadOnlySpan<AsmOpBits> LoadCode(FilePath src)
            => Context.HexReader().Read(src).ToArray();

        protected string Math
            => nameof(math);
        
        protected string GMath
            => nameof(gmath);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Moniker that identifies the operation under test</param>
        string CaseName(OpIdentity id)
            => TestIdentity.testcase(GetType(),id);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        string CaseName(string fullname)
            => TestIdentity.testcase(GetType(), fullname);

        protected OpIdentity TestOpName<T>(string basename, T t = default)
            where T : unmanaged
                => OpIdentity.numeric($"{basename}_asm",typeof(T).NumericKind());

        protected AsmFormatConfig DefaultAsmFormat
            => AsmFormatConfig.New.WithoutFunctionTimestamp();

        /// <summary>
        /// Evaluates a pair of unary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        TestCaseRecord CheckMatch<T>(in BufferSeq buffers, string basename, UnaryOp<T> f, UnaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            return CheckAction(check, CaseName(TestOpName<T>(basename)));
        }    

        /// <summary>
        /// Evaluates a pair of binary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        TestCaseRecord CheckMatch<T>(in BufferSeq buffers, string opname, BinaryOp<T> f, BinaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName(TestOpName<T>(opname)));
        }

        protected TestCaseRecord CheckAsmMatch<T>(in BufferSeq buffers, BinaryOp<T> f, in ApiCode src)
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

            return CheckAction(check, src.Id);
        }


        protected ApiCode ReadAsm(AssemblyId id, string host, OpIdentity m)
            => Context.CodeArchive(id,host).Read(m).Single().ApiCode;

        protected ApiCode ReadAsm<W,T>(AssemblyId catalog, string host, string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            var archive = Context.CodeArchive(catalog,host);
            var id = NaturalIdentity.contracted(opname, w, Numeric.kind<T>());
            Context.Notify($"{id}");
            var result = Context.CodeArchive(catalog,host).Read<T>(id);
            if(!result)
                Claim.failwith($"Could not find {id} in the archive at {archive.RootFolder}");
            return result.Require().ApiCode;
        }
        
        protected TestCaseRecord CheckMatch<T>(in BufferSeq buffers, BinaryOp<Vector128<T>> f, OpIdentity fId, BinaryOp128 g, OpIdentity gId)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    Claim.eq(f(x,y), g.Apply(x,y));
                }
            }            

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));                   
        }


        protected TestCaseRecord CheckMatch<T>(in BufferSeq buffers, BinaryOp<Vector256<T>> f, OpIdentity fId, BinaryOp256 g, OpIdentity gId)
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);

            void check()            
            {

                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    Claim.eq(f(x,y), g.Apply(x,y));
                }
            }            

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));            
        }


        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="id">The action name</param>
        private TestCaseRecord CheckAction(Action f, OpIdentity id)
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
                term.error(e, id.Identifier);
                return TestCaseRecord.Define(name, false, clock);                
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        private TestCaseRecord CheckAction(Action f, string name)
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
                term.error(e, name);
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
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(n8);
                    var y = Random.Fixed(n8);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));
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
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(n16);
                    var y = Random.Fixed(n16);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));
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
            var w = n32;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));
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
            var w = n64;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));
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
            var w = n128;
            
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));
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
            var w = n256;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, Func<byte,byte,byte> primal, Func<byte,byte,byte> generic, U8 kind)
        {
            var results = list<TestCaseRecord>();
            var w = n8;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w,ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, 
            I8 kind)
        {
            var results = list<TestCaseRecord>();

            var w = n8;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, in ApiCode dCode, in ApiCode gCode, 
            Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, I8 kind)
        {
            var results = list<TestCaseRecord>();

            var w = n8;

            var id = OpIdentity.numeric(name, kind, false);
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
            Func<ushort,ushort,ushort> primal, Func<ushort,ushort,ushort> generic, U16 kind)
        {
            var results = list<TestCaseRecord>();

            var w = n16;

            var id = OpIdentity.numeric(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            Func<short,short,short> primal, Func<short,short,short> generic, I16 kind)
        {
            var results = list<TestCaseRecord>();

            var w = n16;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            Func<uint,uint,uint> primal, Func<uint,uint,uint> generic, U32 kind)
        {
            var results = list<TestCaseRecord>();

            var w = n32;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            Func<int,int,int> primal, Func<int,int,int> generic, I32 kind)
        {
            var results = list<TestCaseRecord>();

            var w = n32;
            var id = OpIdentity.numeric(name, kind, false);

            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            Func<long,long,long> primal, Func<long,long,long> generic, I64 kind)
        {            
            var results = list<TestCaseRecord>();

            var w = n64;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<ulong> primal, BinaryOp<ulong> generic, U64 kind)
        {            
            var results = list<TestCaseRecord>();

            var w = n64;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        IEnumerable<string> PrimalBitLogicOps
            => items("and", "or", "xor", "nand", "nor", "xnor",
                "impl","nonimpl", "cimpl", "cnonimpl");

        void bitlogic_match(in BufferSeq buffers)
        {
            var names = PrimalBitLogicOps;
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(FixedWidth.W8, FixedWidth.W16, FixedWidth.W32, FixedWidth.W64);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                primal_match(buffers, n, w, k);                        
        }

        void primal_match(in BufferSeq buffers, string name, FixedWidth w, NumericKind kind)
        {
            var catalog = AssemblyId.GMath;
            var dSrc = nameof(math);
            var gSrc = nameof(gmath);

            var dId = OpIdentity.numeric(name, kind, false);
            var gId = OpIdentity.numeric(name, kind, true);

            var dArchive = Context.CodeArchive(catalog, dSrc);
            var gArchive = Context.CodeArchive(catalog, gSrc);

            var d = dArchive.Read(dId).Single().ApiCode;
            var g = gArchive.Read(gId).Single().ApiCode;

            Claim.yea(binop_match(buffers, w,d,g));                                     
        }

        bit binop_match(in BufferSeq buffers, FixedWidth w, ApiCode a, ApiCode b)
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

        protected void binop_match(in BufferSeq buffers, N8 w, ApiCode a, ApiCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, N16 w, ApiCode a, ApiCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, N32 w, ApiCode a, ApiCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, N64 w, ApiCode a, ApiCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, N128 w, ApiCode a, ApiCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(in BufferSeq buffers, N256 w, ApiCode a, ApiCode b)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, a);
            var g = buffers[Right].EmitFixedBinaryOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }

        void capture_constants(in AsmBuffers buffers)
        {
            var src = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));

            using var rawout = HexWriter(Context);            
            using var hexout = CodeWriter(Context);
            using var asmout = FunctionWriter(Context);            
            
            var decoder = Context.AsmFunctionDecoder();
            var capture = buffers.Capture;
            
            var data = capture.Capture(buffers.Exchange, src);        
            hexout.WriteCode(data.Code);
            rawout.WriteHexLine(data);
            asmout.Write(decoder.DecodeFunction(data));
        }

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        void capture_shifter(in AsmBuffers buffers)
        {
            var src = shifter(4);

            using var rawout = HexWriter(Context);            
            using var hexout = CodeWriter(Context);
            using var asmout = FunctionWriter(Context);            

            var capture = buffers.Capture;
            var decoder = Context.AsmFunctionDecoder();
            
            var data = capture.Capture(buffers.Exchange, src.Identify(), src);
            hexout.WriteCode(data.Code);
            rawout.WriteHexLine(data);
            asmout.Write(decoder.DecodeFunction(data));            
        }

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => gvec.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        void capture_shuffler(in AsmBuffers buffers)
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);

            using var rawout = HexWriter(Context);            
            using var hexout = CodeWriter(Context);
            using var asmout = FunctionWriter(Context);            

            var capture = buffers.Capture;
            var decoder = Context.AsmFunctionDecoder();

            var fData = capture.Capture(buffers.Exchange, f.Identify(), f);
            hexout.WriteCode(fData.Code);
            rawout.WriteHexLine(fData);
            asmout.Write(decoder.DecodeFunction(fData));

            var gData = capture.Capture(buffers.Exchange, g.Identify(), g);
            hexout.WriteCode(gData.Code);
            rawout.WriteHexLine(fData);
            asmout.Write(decoder.DecodeFunction(gData));
        }

        void binary_imm(in AsmBuffers buffers)
        {
            var w = n256;
            var name = nameof(dvec.vblend8x16);
            var imm = (byte)Blend8x16.LRLRLRLR;

            var provider = Context.V256BinaryOpImmInjector<ushort>();
            var x = Random.CpuVector<ushort>(w);
            var y = Random.CpuVector<ushort>(w);
            
            var method = Intrinsics.Vectorized<ushort>(w, false, name).Single();            
            var dynop = provider.EmbedImmediate(method,imm);
            var f = dynop.DynamicOp;
            var z1 = f.Invoke(x,y);
            var decoder = Context.AsmFunctionDecoder();
            var captured = Context.Capture().Capture(buffers.Exchange, dynop.Id, dynop);
            var asm = decoder.DecodeFunction(captured);        


            var g = buffers.MainExec.EmitFixedBinaryOp<Fixed256>(asm.Code.ApiCode);
            var z3 = g(x,y).ToVector<ushort>();
            Claim.eq(z1,z3);
        }


        AsmFormatConfig AsmFormat
            => AsmFormatConfig.New.WithoutFunctionTimestamp();

        IAsmCodeWriter CodeWriter(IAsmContext context, [Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  context.CodeWriter(dst);
        }

        protected IAsmCodeWriter HexWriter(IAsmContext context, [Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Raw);    
            return  context.CodeWriter(dst);
        }

        protected IAsmFunctionWriter FunctionWriter(IAsmContext context, [Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Asm);
            var format = AsmFormatConfig.New.WithFunctionTimestamp();
            return context.WithFormat(format).AsmWriter(path);
        }


        void CheckImm(in BufferSeq buffers, in OpExtractExchange exchange)
        {
            CheckBinaryImm<uint>(buffers, exchange, n128, nameof(dvec.vblend4x32), (byte)Blend4x32.LRLR);    
            CheckBinaryImm<uint>(buffers, exchange, n128, nameof(dvec.vblend8x32), (byte)Blend8x32.LRLRLRLR);    
            CheckUnaryImm<ushort>(buffers, exchange, n256, nameof(dvec.vbsll), 3);        
        }


        void CheckBinaryImm<T>(in BufferSeq buffers, in OpExtractExchange exchange, N128 w, string name, byte imm)
            where T : unmanaged
        {            
            var provider = Context.V128BinaryOpImmInjector<T>();

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var dynop = provider.EmbedImmediate(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            var decoder = Context.AsmFunctionDecoder();
            var captured = Context.Capture().Capture(exchange, dynop.Id, dynop);            
            var asm = decoder.DecodeFunction(captured);

            // Trace(asm.Id);
            // iter(asm.Instructions, i => Trace(i));  

            var f = buffers[Main].EmitFixedBinaryOp<Fixed128>(asm.Code.ApiCode);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.eq(z1,z2);
        }

        void CheckBinaryImm<T>(in OpExtractExchange exchange, BufferToken buffer, N256 w, string name, byte imm)
            where T : unmanaged
        {            
            var provider = Context.V256BinaryOpImmInjector<T>();

            var x = Random.CpuVector<T>(w);
            var y = Random.CpuVector<T>(w);
            
            var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var dynop = provider.EmbedImmediate(method,imm);
            var z1 = dynop.DynamicOp.Invoke(x,y);
            
            var decoder = Context.AsmFunctionDecoder();
            var captured = Context.Capture().Capture(in exchange, dynop.Id, dynop);            
            var asm = decoder.DecodeFunction(captured);

            // Trace(asm.Id);
            // iter(asm.Instructions, i => Trace(i));  

            var f = buffer.EmitFixedBinaryOp<Fixed256>(asm.Code.ApiCode);
            var z2 = f(x.ToFixed(),y.ToFixed()).ToVector<T>();
            Claim.eq(z1,z2);
        }

        void CheckUnaryImm<T>(in BufferSeq buffers, in OpExtractExchange exchange, N256 w, string name, byte imm)
            where T : unmanaged
        {            
            var method = Intrinsics.Vectorized<T>(w, false, name).Single();            
            var provider = Context.V256UnaryOpImmInjector<T>();

            
            var dynop = provider.EmbedImmediate(method,imm);

            var x = Random.CpuVector<T>(w);
            var z1 = dynop.DynamicOp.Invoke(x);
            
            var decoder = Context.AsmFunctionDecoder();
            var capture = Context.Capture().Capture(in exchange, dynop.Id, dynop);            
            var asm = decoder.DecodeFunction(capture);

            // Trace(asm.Id);
            // iter(asm.Instructions, i => Trace(i));  

            var f = buffers[Main].EmitFixedUnaryOp<Fixed256>(capture.Code.ApiCode);
            var z2 = f(x.ToFixed()).ToVector<T>();
            Claim.eq(z1,z2);
        }

        public void vector_bitlogic_match(in BufferSeq buffers)
        {
            var names = array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(FixedWidth.W128, FixedWidth.W256);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                vector_match(buffers, n, w, k);                        
        }


        void vector_match(in BufferSeq buffers, string name, FixedWidth w, NumericKind kind)
        {
            var catalog = AssemblyId.Intrinsics;
            
            var idD = OpIdentity.operation(name, w, kind, false);
            var idG = OpIdentity.operation(name, w, kind, true);

            var d = Context.CodeArchive(catalog, nameof(dvec)).Read(idD).Single().ApiCode;
            var g = Context.CodeArchive(catalog, nameof(gvec)).Read(idG).Single().ApiCode;

            Claim.yea(binop_match(buffers, w,d,g));
        }


        public void vadd_check(in BufferSeq buffers)
        {
            var catalog = AssemblyId.Intrinsics;
            var subject = nameof(dvec);
            var name = nameof(dvec.vadd);

            vadd_check<byte>(buffers, n128, ReadAsm(catalog, subject, name, n128, z8));            
            vadd_check<ushort>(buffers, n128, ReadAsm(catalog, subject, name, n128,z16));
            vadd_check<uint>(buffers, n128, ReadAsm(catalog, subject, name, n128,z32));
            vadd_check<ushort>(buffers, n256, ReadAsm(catalog, subject, name, n256,z16));
            vadd_check<uint>(buffers, n256, ReadAsm(catalog, subject, name, n256,z32));
        }

        public void add_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.add);
            
            var dArchive = Context.CodeArchive(AssemblyId.GMath, nameof(math));
            var gArchive = Context.CodeArchive(AssemblyId.GMath, nameof(gmath));
            var dAdd = dArchive.Read("add").Select(x => x.ApiCode).ToArray();
            var gAdd = gArchive.Read("add_g").Select(code => code.WithIdentity(code.Id.WithoutGeneric()).ApiCode).ToArray();
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

        void vadd_check<T>(in BufferSeq buffers, N128 w, ApiCode asm)
            where T : unmanaged
        {            
            var f = buffers[Main].EmitFixedBinaryOp(w,asm);            
            CheckMatch<T>(gvec.vadd, f, asm.Id);
        }


        void vadd_check<T>(in BufferSeq buffers, N256 w, ApiCode asm)
            where T : unmanaged
        {            
            var f = buffers[Main].EmitFixedBinaryOp(w,asm);
            CheckMatch<T>(gvec.vadd, f, asm.Id);
        }


         /// <summary>
        /// Verifies that two 128-bit vectorized binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch<T>(BinaryOp<Vector128<T>> f, BinaryOp128 g, OpIdentity name)
            where T : unmanaged
        {
            void check()
            {
                var w = n128;
                var t = default(T);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    Claim.eq(f(x,y), g.Apply(x,y));
                }            
            }

            CheckAction(check, name);      
        }

        /// <summary>
        /// Verifies that two 256-bit vectorized binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch<T>(BinaryOp<Vector256<T>> f, BinaryOp256 g, OpIdentity name)
            where T : unmanaged
        {
            void check()
            {
                var w = n256;
                var t = default(T);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    Claim.eq(f(x,y), g.Apply(x,y));
                }
            }      

            CheckAction(check, name);      
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

        void datares_check(in BufferSeq buffers)
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Data.Resources)
                Claim.eq(d.Location, ptr(d.GetBytes()));
        }

        void RunPipe()
        {
            var archive =  Context.CodeArchive(AssemblyId.Intrinsics);
            var source = archive.ToInstructionSource();
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
            
            // TraceCaller($"{listcount} instruction lists were processed out of {source.Instructions.Count()} available");
            // TraceCaller($"Trigger activate {activations} times");
        }

        void Run50(in BufferSeq buffers)
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


         void CheckUnaryOp<F>(in BufferSeq dst, in FixedAsm<F> a, in FixedAsm<F> b)
            where F : unmanaged, IFixedWidth
        {                        

            var f = dst[Left].EmitFixedUnaryOp<F>(a.Code.ApiCode);
            var g = dst[Right].EmitFixedUnaryOp<F>(b.Code.ApiCode);            

            var stream = Random.StreamFixed<F>();
            if(stream == null)
                Claim.fail($"random stream null!");

            var points = stream.Take(RepCount);
            iter(points, x => Claim.eq(f(x), g(x)));            

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
    }
}