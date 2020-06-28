//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Memories;
    using static HexLevel;

    [ApiHost]
    public struct HM1F
    {
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

        Vector128<byte> State;

        bit Processed;
        
        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<byte> src, Span<byte> dst)
        {

        }
                    
        [MethodImpl(Inline)]
        internal HM1F(Vector128<byte> state)
        {
            State = default;
            Processed = false;
        }

        [MethodImpl(Inline), Op]
        public bit Process(byte code, Span<byte> dst)
        {
            Processed = false;

            if(code <= h15)
                Process(h10,dst);
            else if(code <= h0B)
                Process(h16,dst);
            else
                Process(h1C,dst);            
            return Processed;
        }

        [MethodImpl(Inline)]
        void Process(X10 a, byte code, Span<byte> dst)
        {
            if(code == 0x10)
                Process(h10, dst);
            else if(code == 0x11)
                Process(h11, dst);
            else if(code== 0x12)
                Process(h12, dst);
            else if(code == 0x13)
                Process(h13, dst);
            else if(code == 0x14)
                Process(h14, dst);
            else if(code == 0x15)
                Process(h15, dst);
            else
                Process(h16,code,dst);
        }

        [MethodImpl(Inline)]
        void Process(X16 a, byte code, Span<byte> dst)
        {
            if(code == 0x16)
                Process(h16, dst);
            else if(code == 0x17)
                Process(h17, dst);
            else if(code == 0x18)
                Process(h18, dst);
            else if(code == 0x19)
                Process(h19, dst);
            else if(code == 0x1a)
                Process(h1A, dst);
            else if(code == 0x1b)
                Process(h1B, dst);
            else
                Process(h1C,code,dst);

        }

        [MethodImpl(Inline)]
        void Process(X1C a, byte code, Span<byte> dst)
        {
            if(code == 0x1c)
                Process(h1C, dst);
            else if(code == 0x1d)
                Process(h1D, dst);
            else if(code == 0x1e)
                Process(h1E, dst);
            else if(code == 0x1f)
                Process(h1F, dst);
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