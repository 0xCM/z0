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

        public string Format()
            => Locator?.ToString() ?? EmptyString;
    }

    public abstract class Location<T> : ILocation<T>
        where T : struct
    {
        public T Locator {get;}

        [MethodImpl(Inline)]
        protected Location(T locator)
            => Locator = locator;
        public string Format()
            => Locator.ToString();
    }
}