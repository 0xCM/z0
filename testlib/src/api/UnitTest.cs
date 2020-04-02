//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static TestLib;

    public abstract class UnitTest<U> : TestContext<U>, IUnitTest, ITestControl
        where U : UnitTest<U>
    {        
        protected virtual bool TraceDetailEnabled
            => false;

        /// <summary>
        /// Creates a new stopwatch and optionally start it
        /// </summary>
        /// <param name="start">Whether to start the new stopwatch</param>
        [MethodImpl(Inline)]   
        protected static Stopwatch stopwatch(bool start = true) 
            => start ? Stopwatch.StartNew() : new Stopwatch();

        /// <summary>
        /// Captures a stopwatch duration
        /// </summary>
        /// <param name="sw">A running/stopped stopwatch</param>
        [MethodImpl(Inline)]   
        protected static Duration snapshot(Stopwatch sw)     
            => Duration.Define(sw.ElapsedTicks);        

        /// <summary>
        /// Captures a duration and the number of operations executed within the period
        /// </summary>
        /// <param name="time">The running time</param>
        /// <param name="opcount">The operation count</param>
        /// <param name="label">The label associated with the measure, if specified</param>
        protected static BenchmarkRecord optime(long opcount, Duration time, [CallerMemberName] string label = null)
            => BenchmarkRecord.Define(opcount, time, label);

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, OpIdentity name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.error(e, name.Identifier);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(CaseName(name), succeeded,count);
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, string name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.error(e, name);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(name,succeeded,count);
            }
        }


        /// <summary>
        /// Returns the value represented by a natural type
        /// </summary>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]   
        public static NatVal natval<N>(N n = default) 
            where N : unmanaged, ITypeNat
                => NatVal.From(TypeNats.value<N>()); 

        protected bit on => bit.On;

        protected bit off => bit.Off;

        public static N0 n0 => default;

        public static N1 n1 => default;

        public static N2 n2 => default;

        public static N3 n3 => default;
        
        public static N4 n4 => default;

        public static N5 n5 => default;

        public static N6 n6 => default;

        public static N7 n7 => default;

        public static N8 n8 => default;
        
        public static N9 n9 => default;
        
        public static N10 n10 => default;
        
        public static N11 n11 => default;

        public static N12 n12 => default;

        public static N13 n13 => default;

        public static N14 n14 => default;

        public static N15 n15 => default;

        public static N16 n16 => default;

        public static N17 n17 => default;

        public static N18 n18 => default;

        public static N19 n19 => default;

        public static N20 n20 => default;

        public static N21 n21 => default;

        public static N22 n22 => default;

        public static N23 n23 => default;

        public static N24 n24 => default;

        public static N25 n25 => default;

        public static N26 N26 => default;

        public static N27 n27 => default;

        public static N28 n28 => default;

        public static N29 n29 => default;

        public static N30 n30 => default;

        public static N31 n31 => default;

        public static N32 n32 => default;

        public static N33 n33 => default;

        public static N34 n34 => default;

        public static N35 n35 => default;

        public static N36 n36 => default;

        public static N37 n37 => default;

        public static N38 n38 => default;

        public static N39 n39 => default;

        public static N40 n40 => default;

        public static N41 N41 => default;

        public static N42 n42 => default;

        public static N43 n43 => default;

        public static N44 n44 => default;

        public static N45 n45 => default;

        public static N46 n46 => default;

        public static N47 n47 => default;

        public static N48 n48 => default;

        public static N49 n49 => default;

        public static N50 n50 => default;

        public static N50 n51 => default;

        public static N52 n52 => default;

        public static N53 n53 => default;

        public static N54 n54 => default;

        public static N55 n55 => default;

        public static N56 n56 => default;

        public static N57 n57 => default;

        public static N58 n58 => default;

        public static N59 n59 => default;

        public static N60 n60 => default;

        public static N61 n61 => default;

        public static N62 n62 => default;

        public static N63 n63 => default;

        public static N64 n64 => default;

        public static N128 n128 => default;

        public static N256 n256 => default;

        public static N512 n512 => default;

        public static N1024 n1024 => default;

        public const sbyte z8i = 0;

        public const byte z8 = 0;

        public const short z16i = 0;

        public const ushort z16 = 0;

        public const int z32i = 0;

        public const uint z32 = 0;

        public const long z64i = 0;

        public const ulong z64 = 0;

        public const float z32f = 0;

        public const double z64f = 0;
 
        public const byte u8max = byte.MaxValue;
 
        public const ushort u16max = ushort.MaxValue;

    }
}