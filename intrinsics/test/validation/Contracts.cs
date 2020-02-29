//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public interface IVShiftValidator128D<T> : IValidator
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : IVShiftOp128D<T>;
    }

    public interface IVShiftValidator256D<T> : IValidator
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : IVShiftOp256D<T>;
    }

    public interface IVUnaryValidator128D<T> : IValidator
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVUnaryOp128D<T>;
    }

    public interface IVUnaryValidator256D<T> : IValidator
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVUnaryOp256D<T>;
    }

    public interface IVBinaryValidator128D<T> : IValidator
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVBinOp128D<T>;
    }
    
    public interface IVBinaryValidator256D<T> : IValidator
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVBinOp256D<T>;
    }

    public interface IVTernaryValidator128D<T> : IValidator
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVTernaryOp128D<T>;
    }
    

    public interface IVTernaryValidator256D<T> : IValidator
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVTernaryOp256D<T>;
    }
}