//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.ClrData;

    partial struct Reflected
    {
        /// <summary>
        /// Represents a parametrically-identified clr enum
        /// </summary>
        public readonly struct ClrEnum<T> : IClrEnum<ClrEnum<T>,ClrEnum,T>
            where T : unmanaged, Enum
        {
            public Type Definition {get;}

            [MethodImpl(Inline)]
            public ClrEnum(Type src)
            {
                Definition = src;
            }

            public ApiArtifactKey Id
            {
                [MethodImpl(Inline)]
                get => Definition.MetadataToken;
            }

            public ClrEnum Untyped
            {
                [MethodImpl(Inline)]
                get => new ClrEnum(Definition);
            }

            [MethodImpl(Inline)]
            public static implicit operator ClrEnum(ClrEnum<T> src)
                => src.Untyped;

            [MethodImpl(Inline)]
            public static implicit operator Type(ClrEnum<T> src)
                => src.Definition;

            [MethodImpl(Inline)]
            public static implicit operator ClrType<T>(ClrEnum<T> src)
                => new ClrType<T>(src.Definition);
        }
    }
}