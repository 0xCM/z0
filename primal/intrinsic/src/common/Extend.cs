//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class ginxx
    {

        [MethodImpl(Inline)]
        public static string Format(this Blend32x4 src)                
            => BitString.FromScalar((byte)src).Format(true);
    }
}