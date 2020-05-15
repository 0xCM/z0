//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;        
    using static Memories;

    public struct RexPrefix
    {
        byte data;

        [MethodImpl(Inline)]
        public static RexPrefix Init(byte src)        
            => new RexPrefix(src);

        [MethodImpl(Inline)]
        RexPrefix(byte src)
        {
            data = src;
        }

        public byte B
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(b,data);

            [MethodImpl(Inline)]
            set => BitWriter.Write(b,value, data);
        }

        public byte X
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(x,data);

            [MethodImpl(Inline)]
            set => BitWriter.Write(x,value, data);
        }

        public byte R
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(r,data);

            [MethodImpl(Inline)]
            set => BitWriter.Write(r,value, data);
        }

        public byte W
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(w,data);

            [MethodImpl(Inline)]
            set => BitWriter.Write(w,value, data);
        }

        static N0 b => default;

        static N1 x => default;

        static N2 r => default;

        static N3 w => default;
    }
}