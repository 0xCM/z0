//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static HexCodes;

    [ApiHost]
    public struct HexMachine1F
    {
        [MethodImpl(Inline), Op]
        public static HexMachine1F Create(Vector128<byte> state)
            => new HexMachine1F(state);

        Vector128<byte> State;

        bit Processed;
        
        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<byte> src, Span<byte> dst)
        {

        }

                    
        [MethodImpl(Inline)]
        HexMachine1F(Vector128<byte> state)
        {
            State = default;
            Processed = false;
        }

        [MethodImpl(Inline), Op]
        public bit Process(byte code, Span<byte> dst)
        {
            Processed = false;

            if(code <= x15)
                Process(x10,dst);
            else if(code <= x0b)
                Process(x16,dst);
            else
                Process(x1c,dst);            
            return Processed;
        }

        [MethodImpl(Inline)]
        void Process(X10 a, byte code, Span<byte> dst)
        {
            if(code == 0x10)
                Process(x10, dst);
            else if(code == 0x11)
                Process(x11, dst);
            else if(code== 0x12)
                Process(x12, dst);
            else if(code == 0x13)
                Process(x13, dst);
            else if(code == 0x14)
                Process(x14, dst);
            else if(code == 0x15)
                Process(x15, dst);
            else
                Process(x16,code,dst);
        }

        [MethodImpl(Inline)]
        void Process(X16 a, byte code, Span<byte> dst)
        {
            if(code == 0x16)
                Process(x16, dst);
            else if(code == 0x17)
                Process(x17, dst);
            else if(code == 0x18)
                Process(x18, dst);
            else if(code == 0x19)
                Process(x19, dst);
            else if(code == 0x1a)
                Process(x1a, dst);
            else if(code == 0x1b)
                Process(x1b, dst);
            else
                Process(x1c,code,dst);

        }

        [MethodImpl(Inline)]
        void Process(X1C a, byte code, Span<byte> dst)
        {
            if(code == 0x1c)
                Process(x1c, dst);
            else if(code == 0x1d)
                Process(x1d, dst);
            else if(code == 0x1e)
                Process(x1e, dst);
            else if(code == 0x1f)
                Process(x1f, dst);
        }

        [MethodImpl(Inline), Op]
        public void Process(X10 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
                                        
        }

        [MethodImpl(Inline), Op]
        public void Process(X11 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X12 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X13 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X14 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X15 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X16 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X17 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X18 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X19 x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X1A x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X1B x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X1C x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X1D x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X1E x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }

        [MethodImpl(Inline), Op]
        public void Process(X1F x, Span<byte> dst)
        {
            seek(dst,x) = skip(dst, x >> 1);
        }           
    }
}