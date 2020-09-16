//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface IRenderMap<T> : IRenderPattern
    {
        string Apply(in T a0);

        byte IRenderPattern.ArgCount => 1;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => array(typeof(T));
    }

    public interface IRenderMap<A0,A1> : IRenderPattern
    {
        string Apply(in A0 a0, in A1 a1);

        byte IRenderPattern.ArgCount => 2;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => array(typeof(A0), typeof(A1));
    }

    public interface IRenderMap<A0,A1,A2> : IRenderPattern
    {
        string Apply(in A0 a0, in A1 a1, in A2 a2);

        byte IRenderPattern.ArgCount => 3;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => array(typeof(A0), typeof(A1), typeof(A2));
    }

    public interface IRenderMap<A0,A1,A2,A3> : IRenderPattern
    {
        string Apply(in A0 a0, in A1 a1, in A2 a2, in A3 a3);

        byte IRenderPattern.ArgCount => 4;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => array(typeof(A0), typeof(A1), typeof(A2), typeof(A3));
    }
}