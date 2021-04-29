//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VAnd128<T> vand<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VAnd128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VAnd256<T> vand<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VAnd256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNand128<T> vnand<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VNand128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNand256<T> vnand<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VNand256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VOr128<T> vor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VOr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VOr256<T> vor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VOr256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNor128<T> vnor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VNor128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNor256<T> vnor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VNor256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VXor128<T> vxor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VXor128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VXor256<T> vxor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VXor256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VXnor128<T> vxnor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VXnor128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VXnor256<T> vxnor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VXnor256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VXorNot128<T> vxornot<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VXorNot128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VXorNot256<T> vxornot<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VXorNot256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNot128<T> vnot<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VNot128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNot256<T> vnot<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VNot256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSelect128<T> vselect<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSelect128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSelect256<T> vselect<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSelect256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VImpl128<T> vimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VImpl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VImpl256<T> vimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VImpl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNonImpl128<T> vnonimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VNonImpl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNonImpl256<T> vnonimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VNonImpl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VCImpl128<T> vcimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VCImpl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VCImpl256<T> vcimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VCImpl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VCNonImpl128<T> vcnonimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VCNonImpl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VCNonImpl256<T> vcnonimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VCNonImpl256<T>);
   }
}