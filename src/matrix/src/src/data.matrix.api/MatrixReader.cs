//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct MatrixReader
    {
        public static Matrix256<M,N,T> read<M,N,T>(FS.FilePath src, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Matrix.blockread<M,N,T>(src);
            if(NumericKinds.floating<T>())
                dst.Apply(x => gfp.round<T>(x,4));
            return dst;
        }
    }
}