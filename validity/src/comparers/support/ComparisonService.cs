namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;
    using static vgeneric;

    public interface IComparisonService : IService<IValidationContext>
    {
        void CheckUnaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>;

        void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>;                

        void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>;

        void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>;

        void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>;            

        void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>;

        void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>;

        void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>;

        void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>;    
            
        void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>;

        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
                    where T : unmanaged
                    where F : ISVBinaryOp128Api<T>;

        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>;

    }
    
    public readonly struct ComparisonService : IComparisonService
    {
        public IValidationContext Context {get;}

        public ComparisonService(IValidationContext context)
        {
            this.Context = context;
            this.RepCount = 250;
        }

        public int RepCount {get;}

        public void CheckUnaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>
                => Context.UnaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>
                => Context.UnaryOpComparer(w,t).CheckScalarMatch(f);
    
        public void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>
                => Context.ShiftOpComparer(w,t).CheckScalarMatch(f);

        public void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>
                => Context.ShiftComparer(w,t).CheckScalarMatch(f);

        public void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
                => Context.BinaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
                => Context.BinaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>
                => Context.TernaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>
                => Context.TernaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
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
                        Checks.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,count);
            }
        }

        public void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
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
                        Checks.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,count);
            }
        }       

        public void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
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
                    Checks.eq(actual,expect);
                }
            }
            catch(Exception e)
            {
                term.error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename, succeeded,count);
            }
        }

        public void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
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
                    Checks.eq(actual,expect);
                }
            }
            catch(Exception e)
            {
                term.error(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,count);
            }
        }
    }
}