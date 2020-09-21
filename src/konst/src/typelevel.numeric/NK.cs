//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NK = NumericKind;

    public readonly struct NK<F,T> : INumericKind<NK<F,T>,T>
        where T : unmanaged
        where F : unmanaged, INumericKind<T>
    {

    }

    /// <summary>
    /// Represents the parametrically-identified numeric kind
    /// </summary>
    public readonly struct NK<T> : INumericKind<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(NK<T> src)
            => NumericKinds.kind<T>();

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(NK src)
            => NumericKinds.kind<T>();

        [MethodImpl(Inline)]
        public static implicit operator T(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(T src)
            => NumericKinds.kind<T>();

        public NumericKind Kind
        {
            [MethodImpl(Inline)]
            get => NumericKinds.kind<T>();
        }
    }
}