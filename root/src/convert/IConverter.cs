//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IBoxedConverter
    {
        object Convert(object src);
        
    }

    public interface IConverter<in S, out T>
    {
        T Convert(S src);

    }

    public interface IValueConveter<in S, out T> : IConverter<S,T>
        where S: struct
        where T: struct
    {
        
    }

    public interface IUnmanagedConveter<in S, out T> : IConverter<S,T>
        where S: unmanaged
        where T: unmanaged
    {
        
    }

}