//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrEnum : IClrEnum<ClrEnum>
    {
        public Type Subject {get;}

        public ClrType Generalized
        {
            get => ClrType.From(Subject);
        }
    
            public string Identifier

        {
            [MethodImpl(Inline)]
            get => Subject.Name;
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
}