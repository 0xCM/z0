//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Represents a parametrically-identified clr enum
    /// </summary>
    public readonly struct ClrEnum<T> : IClrEnum<ClrEnum<T>,ClrEnum,T>  
        where T : unmanaged, Enum
    {
        public Type Subject => typeof(T);

        public ClrEnum Untyped 
        {
            [MethodImpl(Inline)]
            get => ClrEnum.Unchecked(Subject);
        }

        public ClrType<T> Generalized
        {
            [MethodImpl(Inline)]
            get => ClrType.From<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrEnum(ClrEnum<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum<T> src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<T>(ClrEnum<T> src)
            => ClrType.From<T>();
    }
}