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
            where F : IVShiftOp128D<T>;
    }

    public interface IVShiftOpComparer256D<T> : ISFComparer
        where T : unmanaged
    {
        void CheckScalarMatch<F>(F f)
            where F : IVShiftOp256D<T>;
    }

    public interface IVUnaryOpComparer128D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVUnaryOp128D<T>;
    }

    public interface IVUnaryOpComparer256D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVUnaryOp256D<T>;
    }

    public interface IVBinaryOpComparer128D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVBinaryOp128D<T>;
    }
    
    public interface IVBinaryOpComparer256D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVBinaryOp256D<T>;
    }

    public interface IVTernaryOpComparer128D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVTernaryOp128D<T>;
    }
    

    public interface IVTernaryOpComparer256D<T> : ISFComparer
        where T : unmanaged

    {
        void CheckScalarMatch<F>(F f)
            where F : IVTernaryOp256D<T>;
    }
}