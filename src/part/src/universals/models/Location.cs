//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Location : ILocation
    {
        public dynamic Locator {get;}

        [MethodImpl(Inline)]
        public Location(dynamic locator)
            => Locator = locator;

        public static Location Empty
        {
            [MethodImpl(Inline)]
            get => new Location(0ul);
        }
    }

    public readonly struct Location<T> : ILocation<T>
        where T : struct
    {
        public T Locator {get;}

        [MethodImpl(Inline)]
        public Location(T locator)
            => Locator = locator;

        [MethodImpl(Inline)]
        public static implicit operator Location<T>(T src)
            => new Location<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Location(Location<T> src)
            => new Location(src.Locator);

        public static Location<T> Empty
        {
            [MethodImpl(Inline)]
            get => new Location<T>(default(T));
        }
    }
}