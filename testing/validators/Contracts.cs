//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public interface IUnaryValidator<T1,T2>
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1, T2>
            where G : IUnaryFunc<T1, T2>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1, T2>
            where G : IUnaryFunc<T1, T2>;        
    }

    public interface ITernaryValidator<T1,T2,T3,T4>
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : ITernaryFunc<T1,T2,T3,T4>
            where G : ITernaryFunc<T1,T2,T3,T4>;

        void CheckSpan<F, G>(F baseline, G subject)
            where F : ITernaryFunc<T1,T2,T3,T4>
            where G : ITernaryFunc<T1,T2,T3,T4>;        
    }

    public interface IBinaryValidator<T1,T2,T3>
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        
    }

    public interface IVShiftValidator128D<T>
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : IVShiftOp128D<T>;
    }

    public interface IVShiftValidator256D<T>
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : IVShiftOp256D<T>;
    }

    public interface IVUnaryValidator128D<T>
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVUnaryOp128D<T>;
    }

    public interface IVUnaryValidator256D<T>
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVUnaryOp256D<T>;
    }

    public interface IVBinaryValidator128D<T>
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVBinOp128D<T>;
    }
    
    public interface IVBinaryValidator256D<T>
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVBinOp256D<T>;
    }

    public interface IVTernaryValidator128D<T>
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVTernaryOp128D<T>;
    }
    

    public interface IVTernaryValidator256D<T>
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVTernaryOp256D<T>;
    }

}