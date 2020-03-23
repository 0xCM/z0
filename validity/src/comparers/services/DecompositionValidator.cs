//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Root;
    using static Validity;
    using static vgeneric;

    using C = OperationClasses;


    public interface IValidator : IService<IValidationContext>
    {

    }

    public interface IDecompositionValidator<T> : IValidator
        where T : unmanaged
    {   
        
    }

    public class DecompositionValidiator<T> : IDecompositionValidator<T>
        where T : unmanaged
    {   
        public IValidationContext Context {get;}

        public IPolyrand Random {get;}

        int RepCount {get;}

        static T t => default;

        public DecompositionValidiator(IValidationContext context)
        {
            this.Context = context;
            this.Random = context.Random;

        }

        public void Validate<F>(F f, C.UnaryOp op, W128 w)
            where F : IVUnaryOp128D<T>
        {            
            void run()
            {
                var cells = vcount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.numeq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            
            Run(f, run, w, op.Generalized);
        }

        public void Validate<F>(F f, C.UnaryOp op,  W256 w)
            where F : IVUnaryOp256D<T>
        {

            void run()
            {
                var cells = vcount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.numeq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        public void Validate<F>(F f, C.BinaryOp op,  W128 w)
            where F : IVBinaryOp128D<T>
        {
            void run()
            {
                var cells = vcount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.numeq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        public void Validate<F>(F f, C.BinaryOp op,  W256 w)
            where F : IVBinaryOp256D<T>
        {
            void run()
            {
                var cells = vcount(w);
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.numeq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }

            Run(f, run, w, op.Generalized);
        }

        void Run<W>(IFunc f, Action act, W width, C.OperatorClass c)
            where W : struct, ITypeWidth
        {
            var succeeded = true;
            var casename = CaseName<W>(f);
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

        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        static int vcount<W>(W w = default)
            where W : struct, ITypeWidth
                => default(W).BitWidth/bitsize<T>();

        string CaseName<W>(IFunc f)
            where W : struct, ITypeWidth
        {
            var id = OpIdentity.operation(f.Id.Name, default(W).Class, NumericIdentity.kind<T>(),true);
            var owner = TypeIdentity.owner(Context.HostType);
            var host = Context.HostType.Name;
            return $"{owner}/{host}/{id}";            
        }
    }   
}