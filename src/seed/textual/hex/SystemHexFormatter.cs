//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct SystemHexFormatter : ISystemFormatter
    {
        [MethodImpl(Inline)]
        public static SystemHexFormatter<T> Define<T>(Func<T,string,string> f)
            where T : struct
                => new SystemHexFormatter<T>(f);

        [MethodImpl(Inline)]
        public static SystemHexFormatter Define(Func<object,string,string> f)
            => new SystemHexFormatter(f);

        readonly Func<object,string,string> F;

        [MethodImpl(Inline)]
        SystemHexFormatter(Func<object,string,string> f)
            => this.F = f;

        [MethodImpl(Inline)]
        public string Format(object src, string config = null)
            => F(src,config);
    }
     
    public readonly struct SystemHexFormatter<T> : ISystemHexFormatter<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        internal SystemHexFormatter(Func<T,string,string> f)
            => this.F = f;

        readonly Func<T,string,string> F;

        [MethodImpl(Inline)]
        public string Format(T src, string config = null)
            => F(src, config);
    }
}