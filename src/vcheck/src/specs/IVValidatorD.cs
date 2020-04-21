//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISVShiftMatch128D<T> : ISFCheck
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVShiftOp128DApi<T>;
    }

    public interface IVShiftMatch256D<T> : ISFCheck
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVShiftOp256DApi<T>;
    }

    public interface IVUnaryOpMatch128D<T> : ISFCheck
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVUnaryOp128DApi<T>;
    }

    public interface ISVUnaryOpMatch256D<T> : ISFCheck
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVUnaryOp256DApi<T>;
    }

    public interface ISVBinaryOpMatch128D<T> : ISFCheck
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVBinaryOp128DApi<T>;
    }
    
    public interface ISVBinaryOpMatch256D<T> : ISFCheck
        where T : unmanaged

    {
        void CheckMatch<F>(F f)
            where F : ISVBinaryOp256DApi<T>;
    }

    public interface ISVTernaryOpMatch128D<T> : ISFCheck
        where T : unmanaged

    {
        void CheckMatch<F>(F f)
            where F : ISVTernaryOp128DApi<T>;
    }
    
    public interface ISVTernaryOpMatch256D<T> : ISFCheck
        where T : unmanaged

    {
        void CheckMatch<F>(F f)
            where F : ISVTernaryOp256DApi<T>;
    }
}