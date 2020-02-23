//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IConverter
    {
        
    }
    
    public interface IConverter<in S, out T> : IConverter
    {
        T Convert(S src);

    }

    public interface IObjectConverter : IConverter
    {

    }

    public interface ObjectConveter<in S, out T> : IValueConverter, IConverter<S,T>
        where S: class
        where T: class
    {
        
    }

    public interface IValueConverter : IConverter
    {

    }

    public interface IValueConveter<in S, out T> : IValueConverter, IConverter<S,T>
        where S: struct
        where T: struct
    {
        
    }

    public interface IUnmanagedConveter : IConverter
    {

    }


    public interface IUnmanagedConveter<in S, out T> : IUnmanagedConveter, IConverter<S,T>
        where S: unmanaged
        where T: unmanaged
    {
        
    }

    public interface IConversionProvider
    {

    }
    
    public interface IUnmanagedConversionProvider<C,S> : IConversionProvider
        where S : unmanaged
        where C : IUnmanagedConverter<S>
    {
        C Converter {get;}
    }

    public interface IConverter<S> : IConverter
    {
        T Convert<T>(S src);
        
        S Convert<T>(T src);
    }

    public interface IValueConverter<S> : IConverter
        where S : struct
    {
        T Convert<T>(S src)
            where T : struct;
        
        S Convert<T>(T src)
            where T : struct;
    }


    public interface IUnmanagedConverter<S> : IConverter
        where S : unmanaged
    {
        T Convert<T>(S src)
            where T : unmanaged;
        
        S Convert<T>(T src)
            where T : unmanaged;        
    }
}