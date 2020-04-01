//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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