//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct I0 : IIndexed<I0> { public int Position => 0;}
    
    public readonly struct I1 : IIndexed<I1> { public int Position => 1;}

    public readonly struct I2 : IIndexed<I2> { public int Position => 2;}

    public readonly struct I3 : IIndexed<I3> { public int Position => 3;}

    public readonly struct I4  : IIndexed<I4> { public int Position => 4;}

    public readonly struct I5 : IIndexed<I5> { public int Position => 5;}

    public readonly struct I6  : IIndexed<I6> { public int Position => 6;}

    partial class Typed
    {
        public static I0 i0 => default;

        public static I1 i1 => default;

        public static I2 i2 => default;

        public static I3 i3 => default;

        public static I4 i4 => default;

        public static I5 i5 => default;

        public static I6 i6 => default;
    }
}