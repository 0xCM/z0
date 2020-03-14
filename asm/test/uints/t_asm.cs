//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    public abstract class t_asm<U> : UnitTest<U>
        where U : t_asm<U>
    {
        protected new IAsmContext Context;
        
        public t_asm()
        {
            //Context = AsmContext.Rooted(this, DefaultComposition.Create());
            Context = AsmContext.Rooted(this, AsmCompostionRoot.Compose());
        }


        protected string Math
            => nameof(math);
        
        protected string GMath
            => nameof(gmath);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Moniker that identifies the operation under test</param>
        new string CaseName(OpIdentity id)
            => TestIdentity.testcase(GetType(),id);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        new string CaseName(string fullname)
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



        protected AsmCode ReadAsm(AssemblyId id, string host, OpIdentity m)
            => Context.CodeArchive(id,host).Read(m).Single();

        

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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w,ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, dCode);
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, gCode);
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
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

            var f2 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers.MainExec.EmitFixedBinaryOp(w, ReadAsm(AssemblyId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }
    }
}
