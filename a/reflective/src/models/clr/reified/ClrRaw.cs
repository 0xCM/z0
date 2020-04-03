//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Reflective;

    public readonly struct ClrRaw : IClrRaw<ClrRaw>
    {
        public Type Subject {get;}

        public ClrType Generalized
        {
            [MethodImpl(Inline)]
            get => ClrType.From(Subject);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrRaw src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrRaw src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static ClrRaw From(Type src)
            => src.IsUnManaged() ? new ClrRaw(src) : throw Unsupported.define(src);

        [MethodImpl(Inline)]
        public static ClrRaw<T> From<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        internal static ClrRaw Unchecked(Type src)
            => new ClrRaw(src);

        [MethodImpl(Inline)]
        public ClrRaw(Type src)
        {
            this.Subject = src;
        }
    }

    /// <summary>
    /// Represents a parametrically-identified clr struct
    /// </summary>
    public readonly struct ClrRaw<T> : IClrRaw<ClrRaw<T>, ClrRaw, T>  
        where T : unmanaged
    {
        public Type Subject => typeof(T);

        public ClrRaw Untyped 
        {
            [MethodImpl(Inline)]
            get => ClrRaw.Unchecked(Subject);
        }

        public ClrType<T> Generalized
        {
            [MethodImpl(Inline)]
            get => ClrType.From<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrRaw(ClrRaw<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrRaw<T> src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<T>(ClrRaw<T> src)
            => ClrType.From<T>();
    }
}