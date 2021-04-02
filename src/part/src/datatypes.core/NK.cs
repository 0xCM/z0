//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using NK = NumericKind;


    /// <summary>
    /// Represents the parametrically-identified numeric kind
    /// </summary>
    public readonly struct NK<T> : INumericKind<T>
        where T : unmanaged
    {
        public NumericKind Kind
        {
            [MethodImpl(Inline)]
            get => Numeric.kind<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator NK(NK<T> src)
            => Numeric.kind<T>();

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(NK src)
            => Numeric.kind<T>();

        [MethodImpl(Inline)]
        public static implicit operator T(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(T src)
            => Numeric.kind<T>();
    }
}