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

    public readonly struct MatrixWriter
    {
        public static Matrix256<M,N,T> write<M,N,T>(in Matrix256<M,N,T> src, FS.FilePath dst, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            using var writer = dst.Writer();
            if(NumericKinds.floating<T>())
                src.Apply(x => gfp.round<T>(x,4));
            Matrix.write(src,writer);
            return src;
        }
    }
}