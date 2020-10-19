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

    partial struct z
    {               
        /// <summary>
        /// Forms a delagate from a function pointer
        /// </summary>
        /// <param name="pFunc"></param>
        /// <typeparam name="D">The target delegate type</typeparam>
        [MethodImpl(Inline)]
        public static D @delegate<D>(IntPtr pFunc)
            where D : Delegate
                => Marshal.GetDelegateForFunctionPointer<D>(pFunc);
    }
}