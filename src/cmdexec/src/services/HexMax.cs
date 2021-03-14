//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static HexLevel;
    using static memory;
    using static cpu;

    [ApiHost]
    public partial struct HexMax
    {
        const MethodImplOptions Option = MethodImplOptions.NoInlining;

        const NumericKind Closure = UInt64k;

        Vector128<byte> State;

        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<Hex8Seq> src)
        {
            var count = src.Length;
            ref readonly var kind = ref first(src);
            for(var i=0u; i<count; i++)
                Process(skip(kind, i));
        }

        [MethodImpl(Inline)]
        internal HexMax(Vector128<byte> state)
        {
            State = default;
        }

        [Op]
        public sbyte Process(Hex8Seq code)
        {
            Process(h00, h0F, code);
            return (sbyte)vcell(State, 15);
        }

        [Op]
        public void Process(X00 a, X0F b, Hex8Seq code)
        {
            switch(code)
            {
                case x00: Process(h00); break;
                case x01: Process(h01); break;
                case x02: Process(h02); break;
                case x03: Process(h03); break;
                case x04: Process(h04); break;
                case x05: Process(h05); break;
                case x06: Process(h06); break;
                case x07: Process(h07); break;
                case x08: Process(h08); break;
                case x09: Process(h09); break;
                case x0A: Process(h0A); break;
                case x0B: Process(h0B); break;
                case x0C: Process(h0C); break;
                case x0D: Process(h0D); break;
                case x0E: Process(h0E); break;
                case x0F: Process(h0F); break;
                default: Process(h10, h1F, code); break;
            }
        }


        [Op]
        public void Process(X10 a, X1F b, Hex8Seq code)
        {
            switch(code)
            {
                case x10: Process(h10); break;
                case x11: Process(h11); break;
                case x12: Process(h12); break;
                case x13: Process(h13); break;
                case x14: Process(h14); break;
                case x15: Process(h15); break;
                case x16: Process(h16); break;
                case x17: Process(h17); break;
                case x18: Process(h18); break;
                case x19: Process(h19); break;
                case x1A: Process(h1A); break;
                case x1B: Process(h1B); break;
                case x1C: Process(h1C); break;
                case x1D: Process(h1D); break;
                case x1E: Process(h1E); break;
                case x1F: Process(h1F); break;
                default: Process(h20, h2F, code); break;
            }
        }

        [Op]
        public void Process(X20 a, X2F b, Hex8Seq code)
        {
            switch(code)
            {
                case x20: Process(h20); break;
                case x21: Process(h21); break;
                case x22: Process(h22); break;
                case x23: Process(h23); break;
                case x24: Process(h24); break;
                case x25: Process(h25); break;
                case x26: Process(h26); break;
                case x27: Process(h27); break;
                case x28: Process(h28); break;
                case x29: Process(h29); break;
                case x2A: Process(h2A); break;
                case x2B: Process(h2B); break;
                case x2C: Process(h2C); break;
                case x2D: Process(h2D); break;
                case x2E: Process(h2E); break;
                case x2F: Process(h2F); break;
                default: Process(h30, h3F, code); break;
            }
        }

        [Op]
        public void Process(X30 a, X3F b, Hex8Seq code)
        {
            switch(code)
            {
                case x30: Process(h30); break;
                case x31: Process(h31); break;
                case x32: Process(h32); break;
                case x33: Process(h33); break;
                case x34: Process(h34); break;
                case x35: Process(h35); break;
                case x36: Process(h36); break;
                case x37: Process(h37); break;
                case x38: Process(h38); break;
                case x39: Process(h39); break;
                case x3A: Process(h3A); break;
                case x3B: Process(h3B); break;
                case x3C: Process(h3C); break;
                case x3D: Process(h3D); break;
                case x3E: Process(h3E); break;
                case x3F: Process(h3F); break;
                default: Process(h40, h4F, code); break;
            }
        }

        [Op]
        public void Process(X40 a, X4F b, Hex8Seq code)
        {
            switch(code)
            {
                case x40: Process(h40); break;
                case x41: Process(h41); break;
                case x42: Process(h42); break;
                case x43: Process(h43); break;
                case x44: Process(h44); break;
                case x45: Process(h45); break;
                case x46: Process(h46); break;
                case x47: Process(h47); break;
                case x48: Process(h48); break;
                case x49: Process(h49); break;
                case x4A: Process(h4A); break;
                case x4B: Process(h4B); break;
                case x4C: Process(h4C); break;
                case x4D: Process(h4D); break;
                case x4E: Process(h4E); break;
                case x4F: Process(h4F); break;
                default: Process(h50, h5F, code); break;
            }
        }

        [Op]
        public void Process(X50 a, X5F b, Hex8Seq code)
        {
            switch(code)
            {
                case x50: Process(h50); break;
                case x51: Process(h51); break;
                case x52: Process(h52); break;
                case x53: Process(h53); break;
                case x54: Process(h54); break;
                case x55: Process(h55); break;
                case x56: Process(h56); break;
                case x57: Process(h57); break;
                case x58: Process(h58); break;
                case x59: Process(h59); break;
                case x5A: Process(h5A); break;
                case x5B: Process(h5B); break;
                case x5C: Process(h5C); break;
                case x5D: Process(h5D); break;
                case x5E: Process(h5E); break;
                case x5F: Process(h5F); break;
                default: Process(h60, h6F, code); break;
            }
        }

        [Op]
        public void Process(X60 a, X6F b, Hex8Seq code)
        {
            switch(code)
            {
                case x60: Process(h60); break;
                case x61: Process(h61); break;
                case x62: Process(h62); break;
                case x63: Process(h63); break;
                case x64: Process(h64); break;
                case x65: Process(h65); break;
                case x66: Process(h66); break;
                case x67: Process(h67); break;
                case x68: Process(h68); break;
                case x69: Process(h69); break;
                case x6A: Process(h6A); break;
                case x6B: Process(h6B); break;
                case x6C: Process(h6C); break;
                case x6D: Process(h6D); break;
                case x6E: Process(h6E); break;
                case x6F: Process(h6F); break;
                default: Process(h70, h7F, code); break;
            }
        }

        [Op]
        public void Process(X70 a, X7F b, Hex8Seq code)
        {
            switch(code)
            {
                case x70: Process(h70); break;
                case x71: Process(h71); break;
                case x72: Process(h72); break;
                case x73: Process(h73); break;
                case x74: Process(h74); break;
                case x75: Process(h75); break;
                case x76: Process(h76); break;
                case x77: Process(h77); break;
                case x78: Process(h78); break;
                case x79: Process(h79); break;
                case x7A: Process(h7A); break;
                case x7B: Process(h7B); break;
                case x7C: Process(h7C); break;
                case x7D: Process(h7D); break;
                case x7E: Process(h7E); break;
                case x7F: Process(h7F); break;
                default: Process(h80, h8F, code); break;
            }
        }

        [Op]
        public void Process(X80 a, X8F b, Hex8Seq code)
        {
            switch(code)
            {
                case x80: Process(h80); break;
                case x81: Process(h81); break;
                case x82: Process(h82); break;
                case x83: Process(h83); break;
                case x84: Process(h84); break;
                case x85: Process(h85); break;
                case x86: Process(h86); break;
                case x87: Process(h87); break;
                case x88: Process(h88); break;
                case x89: Process(h89); break;
                case x8A: Process(h8A); break;
                case x8B: Process(h8B); break;
                case x8C: Process(h8C); break;
                case x8D: Process(h8D); break;
                case x8E: Process(h8E); break;
                case x8F: Process(h8F); break;
                default: Process(h90, h9F, code); break;
            }
        }

        [Op]
        public void Process(X90 a, X9F b, Hex8Seq code)
        {
            switch(code)
            {
                case x90: Process(h90); break;
                case x91: Process(h91); break;
                case x92: Process(h92); break;
                case x93: Process(h93); break;
                case x94: Process(h94); break;
                case x95: Process(h95); break;
                case x96: Process(h96); break;
                case x97: Process(h97); break;
                case x98: Process(h98); break;
                case x99: Process(h99); break;
                case x9A: Process(h9A); break;
                case x9B: Process(h9B); break;
                case x9C: Process(h9C); break;
                case x9D: Process(h9D); break;
                case x9E: Process(h9E); break;
                case x9F: Process(h9F); break;
                default: Process(hA0, hAF, code); break;
            }
        }

        [Op]
        public void Process(XA0 a, XAF b, Hex8Seq code)
        {
            switch(code)
            {
                case xA0: Process(hA0); break;
                case xA1: Process(hA1); break;
                case xA2: Process(hA2); break;
                case xA3: Process(hA3); break;
                case xA4: Process(hA4); break;
                case xA5: Process(hA5); break;
                case xA6: Process(hA6); break;
                case xA7: Process(hA7); break;
                case xA8: Process(hA8); break;
                case xA9: Process(hA9); break;
                case xAA: Process(hAA); break;
                case xAB: Process(hAB); break;
                case xAC: Process(hAC); break;
                case xAD: Process(hAD); break;
                case xAE: Process(hAE); break;
                case xAF: Process(hAF); break;
                default: break;
            }
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X00 a, X3F b, Hex8Seq code, in T src)
            where T : struct
        {
            switch(code)
            {
                case x00: Process(h00, src); break;
                case x01: Process(h01, src); break;
                case x02: Process(h02, src); break;
                case x03: Process(h03, src); break;
                case x04: Process(h04, src); break;
                case x05: Process(h05, src); break;
                case x06: Process(h06, src); break;
                case x07: Process(h07, src); break;
                case x08: Process(h08, src); break;
                case x09: Process(h09, src); break;
                case x0A: Process(h0A, src); break;
                case x0B: Process(h0B, src); break;
                case x0C: Process(h0C, src); break;
                case x0D: Process(h0D, src); break;
                case x0E: Process(h0E, src); break;
                case x0F: Process(h0F, src); break;
                case x10: Process(h10, src); break;
                case x11: Process(h11, src); break;
                case x12: Process(h12, src); break;
                case x13: Process(h13, src); break;
                case x14: Process(h14, src); break;
                case x15: Process(h15, src); break;
                case x16: Process(h16, src); break;
                case x17: Process(h17, src); break;
                case x18: Process(h18, src); break;
                case x19: Process(h19, src); break;
                case x1A: Process(h1A, src); break;
                case x1B: Process(h1B, src); break;
                case x1C: Process(h1C, src); break;
                case x1D: Process(h1D, src); break;
                case x1E: Process(h1E, src); break;
                case x1F: Process(h1F, src); break;
                case x20: Process(h20, src); break;
                case x21: Process(h21, src); break;
                case x22: Process(h22, src); break;
                case x23: Process(h23, src); break;
                case x24: Process(h24, src); break;
                case x25: Process(h25, src); break;
                case x26: Process(h26, src); break;
                case x27: Process(h27, src); break;
                case x28: Process(h28, src); break;
                case x29: Process(h29, src); break;
                case x2A: Process(h2A, src); break;
                case x2B: Process(h2B, src); break;
                case x2C: Process(h2C, src); break;
                case x2D: Process(h2D, src); break;
                case x2E: Process(h2E, src); break;
                case x2F: Process(h2F, src); break;
                case x30: Process(h30, src); break;
                case x31: Process(h31, src); break;
                case x32: Process(h32, src); break;
                case x33: Process(h33, src); break;
                case x34: Process(h34, src); break;
                case x35: Process(h35, src); break;
                case x36: Process(h36, src); break;
                case x37: Process(h37, src); break;
                case x38: Process(h38, src); break;
                case x39: Process(h39, src); break;
                case x3A: Process(h3A, src); break;
                case x3B: Process(h3B, src); break;
                case x3C: Process(h3C, src); break;
                case x3D: Process(h3D, src); break;
                case x3E: Process(h3E, src); break;
                case x3F: Process(h3F, src); break;
            }
        }
    }
}