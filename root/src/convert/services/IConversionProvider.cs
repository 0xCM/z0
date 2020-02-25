//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections.Concurrent;

    using static Root;

    public interface IConversionProvider
    {

    }

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