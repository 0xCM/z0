//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ProvidedFormatter<T,C> : IFormatProvider
        where T : IFormattable
        where C : struct
    {
        readonly IFormatProvider Provider;

        readonly C Config;

        [MethodImpl(Inline)]
        public ProvidedFormatter(IFormatProvider provider, C config)
        {
            Provider = provider;
            Config = config;
        }

        [MethodImpl(Inline)]
        public string Format(string pattern, in T src)
            => src.ToString(pattern, Provider);

        [MethodImpl(Inline)]
        public string Format(in T src)
            => Format(RP.Slot0, src);

        [MethodImpl(Inline)]
        public object GetFormat(Type formatType)
            => Provider.GetFormat(formatType);
    }
}