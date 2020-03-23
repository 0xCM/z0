namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;
    using static vgeneric;

    public interface IComparisonService : IService<IComparisonContext>
    {
        void CheckUnaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp128D<T>;

        void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp256D<T>;                

        void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVShiftOp128D<T>;

        void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVShiftOp256D<T>;

        void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVBinaryOp128D<T>;            

        void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVBinaryOp256D<T>;

        void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVTernaryOp128D<T>;

        void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVTernaryOp256D<T>;

        void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : IVBinaryOp128D<T>;    
            
        void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : IVBinaryOp256D<T>;

        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
                    where T : unmanaged
                    where F : IVBinaryOp128<T>;

        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : IVBinaryOp256<T>;

    }
    
    public readonly struct ComparisonService : IComparisonService
    {
        public IComparisonContext Context {get;}

        public ComparisonService(IComparisonContext context)
        {
            this.Context = context;
            this.RepCount = 250;
        }

        public int RepCount {get;}

        public void CheckUnaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp128D<T>
                => Context.UnaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp256D<T>
                => Context.UnaryOpComparer(w,t).CheckScalarMatch(f);
    
        public void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVShiftOp128D<T>
                => Context.ShiftOpComparer(w,t).CheckScalarMatch(f);

        public void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVShiftOp256D<T>
                => Context.ShiftComparer(w,t).CheckScalarMatch(f);

        public void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVBinaryOp128D<T>
                => Context.BinaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVBinaryOp256D<T>
                => Context.BinaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVTernaryOp128D<T>
                => Context.TernaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVTernaryOp256D<T>
                => Context.TernaryOpComparer(w,t).CheckScalarMatch(f);

        public void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : IVBinaryOp128D<T>
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
            where F : IVBinaryOp256D<T>
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
            where F : IVBinaryOp128<T>
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
            where F : IVBinaryOp256<T>
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