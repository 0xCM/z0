//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface IClrTable<T> : ITable<T>
        where T : struct, IClrTable<T>
    {
    }

    public interface IClrTable<H,T> : IClrTable<T>
        where T : struct, IClrTable<T>
        where H : struct, IClrTable<H,T>
    {

    }
}