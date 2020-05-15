//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public readonly struct CmdInfo
    {
        public string Text {get;}

        readonly ulong Bytes;

        [MethodImpl(Inline)]
        public static CmdInfo Define(string src)
            => new CmdInfo(src);

        [MethodImpl(Inline)]
        public CmdInfo(string src)
        {
            Text = src;
            Bytes = 0;
        }

        public byte Byte0
        {
            [MethodImpl(Inline)]
            get => ByteReader.Read(Bytes, n0);
        }

        public byte Byte1
        {
            [MethodImpl(Inline)]
            get => ByteReader.Read(Bytes, n1);
        }

        public byte Byte2
        {
            [MethodImpl(Inline)]
            get => ByteReader.Read(Bytes, n2);
        }

        public string Format()
            => Text;

        public override string ToString()
            => Format();        
    }

}