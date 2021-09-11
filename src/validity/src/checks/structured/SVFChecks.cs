//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static cpu;

    using K = OperatorClasses;

    [ApiHost]
    public class SVFChecks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        internal static TestCaseRecord TestCase(string casename, bool succeeded, TimeSpan duration)
            => TestCaseRecord.define(casename, succeeded, duration);

        public static SVFChecks create(IWfRuntime wf)
            => new SVFChecks(wf, Rng.wyhash64());

        [MethodImpl(Inline), Op]
        public static SVFChecks create(IWfRuntime wf, IPolyrand rng)
            => new SVFChecks(wf, rng);

        public static SVFChecks<T> create<T>(IWfRuntime wf)
            where T : unmanaged
                => new SVFChecks<T>(wf, Rng.wyhash64());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SVFChecks<T> create<T>(IWfRuntime wf, IPolyrand rng)
            where T : unmanaged
                => new SVFChecks<T>(wf, rng);

        readonly IWfRuntime Wf;

        readonly IPolyrand Random;

        public uint RepCount {get;}

        [MethodImpl(Inline)]
        internal SVFChecks(IWfRuntime wf, IPolyrand rng)
        {
            Wf = wf;
            Random = rng;
            RepCount = Pow2.T10;
        }

        void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
        {
            var record = SVFChecks.TestCase(casename, succeeded, duration);
            var content = TestCaseRecord.FormatFunction(record);
            Wf.Row(content);
        }

        [MethodImpl(Inline)]
        public SVFChecks<T> Checker<T>()
            where T : unmanaged
                => create<T>(Wf,Random);

       [Op, Closures(Closure)]
       public bit CheckSVF<T>(IBinaryOp128D<T> f)
            where T : unmanaged
        {
            var t = default(T);
            var w = w128;
            var cells = vcount(w,t);
            var succeeded = bit.On;
            var casename = SFx.name(f);
            var clock = Time.counter(true);
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                    {
                        var same = gmath.eq(f.Invoke(vcell(x,j), vcell(y,j)), vcell(z,j));
                        succeeded &= same;
                    }
                }
            }
            catch(Exception e)
            {
                Wf.Error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportCaseResult(casename, succeeded, clock);
            }
            return succeeded;
        }
    }

    public class SVFChecks<T>
        where T : unmanaged
    {
        readonly IWfRuntime Wf;

        public IPolyrand Random {get;}

        public uint RepCount {get;}

        [MethodImpl(Inline)]
        internal SVFChecks(IWfRuntime wf, IPolyrand rng)
        {
            Wf = wf;
            Random = rng;
            RepCount = Pow2.T10;
        }

        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public int CellCount<W>(W w = default)
            where W : struct, ITypeWidth
                => ((int)default(W).TypeWidth)/BitWidth.measure<T>();

        void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
        {
            var record = SVFChecks.TestCase(casename, succeeded, duration);
            var content = TestCaseRecord.FormatFunction(record);
            Wf.Row(content);
        }

        public bit CheckSVF(IBinaryOp128D<T> f)
        {
            var t = default(T);
            var w = w128;
            var cells = vcount(w,t);
            var succeeded = bit.On;
            var casename = SFx.name(f);
            var clock = Time.counter(true);
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                    {
                        var same = gmath.eq(f.Invoke(vcell(x,j), vcell(y,j)), vcell(z,j));
                        succeeded &= same;
                    }
                }
            }
            catch(Exception e)
            {
                Wf.Error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportCaseResult(casename, succeeded, clock);
            }
            return succeeded;
        }

        public bit Run<W>(IFunc f, Func<bit> runner, W width, OperatorClass c)
            where W : unmanaged, ITypeWidth
        {
            var casename = SFx.name<W,T>(typeof(T), f);
            var clock = Time.counter();
            var result = bit.Off;
            clock.Start();
            try
            {
                result = runner();
            }
            catch(Exception e)
            {
                Wf.Error(e, casename);
            }
            finally
            {
                ReportCaseResult(casename,result,clock);
            }
            return result;
        }

        public bit CheckUnaryOp<F>(W128 w, F f)
            where F : IUnaryOp128D<T>
                => CheckSVF(w, f, K.unary());

        public bit CheckUnaryOp<F>(W256 w, F f)
            where F : IUnaryOp256D<T>
                => CheckSVF(w, f, K.unary());

        public bit CheckShiftOp<F>(W128 w, F f)
            where F : IShiftOp128D<T>
                => CheckSVF(w, f, K.shift());

        public bit CheckShiftOp<F>(W256 w, F f)
            where F : IShiftOp256D<T>
                => CheckSVF(w, f, K.shift());

        public bit CheckBinaryOp<F>(W128 w, F f)
            where F : IBinaryOp128D<T>
                => CheckSVF(w, f, K.binary());

        public bit CheckBinaryOp<F>(W256 w, F f)
            where F : IBinaryOp256D<T>
                => CheckSVF(w, f, K.binary());

        public bit CheckTernaryOp<F>(W128 w, F f)
            where F : ITernaryOp128D<T>
                => CheckSVF(w, f, K.ternary());

        public bit CheckTernaryOp<F>(W256 w, F f)
            where F : ITernaryOp256D<T>
                => CheckSVF(w, f, K.ternary());

        /// <summary>
        /// Validates a 128-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        public bit CheckSVF<F>(W128 w, F f, UnaryOperatorClass op)
            where F : IUnaryOp128D<T>
        {
            var t = default(T);
            bit run()
            {
                var cells = CellCount(w);
                var result = bit.On;
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(x,j)), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 256-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        public bit CheckSVF<F>(W256 w, F f, UnaryOperatorClass op)
            where F : IUnaryOp256D<T>
        {

            var t = default(T);
            bit run()
            {
                var result = bit.On;
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(x,j)), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 128-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        public bit CheckSVF<F>(W128 w, F f, BinaryOperatorClass op)
            where F : IBinaryOp128D<T>
        {
            var t = default(T);

            bit run()
            {
                var result = bit.On;
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 256-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="k">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        public bit CheckSVF<F>(W256 w, F f, BinaryOperatorClass k)
            where F : IBinaryOp256D<T>
        {
            var t = default(T);

            bit run()
            {
                var cells = CellCount(w);
                var result = bit.On;
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, k.Classifier);
        }

        /// <summary>
        /// Validates a 128-bit ternary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        public bit CheckSVF<F>(W128 w, F f,TernaryOperatorClass op)
            where F : ITernaryOp128D<T>
        {
            var t = default(T);

            bit run()
            {
                var result = bit.On;
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var a = Random.CpuVector(w,t);
                    var b = Random.CpuVector(w,t);
                    var c = Random.CpuVector(w,t);

                    var z = f.Invoke(a,b,c);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(a,j),vcell(b,j),vcell(c,j)), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 256-bit ternary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        public bit CheckSVF<F>(W256 w, F f, TernaryOperatorClass op)
            where F : ITernaryOp256D<T>
        {
            var t = default(T);

            bit run()
            {
                var result = bit.On;
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var a = Random.CpuVector(w,t);
                    var b = Random.CpuVector(w,t);
                    var c = Random.CpuVector(w,t);

                    var z = f.Invoke(a,b,c);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(a,j),vcell(b,j),vcell(c,j)), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, op.Classifier);
        }

        public bit CheckSVF<F>(W128 w, F f, ShiftOperatorClass k)
            where F : IShiftOp128D<T>
        {
            var t = default(T);
            ClosedInterval<byte> bounds = ((byte)0, (byte)(BitWidth.measure<T>() - 1));

            bit run()
            {
                var result = bit.On;
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(x,j), offset), vcell(z,j));
                }
                return result;
            }

            return Run(f, run, w, k.Classifier);
        }

        public bit CheckSVF<F>(W256 w, F f, ShiftOperatorClass k)
            where F : IShiftOp256D<T>
        {
            var t = default(T);
            ClosedInterval<byte> bounds = ((byte)0, (byte)(BitWidth.measure<T>() - 1));

            bit run()
            {
                var result = bit.On;
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(byte j=0; j< cells; j++)
                        result &= gmath.eq(f.Invoke(vcell(x,j), offset), vcell(z,j));
                }
                return result;
           }

            return Run(f, run, w, k.Classifier);
        }
    }
}