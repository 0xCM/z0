//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Api
    {
        [KindFactory]
        public static EmitterClass emitter()
            => default;

        [KindFactory, Closures(Closure)]
        public static EmitterClass<T> emitter<T>(T t = default)
            where T : unmanaged => default;
    }
}