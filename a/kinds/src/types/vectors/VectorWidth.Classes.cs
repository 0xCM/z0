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
    /// A parametric type that, when closed, reifies a  vector width classification
    /// </summary>
    public readonly struct VectorWidth<T> : IVectorWidth<VectorWidth<T>,T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(VectorWidth<T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(VectorWidth<T> src)
            => src.TypeWidth;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth<T>(TypeWidth<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth<T>(TypeWidth src)
            => default;

        public VectorWidth Class 
        {
            [MethodImpl(Inline)]
            get => (VectorWidth)(Unsafe.SizeOf<T>() *8);            
        }

        public TypeWidth TypeWidth
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)Class;
        }
    }
}