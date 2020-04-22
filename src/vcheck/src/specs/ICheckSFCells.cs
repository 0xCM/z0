namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Vectors;
    using static Typed;

    using K = Kinds;

    /// <summary>
    /// Characterizes a vectorized sfunc decomposition validator
    /// </summary>
    /// <typeparam name="T">The vector cell type</typeparam>
    public interface ICheckSFCells<T> : ICheckSVF<T>
        where T : unmanaged
    {   
    }

    public interface ICheckSFCells : ITestService, ICheckVectors
    {
        ICheckSVF<T> Typed<T>()
            where T : unmanaged
                => Context.Decomposer<T>();

        void CheckUnaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>
                => Typed<T>().Decompose(f, K.UnaryOp, w);
        
        void CheckUnaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>
                => Typed<T>().Decompose(f, K.UnaryOp, w);

        void CheckShiftOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>
                => Context.ShiftOpMatchD(w,t).CheckMatch(f);

        void CheckShiftOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>
                => Context.ShiftOpMatchD(w,t).CheckMatch(f);

        void CheckBinaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
                => Typed<T>().Decompose(f, K.BinaryOp, w);

        void CheckBinaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
                => Typed<T>().Decompose(f, K.BinaryOp, w);

        void CheckTernaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>
                => Context.TernaryOpMatchD(w,t).CheckMatch(f);

        void CheckTernaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>
                => Context.TernaryOpMatchD(w,t).CheckMatch(f);

        void CheckCells<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
        {
            var cells = vcount<T>(n128);
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();
            try
            {
                for(var i=0; i < RepCount; i++)
                {
                    (var x, var y) = src(i);
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
                Context.ReportCaseResult(casename,succeeded,count);
            }
        }
            
        void CheckCells<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
        {
            var cells = vcount<T>(n256);
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();
            try
            {
                for(var i=0; i < RepCount; i++)
                {
                    (var x, var y) = src(i);
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
                Context.ReportCaseResult(casename,succeeded,count);
            }
        }       

        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp128Api<T>
        {
            var casename = name ?? Context.CaseName(f);
            var w = n128;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var blocks = left.BlockCount;
            var count = time.counter();

            count.Start();
            try
            {
                for(var block=0; block<blocks; block++)
                {
                    var x = left.LoadVector(block);
                    var y = right.LoadVector(block);
                    var actual = f.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    eq(actual, expect);
                }
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename, succeeded,count);
            }
        }

        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>
        {
            var casename = name ?? Context.CaseName(f);
            var w = n256;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var blocks = left.BlockCount;
            var count = time.counter();
            
            count.Start();
            try
            {
                for(var block=0; block<blocks; block++)
                {
                    var x = left.LoadVector(block);
                    var y = right.LoadVector(block);
                    var actual = f.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    eq(actual, expect);
                }
            }
            catch(Exception e)
            {
                term.errlabel(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }
        }
    }

    public readonly struct CheckDecomposition : ICheckSFCells
    {

        public ITestContext Context {get;}

        public CheckDecomposition(ITestContext context)
        {
            this.Context = context;
        }
    }    
}