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

    using static Root;
    using static Nats;
    using static time;

    public class AsmChecks : IAsmService
    {
        public IAsmContext Context {get;set;}
        
        IPolyrand Random ;
        
        int RepCount;

        public static AsmChecks Create(IAsmContext context, IPolyrand random)
            => new AsmChecks(context, random);

        AsmChecks(IAsmContext context, IPolyrand random)
        {
            this.Context = context;
            this.RepCount = 128;
            this.Random = random;
        }

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
        protected TestCaseRecord CheckMatch<T>(in AsmBuffers buffers, string basename, UnaryOp<T> f, UnaryOp<T> g)
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
        protected TestCaseRecord CheckMatch<T>(in AsmBuffers buffers, string opname, BinaryOp<T> f, BinaryOp<T> g)
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

        protected TestCaseRecord CheckAsmMatch<T>(in AsmBuffers buffers, UnaryOp<T> f, AsmCode src)
            where T : unmanaged
        {
            var g = buffers.MainExec.Load(src).FixedUnaryAdapter<T>(src.Id);            

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            return CheckAction(check, src.Id);
        }

        protected TestCaseRecord CheckAsmMatch<T>(in AsmBuffers buffers, UnaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(buffers, f, asm.Untyped);

        protected TestCaseRecord CheckAsmMatch<T>(in AsmBuffers buffers, BinaryOp<T> f, AsmCode src)
            where T : unmanaged
        {
                      
            //var g = AsmBuffer.BinaryOp(asm.Typed<T>());
            var g = buffers.MainExec.EmitBinaryOp<T>(src.Id);

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

        protected TestCaseRecord CheckAsmMatch<T>(in AsmBuffers buffers, BinaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(buffers, f,asm.Untyped);

        protected AsmCode ReadAsm(AssemblyId id, string host, OpIdentity m)
            => Context.CodeArchive(id,host).Read(m).Single();

        protected AsmCode<T> ReadAsm<W,T>(AssemblyId catalog, string host, string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            var archive = Context.CodeArchive(catalog,host);
            var id = NaturalIdentity.contracted(opname, w, Numeric.kind<T>());
            Context.Notify($"{id}");
            var result = Context.CodeArchive(catalog,host).Read<T>(id);
            if(!result)
                Claim.failwith($"Could not find {id} in the archive at {archive.RootFolder}");
            return result.Require();
        }
        
        protected TestCaseRecord CheckMatch<T>(in AsmBuffers buffers, BinaryOp<Vector128<T>> f, OpIdentity fId, BinaryOp128 g, OpIdentity gId)
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


        protected TestCaseRecord CheckMatch<T>(in AsmBuffers buffers, BinaryOp<Vector256<T>> f, OpIdentity fId, BinaryOp256 g, OpIdentity gId)
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

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<byte,byte,byte> primal, Func<byte,byte,byte> generic, NumericTypeKind<byte> kind)
        {
            var results = list<TestCaseRecord>();
            var w = n8;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w,ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, NumericTypeKind<sbyte> kind)
        {
            var results = list<TestCaseRecord>();

            var w = n8;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, in AsmCode dCode, in AsmCode gCode, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, NumericTypeKind<sbyte> kind)
        {
            var results = list<TestCaseRecord>();

            var w = n8;

            var id = OpIdentity.numeric(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, dCode);
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, gCode);
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<ushort,ushort,ushort> primal, Func<ushort,ushort,ushort> generic, NumericTypeKind<ushort> kind)
        {
            var results = list<TestCaseRecord>();

            var w = n16;

            var id = OpIdentity.numeric(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<short,short,short> primal, Func<short,short,short> generic, NumericTypeKind<short> kind)
        {
            var results = list<TestCaseRecord>();

            var w = n16;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<uint,uint,uint> primal, Func<uint,uint,uint> generic, NumericTypeKind<uint> kind)
        {
            var results = list<TestCaseRecord>();

            var w = n32;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<int,int,int> primal, Func<int,int,int> generic, NumericTypeKind<int> kind)
        {
            var results = list<TestCaseRecord>();

            var w = n32;
            var id = OpIdentity.numeric(name, kind, false);

            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<long,long,long> primal, Func<long,long,long> generic, NumericTypeKind<long> kind)
        {            
            var results = list<TestCaseRecord>();

            var w = n64;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in AsmBuffers buffers, string name, Func<ulong,ulong,ulong> primal, Func<ulong,ulong,ulong> generic, NumericTypeKind<ulong> kind)
        {            
            var results = list<TestCaseRecord>();

            var w = n64;
            var id = OpIdentity.numeric(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.FixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }
    }
}