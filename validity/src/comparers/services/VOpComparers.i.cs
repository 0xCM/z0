//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;



    public interface IVShiftOpComparer128D<T> : ISFComparer
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : ISVShiftOp128DApi<T>;
    }

    public interface IVShiftOpComparer256D<T> : ISFComparer
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : ISVShiftOp256DApi<T>;
    }

    public interface IVUnaryOpComparer128D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : ISVUnaryOp128DApi<T>;
    }

    public interface IVUnaryOpComparer256D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : ISVUnaryOp256DApi<T>;
    }

    public interface IVBinaryOpComparer128D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : ISVBinaryOp128DApi<T>;
    }
    
    public interface IVBinaryOpComparer256D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : ISVBinaryOp256DApi<T>;
    }

    public interface IVTernaryOpComparer128D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : ISVTernaryOp128DApi<T>;
    }
    

    public interface IVTernaryOpComparer256D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : ISVTernaryOp256DApi<T>;
    }
}