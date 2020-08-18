//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline), Op]
        public static FPtr fptr(Delegate f)
            => new FPtr(f, Marshal.GetFunctionPointerForDelegate(f).ToPointer());

        [MethodImpl(Inline)]
        public static FPtr<D> fptr<D>(D f)
            where D : Delegate
                => new FPtr<D>(f, Marshal.GetFunctionPointerForDelegate<D>(f).ToPointer());
    }
}