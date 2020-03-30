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
    /// A parametric type that, when closed, reifies a type width classification
    /// </summary>
    public readonly struct TypeWidth<T> : ITypeWidth<TypeWidth<T>,T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(TypeWidth<T> src)
            => src.Class;

        TypeWidth ITypeWidth.TypeWidth 
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)(Unsafe.SizeOf<T>() *8);            
        }

        public TypeWidth Class 
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)(Unsafe.SizeOf<T>()*8);            
        }
    }
}