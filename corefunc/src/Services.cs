//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    public static class CoreServices
    {
        [MethodImpl(Inline)]
        public static IByteReader ByteReader(this IRngContext context)
            => Z0.ByteReader.Create(context);        
    }
}