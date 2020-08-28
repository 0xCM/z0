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
    using static z;

    public interface IFieldEncoder<S,T>
        where S : struct
    {
        Outcome<T> Encode(in S Src, FieldInfo f);
    }
}