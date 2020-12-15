//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static z;

    public static class Converters
    {
        public static Converter<S,T> create<S,T>(IBiconverter<S> service)
            => new Converter<S,T>(service);

        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="src">The value to convert</param>
        public static Option<T> convert<S,T>(S src)
            => @try(() => from converter in Converters.get<S>()
                    from converted in converter.ConvertFromTarget(src,typeof(T))
                    select (T)converted);

        public static Option<IBiconverter<S>> get<S>()
        {
            lock(locker)
            {
                if(Cache.TryGetValue(typeof(S), out var found))
                    return found.TryMap(c => (IBiconverter<S>)c);
                else
                {
                    var converter =
                        from a in typeof(S).Tag<ConversionProviderAttribute>()
                        let provider = (IConversionProvider<S>)Activator.CreateInstance(a.ProviderType)
                        select provider.Converter;

                    Cache[typeof(S)] = converter ? some((IBiconverter)converter.Value) : none<IBiconverter>();
                    return converter;
                }
            }
        }

        static object locker = new object();

        static Dictionary<Type,Option<IBiconverter>> Cache {get;}
            = new Dictionary<Type, Option<IBiconverter>>();
    }
}