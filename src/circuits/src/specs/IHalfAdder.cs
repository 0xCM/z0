//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static SFx;

    public interface IHalfAdder
    {
        ConstPair<Bit32> Invoke(Bit32 a, Bit32 b);

        ConstPair<T> Invoke<T>(T a, T b)
            where T : unmanaged;

        ConstPair<Vector128<T>> Invoke<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged;

        ConstPair<Vector256<T>> Invoke<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged;

        ConstPair<Vector512<T>> Invoke<T>(in Vector512<T> a, in Vector512<T> b)
            where T : unmanaged;
    }

    public interface IHalfAdder<T> :
        IHalfAdder64<T>,
        IHalfAdder128<T>,
        IHalfAdder256<T>,
        IHalfAdder512<T>
            where T : unmanaged
    {

    }

    public interface IHalfAdder<F,T> : IHalfAdder<T>
        where F : unmanaged, IHalfAdder<F,T>
        where T : unmanaged
    {}

    public interface IHalfAdder64<A> : IFunc<A,A,ConstPair<A>>
    {


    }

    public interface IHalfAdderT<A> : IFunc<A,A,ConstPair<A>>
    {


    }

    public interface IHalfAdderIn<A> : IFuncIn<A,A,ConstPair<A>>
    {


    }

    public interface IHalfAdder128<T> :  IHalfAdderT<Vector128<T>>
        where T : unmanaged
    {

    }

    public interface IHalfAdder256<T> : IHalfAdderT<Vector256<T>>
        where T : unmanaged
    {

    }

    public interface IHalfAdder512<T> : IHalfAdderIn<Vector512<T>>
        where T : unmanaged
    {

    }
}