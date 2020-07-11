//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Yet another way to view an op code
    /// </summary>
    public readonly struct CmdOpCode
    {
        public asci32 Text {get;}

        readonly ulong Bytes;

        [MethodImpl(Inline)]
        public static CmdOpCode Define(asci32 src)
            => new CmdOpCode(src);

        [MethodImpl(Inline)]
        public CmdOpCode(asci32 src)
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