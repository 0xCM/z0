//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;    
    
    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static T LastCell<T>(this Vector128<T> src)
            where T : unmanaged 
        {
            if(Unsafe.SizeOf<T>() == 1)
                return src.Cell(15);
            else if(Unsafe.SizeOf<T>() == 2)
                return src.Cell(7);
            else if(Unsafe.SizeOf<T>() == 4)
                return src.Cell(3);
            else
                return src.Cell(1);
        }

        [MethodImpl(Inline)]
        public static T LastCell<T>(this Vector256<T> src)
            where T : unmanaged 
        {
            if(Unsafe.SizeOf<T>() == 1)
                return src.Cell(31);
            else if(Unsafe.SizeOf<T>() == 2)
                return src.Cell(15);
            else if(Unsafe.SizeOf<T>() == 4)
                return src.Cell(7);
            else
                return src.Cell(3);
        }    
    }
}