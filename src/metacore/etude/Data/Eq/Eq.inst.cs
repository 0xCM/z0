//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Linq;

    using static minicore;

    public readonly struct DefaultEq<X> : IEq<X>
    {
        public static readonly DefaultEq<X> instance = default;

        public bool eq(X x1, X x2)
            => object.Equals(x1, x2);
    }

}