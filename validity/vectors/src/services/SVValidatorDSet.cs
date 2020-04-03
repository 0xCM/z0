//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static VCore;

    using C = OpClass;

    class SVValidatorD<T> : ISVFDecomposer<T>
        where T : unmanaged
    {   
        public IValidationContext Context {get;}

        public IPolyrand Random {get;}

        int RepCount {get;}

        static T t => default;

        public SVValidatorD(ITestContext context)
        {
            this.Context = ValidationContext.From(context);
            this.Random = context.Random;
        }

        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        static int components<W>(W w = default)
            where W : struct, ITypeWidth
                => ((int)default(W).TypeWidth)/bitsize<T>();

        static string CaseName<W>(IValidationContext context, ISFuncApi f)
            where W : unmanaged, ITypeWidth
        {
            var id = Identify.Op<W,T>(f.Id.Name);
            var owner = Identify.Owner(context.HostType);
            var host = context.HostType.Name;
            return $"{owner}/{host}/{id}";            
        }

        public void Validate<F>(F f, C.UnaryOp op, W128 w)
            where F : ISVUnaryOp128DApi<T>
        {            
            void run()
            {
                var cells = components(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        CheckNumeric.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            
            Run(f, run, w, op.Generalized);
        }

        public void Validate<F>(F f, C.UnaryOp op,  W256 w)
            where F : ISVUnaryOp256DApi<T>
        {

            void run()
            {
                var cells = components(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        CheckNumeric.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        public void Validate<F>(F f, C.BinaryOp op,  W128 w)
            where F : ISVBinaryOp128DApi<T>
        {
            void run()
            {
                var cells = components(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        CheckNumeric.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        public void Validate<F>(F f, C.BinaryOp op,  W256 w)
            where F : ISVBinaryOp256DApi<T>
        {
            void run()
            {
                var cells = components(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        CheckNumeric.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        void Validate<F>(F f, object marker, W128 w)
            where F : ISVShiftOp128DApi<T>
        {
            var t = default(T);
            var bounds = ((byte)0, (byte)(bitsize<T>() - 1));

            void run()
            {
                var cells = components(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
        }

        void Validate<F>(F f, object marker, W256 w)
            where F : ISVShiftOp256DApi<T>
        {
            var t = default(T);
            var bounds = ((byte)0, (byte)(bitsize<T>() - 1));

            void run()
            {
                var cells = components(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
        }

        void Run<W>(ISFuncApi f, Action act, W width, C.OperatorClass c)
            where W : unmanaged, ITypeWidth
        {
            var succeeded = true;
            var casename = Context.CaseName(f,width, default(T));
            var clock = time.counter();

            clock.Start();
            try
            {
                act();
            }
            catch(Exception e)
            {
                term.error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,clock);
            }
        }
    }   
}