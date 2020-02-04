//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class HK
    {
        public interface INumeric : ITypeKind
        {
            public const TypeKind TypeClass = TypeKind.NumericType; 

            TypeKind IKind<TypeKind>.Classifier { [MethodImpl(Inline)] get=> TypeClass;}  
        }

        public interface INumeric<T> : INumeric, ITypeKind<T>, IFixedWidth
            where T : unmanaged
        {
            public static FixedWidth Width => (FixedWidth)bitsize<T>();            

            NumericKind NumericKind { [MethodImpl(Inline)] get=> NumericType.kind<T>();}            

            FixedWidth IFixedWidth.FixedWidth { [MethodImpl(Inline)] get=> Width;}          

        }
    }
}