//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;

    public readonly struct BaseHexFormatter : IBaseHexFormatter
    {
        [MethodImpl(Inline)]
        public static BaseHexFormatter<T> Define<T>(Func<T,string,string> f)
            where T : struct
                => new BaseHexFormatter<T>(f);

        [MethodImpl(Inline)]
        public static BaseHexFormatter Define(Func<object,string,string> f)
            => new BaseHexFormatter(f);

        readonly Func<object,string,string> F;

        [MethodImpl(Inline)]
        BaseHexFormatter(Func<object,string,string> f)
            => this.F = f;

        [MethodImpl(Inline)]
        public string Format(object src, string config = null)
            => F(src,config);
    }
     
    public readonly struct BaseHexFormatter<T> : IBaseHexFormatter<T>
        where T : struct
    {

        [MethodImpl(Inline)]
        internal BaseHexFormatter(Func<T,string,string> f)
            => this.F = f;

        readonly Func<T,string,string> F;

        [MethodImpl(Inline)]
        public string Format(T src, string config = null)
            => F(src, config);
    }
}