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

    public interface IValueConversionProvider<C,S> : IConversionProvider
        where S : struct
        where C : IValueConverter<S>
    {
        C Converter {get;}
    }


    public interface IUnmanagedConversionProvider<C,S> : IConversionProvider
        where S : unmanaged
        where C : IUnmanagedConverter<S>
    {
        C Converter {get;}
    }

    public interface IBiconverter : IConverter
    {
        /// <summary>
        /// The supported type
        /// </summary>
        Type TargetType {get;}
        
        /// <summary>
        /// Converts an incoming value to a value of target type, if possible
        /// </summary>
        /// <param name="incoming">The value to conver</param>
        Option<object> ConvertToTarget(object incoming);
        
        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        Option<object> ConvertFromTarget(object incoming, Type dst);
    }

    public interface IBiconverter<S> : IBiconverter
    {
        Type IBiconverter.TargetType => typeof(S);

    }

    public interface IValueConverter<S> : IBiconverter<S>
        where S : struct
    {
        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        T Convert<T>(S incoming)
            where T : struct;
        
        /// <summary>
        /// converts an incoming value to a value of target type
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        /// <typeparam name="T">The incoming value type</typeparam>
        S Convert<T>(T incoming)
            where T : struct;
    }

    public interface IUnmanagedConverter<S> : IBiconverter<S>
        where S : unmanaged
    {
        T Convert<T>(S incoming)
            where T : unmanaged;
        
        S Convert<T>(T incoming)
            where T : unmanaged;        
    }

    public interface IUnmanagedConverter<P,S> : IUnmanagedConverter<S>, IUnmanagedConversionProvider<P,S>
        where S : unmanaged
        where P : struct, IUnmanagedConverter<P,S>
    {

        P IUnmanagedConversionProvider<P,S>.Converter {[MethodImpl(Inline)] get => default(P);}

    }
}