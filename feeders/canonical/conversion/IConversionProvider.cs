//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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

    public interface IConversionProvider<P,S> : IConversionProvider<S>, IConverter
        where P : IBiconverter<S>
        where S : struct
    {
        new P Converter {get;}

        IBiconverter<S> IConversionProvider<S>.Converter => Converter;
    }
}