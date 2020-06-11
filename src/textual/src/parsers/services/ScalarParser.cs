//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static NumericCast;

    public readonly struct ScalarParser
    {
        public static ScalarParser Service => default(ScalarParser);
        
        [MethodImpl(Inline)]
        public bit parse(string src, out sbyte dst)
            => sbyte.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out byte dst)
            => byte.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out short dst)
            => short.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out ushort dst)
            => ushort.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out int dst)
            => int.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out uint dst)
            => uint.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out long dst)
            => long.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out ulong dst)
            => ulong.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out float dst)
            => float.TryParse(src, out dst);

        [MethodImpl(Inline)]
        public bit parse(string src, out double dst)
            => double.TryParse(src, out dst);            
    }
}