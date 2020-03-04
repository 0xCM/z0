//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public static class Biconverter
    {
        public static Option<IBiconverter<S>> Create<S>()
        {
            lock(locker)
            {
                if(Converters.TryGetValue(typeof(S), out var found))
                    return found.TryMap(c => (IBiconverter<S>)c);
                else
                {
                    var converter = 
                        from a in typeof(S).Tag<ConversionProviderAttribute>()
                        let provider = (IConversionProvider<S>)Activator.CreateInstance(a.ProviderType)
                        select provider.Converter;            

                    Converters[typeof(S)] = converter ? some((IBiconverter)converter.Value) : none<IBiconverter>();
                    return converter;
                }
            }
        }

        static object locker = new object();

        static Dictionary<Type,Option<IBiconverter>> Converters {get;}
            = new Dictionary<Type, Option<IBiconverter>>();
    }

    public readonly struct Biconverter<S> : IBiconverter<S>
    {        
        // [MethodImpl(Inline)]
        // public static Biconverter<S> Create()
        //     => default(Biconverter<S>);
        
        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        public Option<T> Convert<T>(S incoming)
        {
            try
            {
                return 
                    from converter in Biconverter.Create<S>()
                    from converted in converter.ConvertFromTarget(incoming,typeof(T))
                    select (T)converted;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<T>();
            }
        }
                
        /// <summary>
        /// converts an incoming value to a value of target type
        /// </summary>
        /// <param name="incoming">The value to convert</param>
        /// <typeparam name="T">The incoming value type</typeparam>
        public Option<S> Convert<T>(T incoming)
        {
            try
            {
                return 
                    from converter in Biconverter.Create<S>()
                    from converted in converter.ConvertFromTarget(incoming,typeof(S))
                    select (S)converted;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<S>();
            }
        }

        public Option<object> ConvertFromTarget(object incoming, Type dst)
        {
            try
            {
                return 
                    from converter in Biconverter.Create<S>()
                    from converted in converter.ConvertFromTarget(incoming, dst)
                    select converted;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<object>();
            }
        }

        public Option<object> ConvertToTarget(object incoming)
        {
            try
            {
                return 
                    from converter in Biconverter.Create<S>()
                    from converted in converter.ConvertFromTarget(incoming,typeof(S))
                    select converted;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<S>();
            }
        }
    }
}