//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static VOpTypes;

    partial class VOps
    {


        /// <summary>
        /// Operator factory for vbsll_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VbsllOp128<T> vbsll<T>(N128 w, T t = default)
            where T : unmanaged
                => VbsllOp128<T>.Op;

        /// <summary>
        /// Operator factory for vbsll_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VbsllOp256<T> vbsll<T>(N256 w, T t = default)
            where T : unmanaged
                => VbsllOp256<T>.Op;

        /// <summary>
        /// Operator factory for vxor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxorOp128<T> vxor<T>(N128 w, T t = default)
            where T : unmanaged
                => VxorOp128<T>.Op;

        /// <summary>
        /// Operator factory for vxor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxorOp256<T> vxor<T>(N256 w, T t = default)
            where T : unmanaged
                => VxorOp256<T>.Op;
 
        /// <summary>
        /// Operator factory for vand_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VandOp128<T> vand<T>(N128 w, T t = default)
            where T : unmanaged
                => VandOp128<T>.Op;

        /// <summary>
        /// Operator factory for vand_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VandOp256<T> vand<T>(N256 w, T t = default)
            where T : unmanaged
                => VandOp256<T>.Op;

        /// <summary>
        /// Operator factory for vor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VorOp128<T> vor<T>(N128 w, T t = default)
            where T : unmanaged
                => VorOp128<T>.Op;

        /// <summary>
        /// Operator factory for vor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VorOp256<T> vor<T>(N256 w, T t = default)
            where T : unmanaged
                => VorOp256<T>.Op;

        /// <summary>
        /// Operator factory for vnor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnorOp128<T> vnor<T>(N128 w, T t = default)
            where T : unmanaged
                => VnorOp128<T>.Op;

        /// <summary>
        /// Operator factory for vnor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnorOp256<T> vnor<T>(N256 w, T t = default)
            where T : unmanaged
                => VnorOp256<T>.Op;

        /// <summary>
        /// Operator factory for vnand_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnandOp128<T> vnand<T>(N128 w, T t = default)
            where T : unmanaged
                => VnandOp128<T>.Op;

        /// <summary>
        /// Operator factory for vnand_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnandOp256<T> vnand<T>(N256 w, T t = default)
            where T : unmanaged
                => VnandOp256<T>.Op;

        /// <summary>
        /// Operator factory for vnot_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnotOp128<T> vnot<T>(N128 w, T t = default)
            where T : unmanaged
                => VnotOp128<T>.Op;

        /// <summary>
        /// Operator factory for vnot_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnotOp256<T> vnot<T>(N256 w, T t = default)
            where T : unmanaged
                => VnotOp256<T>.Op;
 
        /// <summary>
        /// Operator factory for vxornot_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxornotOp128<T> vxornot<T>(N128 w, T t = default)
            where T : unmanaged
                => VxornotOp128<T>.Op;

        /// <summary>
        /// Operator factory for vxornot_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxornotOp256<T> vxornot<T>(N256 w, T t = default)
            where T : unmanaged
                => VxornotOp256<T>.Op;

        /// <summary>
        /// Operator factory for vxnor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxnorOp128<T> vxnor<T>(N128 w, T t = default)
            where T : unmanaged
                => VxnorOp128<T>.Op;

        /// <summary>
        /// Operator factory for vxnor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VxnorOp256<T> vxnor<T>(N256 w, T t = default)
            where T : unmanaged
                => VxnorOp256<T>.Op;

        /// <summary>
        /// Operator factory for vselect_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VselectOp128<T> vselect<T>(N128 w, T t = default)
            where T : unmanaged
                => VselectOp128<T>.Op;

        /// <summary>
        /// Operator factory for vselect_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VselectOp256<T> vselect<T>(N256 w, T t = default)
            where T : unmanaged
                => VselectOp256<T>.Op;

       /// <summary>
        /// Operator factory for vsll_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllOp128<T> vsll<T>(N128 w, T t = default)
            where T : unmanaged
                => VsllOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsll_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllOp256<T> vsll<T>(N256 w, T t = default)
            where T : unmanaged
                => VsllOp256<T>.Op;
 
         /// <summary>
        /// Operator factory for vsrl_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlOp128<T> vsrl<T>(N128 w, T t = default)
            where T : unmanaged
                => VsrlOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsrl_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlOp256<T> vsrl<T>(N256 w, T t = default)
            where T : unmanaged
                => VsrlOp256<T>.Op;

        /// <summary>
        /// Operator factory for vsrlx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlxOp128<T> vsrlx<T>(N128 w, T t = default)
            where T : unmanaged
                => VsrlxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsrlx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlxOp256<T> vsrlx<T>(N256 w, T t = default)
            where T : unmanaged
                => VsrlxOp256<T>.Op;
 
        /// <summary>
        /// Operator factory for vsllx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllxOp128<T> vsllx<T>(N128 w, T t = default)
            where T : unmanaged
                => VsllxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsllx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllxOp256<T> vsllx<T>(N256 w, T t = default)
            where T : unmanaged
                => VsllxOp256<T>.Op;

        /// <summary>
        /// Operator factory for vbsrl_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VbsrlOp128<T> vbsrl<T>(N128 w, T t = default)
            where T : unmanaged
                => VbsrlOp128<T>.Op;

        /// <summary>
        /// Operator factory for vbsrl_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VbsrlOp256<T> vbsrl<T>(N256 w, T t = default)
            where T : unmanaged
                => VbsrlOp256<T>.Op;

        /// <summary>
        /// Operator factory for vrotrx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotrxOp128<T> vrotrx<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotrxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotrx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotrxOp256<T> vrotrx<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotrxOp256<T>.Op;

        /// <summary>
        /// Operator factory for vrotlx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlxOp128<T> vrotlx<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotlxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotlx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlxOp256<T> vrotlx<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotlxOp256<T>.Op;

        /// <summary>
        /// Operator factory for vsrlv_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlvOp128<T> vsrlv<T>(N128 w, T t = default)
            where T : unmanaged
                => VsrlvOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsrlv_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsrlvOp256<T> vsrlv<T>(N256 w, T t = default)
            where T : unmanaged
                => VsrlvOp256<T>.Op;

        /// <summary>
        /// Operator factory for vsllv_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllvOp128<T> vsllv<T>(N128 w, T t = default)
            where T : unmanaged
                => VsllvOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsllv_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsllvOp256<T> vsllv<T>(N256 w, T t = default)
            where T : unmanaged
                => VsllvOp256<T>.Op;

        /// <summary>
        /// Operator factory for vrotl_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlOp128<T> vrotl<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotlOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotl_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotlOp256<T> vrotl<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotlOp256<T>.Op;

        /// <summary>
        /// Operator factory for vrotr_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotrOp128<T> vrotr<T>(N128 w, T t = default)
            where T : unmanaged
                => VrotrOp128<T>.Op;

        /// <summary>
        /// Operator factory for vrotr_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VrotrOp256<T> vrotr<T>(N256 w, T t = default)
            where T : unmanaged
                => VrotrOp256<T>.Op;


    }

}