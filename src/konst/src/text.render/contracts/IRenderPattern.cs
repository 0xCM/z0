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

    public interface IRenderPattern<H,T> : IRenderMap<T>
        where H : struct, IRenderPattern<H,T>
    {

    }

    public interface IRenderPattern<H,A0,A1> : IRenderMap<A0,A1>
        where H : struct, IRenderPattern<H,A0,A1>
    {

    }

    public interface IRenderPattern<H,A0,A1,A2> : IRenderMap<A0,A1,A2>
        where H : struct, IRenderPattern<H,A0,A1,A2>
    {

    }
}