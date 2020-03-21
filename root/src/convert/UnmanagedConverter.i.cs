//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IUnmanagedConveter : IConverter
    {

    }


    public interface IUnmanagedConveter<in S, out T> : IUnmanagedConveter, IConverter<S,T>
        where S: unmanaged
        where T: unmanaged
    {
        
    }

    public interface IUnmanagedConverter<S> : IBiconverter<S>
        where S : unmanaged
    {
        T Convert<T>(S incoming)
            where T : unmanaged;
        
        S Convert<T>(T incoming)
            where T : unmanaged;        
    }

    public interface IUnmanagedConversionProvider<C,S> : IConversionProvider<S>, IUnmanagedConverter<S>
        where S : unmanaged
        where C : IUnmanagedConverter<S>
    {
        new C Converter {get;}

        IBiconverter<S> IConversionProvider<S>.Converter
            => Converter;
    }    

    public interface IUnmanagedConverter<P,S> : IUnmanagedConverter<S>, IUnmanagedConversionProvider<P,S>
        where S : unmanaged
        where P : struct, IUnmanagedConverter<P,S>
    {
        P IUnmanagedConversionProvider<P,S>.Converter {[MethodImpl(Inline)] get => default(P);}
    }


    public interface IValueConverter<P,S> : IValueConverter<S>, IValueConversionProvider<P,S>
        where S : struct
        where P : struct, IValueConverter<P,S>
    {
        P IValueConversionProvider<P,S>.Converter {[MethodImpl(Inline)] get => default(P);}
    }
}