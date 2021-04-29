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
        public static VAdd128<T> vadd<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VAdd128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VAdd256<T> vadd<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VAdd256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSub128<T> vsub<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSub128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSub256<T> vsub<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSub256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNegate128<T> vnegate<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VNegate128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNegate256<T> vnegate<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VNegate256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VInc128<T> vinc<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VInc128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VInc256<T> vinc<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VInc256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VDec128<T> vdec<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VDec128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VDec256<T> vdec<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VDec256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VAbs128<T> vabs<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VAbs128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VAbs256<T> vabs<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VAbs256<T>);
    }
}