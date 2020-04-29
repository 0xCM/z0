//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ClrEnum : IClrEnum<ClrEnum>
    {
        public Type Subject {get;}

        public ClrType Generalized
        {
            get => ClrType.From(Subject);
        }
    
        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrEnum src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static ClrEnum From(Type src)
            => src.IsEnum ? new ClrEnum(src) : throw Unsupported.define(src);

        [MethodImpl(Inline)]
        public static ClrEnum<T> From<T>()
            where T : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        internal static ClrEnum Unchecked(Type src)
            => new ClrEnum(src);

        [MethodImpl(Inline)]
        public ClrEnum(Type src)
        {
            this.Subject = src;
        }
    }

    /// <summary>
    /// Represents a parametrically-identified clr struct
    /// </summary>
    public readonly struct ClrEnum<T> : IClrEnum<ClrEnum<T>, ClrEnum, T>  
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