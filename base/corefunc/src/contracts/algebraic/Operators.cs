//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    public delegate T UnaryOp<T>(T a)
        where T : unmanaged;

    public delegate T BinaryOp<T>(T a, T b)
        where T : unmanaged;

    public delegate T TernaryOp<T>(T a, T b, T c)
        where T : unmanaged;

    public delegate T Shifter<T>(T a, int offset)
        where T : unmanaged;

    public delegate bool UnaryPred<T>(T a)
        where T : unmanaged;

    public delegate bool BinaryPred<T>(T a, T b)
        where T : unmanaged;


    public delegate T UnaryOpIn<T>(in T a)
        where T : unmanaged;

    public delegate T BinaryOpIn<T>(in T a, in T b)
        where T : unmanaged;

    public delegate T TernaryOpIn<T>(in T a, in T b, in T c)
        where T : unmanaged;

    public delegate T ShifterIn<T>(in T a, int offset)
        where T : unmanaged;

    public delegate bool UnaryPredIn<T>(in T a)
        where T : unmanaged;

    public delegate bool BinaryPredIn<T>(in T a, in T b)
        where T : unmanaged;

}