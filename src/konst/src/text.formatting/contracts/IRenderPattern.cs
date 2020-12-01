//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IRenderPattern
    {
        string PatternText {get;}

        byte ArgCount {get;}

        ReadOnlySpan<Type> ArgTypes {get;}
    }

    public interface IRenderPattern<H,T> : IRenderPattern
        where H : struct, IRenderPattern<H,T>
    {
        string Format(in T a0);

        RenderCapture Capture(in T a0);

        byte IRenderPattern.ArgCount => 1;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => z.array(typeof(T));
    }

    public interface IRenderPattern<H,A0,A1> : IRenderPattern
        where H : struct, IRenderPattern<H,A0,A1>
    {
        string Format(in A0 a0, in A1 a1);

        byte IRenderPattern.ArgCount => 2;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => z.array(typeof(A0), typeof(A1));
    }

    public interface IRenderPattern<H,A0,A1,A2> : IRenderPattern
        where H : struct, IRenderPattern<H,A0,A1,A2>
    {
        string Format(in A0 a0, in A1 a1, in A2 a2);

        RenderCapture Capture(in A0 a0, in A1 a1, in A2 a2);

        byte IRenderPattern.ArgCount => 3;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => z.array(typeof(A0), typeof(A1), typeof(A2));
    }

    public interface IRenderPattern<H,A0,A1,A2,A3> : IRenderPattern
        where H : struct, IRenderPattern<H,A0,A1,A2,A3>
    {
        string Format(in A0 a0, in A1 a1, in A2 a2, in A3 a3);

        RenderCapture Capture(in A0 a0, in A1 a1, in A2 a2, in A3 a3);

        byte IRenderPattern.ArgCount => 4;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => z.array(typeof(A0), typeof(A1), typeof(A2), typeof(A3));
    }

    public interface IRenderPattern<H,A0,A1,A2,A3,A4> : IRenderPattern
        where H : struct, IRenderPattern<H,A0,A1,A2,A3,A4>
    {
        string Format(in A0 a0, in A1 a1, in A2 a2, in A3 a3, in A4 a4);

        byte IRenderPattern.ArgCount => 5;

        ReadOnlySpan<Type> IRenderPattern.ArgTypes
            => z.array(typeof(A0), typeof(A1), typeof(A2), typeof(A3), typeof(A4));
    }
}