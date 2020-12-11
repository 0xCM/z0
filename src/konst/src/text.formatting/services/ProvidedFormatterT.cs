//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ProvidedFormatter<T> : IFormatProvider
        where T : IFormattable
    {
        readonly IFormatProvider Provider;

        [MethodImpl(Inline)]
        public ProvidedFormatter(IFormatProvider weak)
        {
            Provider = weak;
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