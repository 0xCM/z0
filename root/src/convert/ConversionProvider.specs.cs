//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    /// <summary>
    /// Applied to a type to identify an applicable conversion provider
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ConversionProviderAttribute : Attribute
    {
        public ConversionProviderAttribute(Type provider)
        {
            ProviderType = provider;
        }

        public readonly Type ProviderType;
    }

    public interface IConversionProvider
    {

    }

    /// <summary>
    /// Characterizes a service that exposes a two-way converter
    /// </summary>
    /// <typeparam name="S">The conversion type </typeparam>
    public interface IConversionProvider<S> : IConversionProvider
    {
        IBiconverter<S> Converter {get;}

    }

    public interface IValueConversionProvider<C,S> : IConversionProvider<S>, IValueConverter<S>
        where S : struct
        where C : IValueConverter<S>
    {
        new C Converter {get;}

        IBiconverter<S> IConversionProvider<S>.Converter
            => Converter;
    }

    public interface IUnmanagedConversionProvider<C,S> : IConversionProvider<S>, IUnmanagedConverter<S>
        where S : unmanaged
        where C : IUnmanagedConverter<S>
    {
        new C Converter {get;}

        IBiconverter<S> IConversionProvider<S>.Converter
            => Converter;
    }    
}