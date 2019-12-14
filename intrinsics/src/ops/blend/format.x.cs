//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;
    
    public static class FormatExtensions
    {
        [MethodImpl(Inline)]
        public static string Format(this Blend8x16 spec)                
            => dinx.vblendformat(spec);

        [MethodImpl(Inline)]
        public static string Format(this Blend4x32 spec)                
            => dinx.vblendformat(spec);

        [MethodImpl(Inline)]
        public static string Format(this Blend8x32 spec)                
            => dinx.vblendformat(spec);

        [MethodImpl(Inline)]
        public static string Format(this Blend2x64 spec)                
            => dinx.vblendformat(spec);

        public static string Format(this Blend4x64 spec)
            => dinx.vblendformat(spec);
    }
}