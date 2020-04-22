//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Vectors;

    using K = Kinds;

    class SVValidatorD<T> : ICheckSVF<T>
        where T : unmanaged
    {   
        public ITestContext Context {get;}

        public IPolyrand Random {get;}

        protected ICheckNumeric Check => CheckNumeric.Checker;

        int RepCount {get;}

        static T t => default;

        public SVValidatorD(ITestContext context)
        {
            this.Context = context;
            this.Random = context.Random;
        }

        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        static int CellCount<W>(W w = default)
            where W : struct, ITypeWidth
                => ((int)default(W).TypeWidth)/BitSize.measure<T>();

        public void Decompose<F>(F f, K.UnaryOpClass op, W128 w)
            where F : ISVUnaryOp128DApi<T>
        {            
            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Check.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            
            Run(f, run, w, op.Generalized);
        }

        public void Decompose<F>(F f, K.UnaryOpClass op,  W256 w)
            where F : ISVUnaryOp256DApi<T>
        {

            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Check.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        public void Decompose<F>(F f, K.BinaryOpClass op,  W128 w)
            where F : ISVBinaryOp128DApi<T>
        {
            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Check.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        public void Decompose<F>(F f, K.BinaryOpClass op,  W256 w)
            where F : ISVBinaryOp256DApi<T>
        {
            void run()
            {
                var cells = CellCount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Check.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        void Validate<F>(F f, object marker, W128 w)
            where F : ISVShiftOp128DApi<T>
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
                        Check.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
        }

        void Validate<F>(F f, object marker, W256 w)
            where F : ISVShiftOp256DApi<T>
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
                        Check.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
        }

        void Run<W>(ISFuncApi f, Action act, W width, K.OperatorClass c)
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
    }   
}