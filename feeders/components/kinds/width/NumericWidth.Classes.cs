//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// A parametric type that, when closed, reifies a  numeric width classification
    /// </summary>
    public readonly struct NumericWidth<T> : INumericWidth<NumericWidth<T>,T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator NumericWidth(NumericWidth<T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(NumericWidth<T> src)
            => src.TypeWidth;

        [MethodImpl(Inline)]
        public static implicit operator NumericWidth<T>(TypeWidth<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NumericWidth<T>(TypeWidth src)
            => default;

        public NumericWidth Class 
        {
            [MethodImpl(Inline)]
            get => (NumericWidth)(Unsafe.SizeOf<T>() *8);            
        }

        public TypeWidth TypeWidth
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)Class;
        }
    }    
}