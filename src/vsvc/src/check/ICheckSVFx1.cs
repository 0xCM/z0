//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CheckSVF<T> : ICheckSVF<T>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public CheckSVF(ITestContext context)
            => Context = context;

    }

    public interface ICheckSVF<T> : ICheckSF, ICheckBinarySVFD<W128,IBinaryOp128D<T>,T>
        where T : unmanaged
    {
        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        int CellCount<W>(W w = default)
            where W : struct, ITypeWidth
                => ((int)default(W).TypeWidth)/BitSize.measure<T>();

        void ICheckBinarySVFD<W128,IBinaryOp128D<T>,T>.CheckSVF(IBinaryOp128D<T> f)
        {
            var t = default(T);
            var w = w128;
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = ApiTestIdentity.name(f);
            var clock = Time.counter(true);

            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,clock);
            }
        }

       void Run<W>(IFunc f, Action act, W width, OperatorClass c)
            where W : unmanaged, ITypeWidth
        {
            var succeeded = true;
            var casename = Context.CaseName<W,T>(f);
            var clock = Time.counter();

            clock.Start();
            try
            {
                act();
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,clock);
            }
        }

        /// <summary>
        /// Validates a 128-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, UnaryOpClass op, W128 w)
            where F : IUnaryOp128D<T>
        {
            var t = default(T);
            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 256-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, UnaryOpClass op, W256 w)
            where F : IUnaryOp256D<T>
        {

            var t = default(T);

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 128-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, BinaryOpClass op, W128 w)
            where F : IBinaryOp128D<T>
        {
            var t = default(T);

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 256-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="k">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, BinaryOpClass k, W256 w)
            where F : IBinaryOp256D<T>
        {
            var t = default(T);

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, k.Classifier);
        }

        /// <summary>
        /// Validates a 128-bit ternary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f,TernaryOpClass op, W128 w)
            where F : ITernaryOp128D<T>
        {
            var t = default(T);

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var a = Random.CpuVector(w,t);
                    var b = Random.CpuVector(w,t);
                    var c = Random.CpuVector(w,t);

                    var z = f.Invoke(a,b,c);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(a,j),vcell(b,j),vcell(c,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Classifier);
        }

        /// <summary>
        /// Validates a 256-bit ternary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, TernaryOpClass op, W256 w)
            where F : ITernaryOp256D<T>
        {
            var t = default(T);

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var a = Random.CpuVector(w,t);
                    var b = Random.CpuVector(w,t);
                    var c = Random.CpuVector(w,t);

                    var z = f.Invoke(a,b,c);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(a,j),vcell(b,j),vcell(c,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Classifier);
        }

        void CheckSVF<F>(F f, ShiftOpClass k, W128 w)
            where F : IShiftOp128D<T>
        {
            var t = default(T);
            ClosedInterval<byte> bounds = ((byte)0, (byte)(BitSize.measure<T>() - 1));

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j), offset), vcell(z,j));
                }
            }

            Run(f, run, w, k.Classifier);
        }

        void CheckSVF<F>(F f, ShiftOpClass k, W256 w)
            where F : IShiftOp256D<T>
        {
            var t = default(T);
            ClosedInterval<byte> bounds = ((byte)0, (byte)(BitSize.measure<T>() - 1));

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(byte j=0; j< cells; j++)
                        eq(f.Invoke(vcell(x,j), offset), vcell(z,j));
                }
            }

            Run(f, run, w, k.Classifier);
        }
    }
}