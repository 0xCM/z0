//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    
    /// <summary>
    /// Captures a 0-based argument index 
    /// </summary>
    public struct ArgPos
    {
        public byte Index;        
        
        [MethodImpl(Inline)]
        public static implicit operator ArgPos(byte src)
            => new ArgPos(src);

        [MethodImpl(Inline)]
        public static ArgPos operator ++(ArgPos src)
            => new ArgPos((byte)(src.Index + 1));

        [MethodImpl(Inline)]
        public static implicit operator byte(ArgPos src)
            => src.Index;

        [MethodImpl(Inline)]
        public static implicit operator ArgPos(int src)
            => new ArgPos((byte)src);

        [MethodImpl(Inline)]
        public ArgPos(byte src)
            => Index = src;

        public ArgPosIndicator Indicator
        {
            [MethodImpl(Inline)]
            get => (ArgPosIndicator)((Index * 2) << 2);
        }
    }
}