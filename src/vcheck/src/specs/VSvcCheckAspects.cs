//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Seed;

    public interface IVSvcCheck : IService<IVSvcCheckContext>
    {
        ICheckSFCells Decomposer => Context.Decomposer;

        [MethodImpl(Inline)]
        void CheckUnaryDecomp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>
                => Decomposer.CheckUnaryOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckUnaryDecomp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>
                => Decomposer.CheckUnaryOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckShiftDecomp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>
                => Decomposer.CheckShiftOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckShiftDecomp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>
                => Decomposer.CheckShiftOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckBinaryDecomp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
                => Decomposer.CheckBinaryOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckBinaryDecomp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
                => Decomposer.CheckBinaryOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckTernaryDecomp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>
                => Decomposer.CheckTernaryOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckTernaryDecomp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>
                => Decomposer.CheckTernaryOp(f,w,t);

        [MethodImpl(Inline)]
        void CheckDecomp<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
                => Decomposer.CheckCells(f,src);
                
        [MethodImpl(Inline)]
        void CheckDecomp<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
                => Decomposer.CheckCells(f,src);

        [MethodImpl(Inline)]
        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp128Api<T>
                => Decomposer.CheckExplicit(f,left,right,dst,name);

        [MethodImpl(Inline)]
        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>
                => Decomposer.CheckExplicit(f,left,right,dst,name);
    }
}