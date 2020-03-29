//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Memories;

    [ApiHost]
    public static partial class As
    {
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.I8 | NumericKind.U8)]
        public static bool boolean<T>(T src)
            => Unsafe.As<T,bool>(ref src);        

        [MethodImpl(Inline),Op, NumericClosures(NumericKind.U16 | NumericKind.I16)]
        public static char character<T>(T src)        
            => Unsafe.As<T,char>(ref src);
    }
}