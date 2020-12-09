//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Converter<S,T> : IConverter<S,T>
    {
        readonly IBiconverter<S> Service;

        [MethodImpl(Inline)]
        internal Converter(IBiconverter<S> service)
        {
            Service = service;
        }

        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="src">The value to convert</param>
        public bool Convert(in S src, out T dst)
        {
            dst = default;

            try
            {
                dst = Service.Convert<T>(src);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Converts an incoming value of the target type to a value of specified type, if possible
        /// </summary>
        /// <param name="src">The value to convert</param>
        public bool Convert(in T src, out S dst)
        {
            dst = default;

            try
            {
                dst = Service.Convert<T>(src);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}