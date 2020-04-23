//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using K = Kinds;

    readonly struct CheckSVF<T> : ICheckSVF<T>
        where T : unmanaged
    {   
        public ITestContext Context {get;}

        public static CheckSVF<T> Create(ITestContext context)
            => new CheckSVF<T>(context);

        public CheckSVF(ITestContext context)
        {
            this.Context = context;
        }        
    }   

    public interface ICheckSVF<T> : ICheckSF, ICheckBinarySVFD<W128,ISVBinaryOp128D<T>,T> 
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

        void ICheckBinarySVFD<W128,ISVBinaryOp128D<T>,T>.CheckSVF(ISVBinaryOp128D<T> f)
        {
            var t = default(T);
            var w = w128;
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            var clock = counter();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
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

       void Run<W>(ISFunc f, Action act, W width, K.OperatorClass c)
            where W : unmanaged, ITypeWidth
        {
            var succeeded = true;
            var casename = Context.CaseName<W,T>(f);
            var clock = time.counter();

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
        void CheckSVF<F>(F f, K.UnaryOpClass op, W128 w)
            where F : ISVUnaryOp128D<T>
        {            
            var t = default(T);
            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            
            Run(f, run, w, op.Generalized);
        }

        /// <summary>
        /// Validates a 256-bit unary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, K.UnaryOpClass op, W256 w)
            where F : ISVUnaryOp256D<T>
        {

            var t = default(T);

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        /// <summary>
        /// Validates a 128-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, K.BinaryOpClass op, W128 w)
            where F : ISVBinaryOp128D<T>
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
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        /// <summary>
        /// Validates a 256-bit binary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="k">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, K.BinaryOpClass k, W256 w)
            where F : ISVBinaryOp256D<T>
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
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, k.Generalized);
        }

        /// <summary>
        /// Validates a 128-bit ternary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, K.TernaryOpClass op, W128 w)
            where F : ISVTernaryOp128D<T>
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
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(a,j),vcell(b,j),vcell(c,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        /// <summary>
        /// Validates a 256-bit ternary operator via cellular decomposition
        /// </summary>
        /// <param name="f">The function</param>
        /// <param name="op">The operator arity selector</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="F">The function type</typeparam>
        void CheckSVF<F>(F f, K.TernaryOpClass op, W256 w)
            where F : ISVTernaryOp256D<T>
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
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(a,j),vcell(b,j),vcell(c,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        void CheckSVF<F>(F f, K.ShiftOpClass k, W128 w)
            where F : ISVShiftOp128D<T>
        {
            var t = default(T);
            var bounds = ((byte)0, (byte)(BitSize.measure<T>() - 1));

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }

            Run(f, run, w, k.Generalized);
        }

        void CheckSVF<F>(F f, K.ShiftOpClass k, W256 w)
            where F : ISVShiftOp256D<T>
        {
            var t = default(T);
            var bounds = ((byte)0, (byte)(BitSize.measure<T>() - 1));

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }

            Run(f, run, w, k.Generalized);
        }        
    }
}