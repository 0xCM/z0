//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class VectorType
    {
        /// <summary>
        /// Computes the vector kind classifier determined by parametric width and cell types
        /// </summary>
        /// <param name="w">A width type representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static VectorKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W128))
                return VectorType.kind<T>(default(W128));
            else if(typeof(W) == typeof(W256))
                return VectorType.kind<T>(default(W256));
            else if(typeof(W) == typeof(W512))
                return VectorType.kind<T>(default(W512));
            else
                return VectorKind.None;
        }
    }
}