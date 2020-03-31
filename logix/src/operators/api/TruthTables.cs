//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.IO;
    
    using static Core;

    using Api = LogicOpApi;

    public static class TruthTables
    {
        static bit on => bit.On;
        
        static bit off => bit.Off;

        /// <summary>
        /// Computes a the signature, also referred to as the truth vector, for an identified unary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BitVector4 sig(UnaryBitLogicKind kind)
        {
            var x = BitVector4.Zero;
            x[0] = Api.eval(kind, off);
            x[1] = Api.eval(kind, on);
            return x;
        }

        /// <summary>
        /// Computes a the signature, also referred to as the truth vector, for an identified binary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BitVector4 sig(BinaryBitLogicKind kind)
        {
            var x = BitVector.alloc(n4);
            x[0] = Api.eval(kind, off, off);
            x[1] = Api.eval(kind, on, off);
            x[2] = Api.eval(kind, off, on);
            x[3] = Api.eval(kind, on, on);
            return x;
        }
        
        /// <summary>
        /// Computes a the signature, also referred to as the truth vector, for an identified ternary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BitVector8 sig(TernaryBitLogicKind kind)
        {
            var x = BitVector8.Zero;
            x[0] = Api.eval(kind, off,off,off);
            x[1] = Api.eval(kind, off,off,on);
            x[2] = Api.eval(kind, off,on,off);
            x[3] = Api.eval(kind, off,on,on);
            x[4] = Api.eval(kind, on,off,off);
            x[5] = Api.eval(kind, on,off,on);
            x[6] = Api.eval(kind, on,on, off);
            x[7] = Api.eval(kind, on,on,on);
            return x;
        }

        /// <summary>
        /// Constructs a canonical vector that defines a kind-identified operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BitVector16 definition(BinaryBitLogicKind kind)
        {
            var dst = BitVector.alloc(n16);
            var s = ((byte)sig(kind)).ToBitString().Truncate(4);            
            var f = Api.lookup(kind);
            dst[0] = off;
            dst[1] = off;
            dst[2] = f(off, off);
            dst[3] = on;
            dst[4] = off;
            dst[5] = f(on, off);
            dst[6] = off;
            dst[7] = on;
            dst[8] = f(off, on);
            dst[9] = on;
            dst[10] = on;
            dst[11] = f(on,on);
            dst[12] = s[0];
            dst[13] = s[1];
            dst[14] = s[2];
            dst[15] = s[3];            
            return dst;
        }

        public static BitMatrix<N2,N2,byte> build(UnaryBitLogicKind kind)
        {
            var f = Api.lookup(kind);
            var table = BitMatrix.alloc<N2,N2,byte>();
            table[0] = BitBlocks.literal<N2,byte>((byte)Bits.pack(f(off), off));
            table[1] = BitBlocks.literal<N2,byte>((byte)Bits.pack(f(on), on));
            return table;            
        }

        public static BitMatrix<N4,N3,byte> build(BinaryBitLogicKind kind)
        {
            var tt = BitMatrix.alloc<N4,N3,byte>();
            var f = Api.lookup(kind);
            tt[0] = BitBlocks.literal<N3,byte>((byte)Bits.pack(f(off, off), off, off));
            tt[1] = BitBlocks.literal<N3,byte>((byte)Bits.pack(f(on, off), off, on));
            tt[2] = BitBlocks.literal<N3,byte>((byte)Bits.pack(f(off, on), on, off));
            tt[3] = BitBlocks.literal<N3,byte>((byte)Bits.pack(f(on, on),  on, on));
            return tt;
        }

        public static BitMatrix<N8,N4,byte> build(TernaryBitLogicKind kind)
        {
            var tt = BitMatrix.alloc<N8,N4,byte>();
            var f = Api.lookup(kind);
            tt[0] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(off, off, off), off, off, off));
            tt[1] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(off, off, on), off, off, on));
            tt[2] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(off, on, off), off, on, off));
            tt[3] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(off, on, on), off, on, on));
            tt[4] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(on, off, off), on, off, off));
            tt[5] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(on, off, on), on, off, on));
            tt[6] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(on, on, off), off, on, on));
            tt[7] = BitBlocks.literal<N4,byte>((byte)Bits.pack(f(on, on, on), on, on, on));
            return tt;
        }

        public static void emit(TextWriter dst, ReadOnlySpan<UnaryBitLogicKind> kinds)
        {
            for(var i=0; i<kinds.Length; i++)
                emit(kinds[i],dst);
        }

        public static void emit(TextWriter dst, ReadOnlySpan<BinaryBitLogicKind> kinds)
        {
            for(var i=0; i<kinds.Length; i++)
                emit(kinds[i],dst);
        }

        public static void emit(TextWriter dst, ReadOnlySpan<TernaryBitLogicKind> kinds)
        {
            for(var i=0; i<kinds.Length; i++)
                emit(kinds[i],dst);
        }

        public static void emit(TextWriter dst, ArityValue arity)
        {
            switch(arity)
            {

                case ArityValue.Unary: emitUnary(dst); break;
                case ArityValue.Binary: emitBinary(dst); break;
                case ArityValue.Ternary: emitTernary(dst); break;
                default: 
                    throw Unsupported.value(arity);
            }
        }

        static BitMatrix<N2,N2,byte> emit(UnaryBitLogicKind kind, TextWriter dst)
        {
            var table = build(kind);
            table.emit(kind,dst);
            return table;
        }

        static BitMatrix<N4,N3,byte> emit(BinaryBitLogicKind kind, TextWriter dst)
        {
            var table = build(kind);
            table.emit(kind,dst);
            return table;
        }

        static BitMatrix<N8,N4,byte> emit(TernaryBitLogicKind kind, TextWriter dst)
        {
            var table = build(kind);
            table.emit(kind,dst);
            return table;
        }

        static void emitUnary(TextWriter dst)
        {
            var ops = LogicOpApi.UnaryOpKinds.ToArray();
            for(var i=0; i< ops.Length; i++)
            {
                BitVector4 result = (byte)i;
                var table = BitMatrix.alloc<N2,N2,byte>();
                table[0] = BitBlocks.literal<N2,byte>((byte)Bits.pack(result[0], off));
                table[1] = BitBlocks.literal<N2,byte>((byte)Bits.pack(result[1], on));
                table.emit(dst);                
            }
        }

        static void emitBinary(TextWriter dst)
        {
            for(var i=0; i< 16; i++)
            {
                BitVector4 result = (byte)i;
                var bbResult = BitBlocks.from(result);


                var table = BitMatrix.alloc<N4,N3,byte>();
                table[0] = BitBlocks.literal<N3,byte>((byte)Bits.pack(result[0], off, off));
                table[1] = BitBlocks.literal<N3,byte>((byte)Bits.pack(result[1], off, on));
                table[2] = BitBlocks.literal<N3,byte>((byte)Bits.pack(result[2], on, off));
                table[3] = BitBlocks.literal<N3,byte>((byte)Bits.pack(result[3], on, on));
                require(table.GetCol(2) == bbResult);                
                table.emit(dst);
            }
        }

        static void emitTernary(TextWriter dst)
        {
            for(var i=0; i< 256; i++)
            {
                BitVector8 result = (byte)i;
                var bbResult = BitBlocks.from(result);

                var table = BitMatrix.alloc<N8,N4,byte>();
                table[0] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[0], off, off, off));
                table[1] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[1], off, off, on));
                table[2] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[2], off, on, off));
                table[3] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[3], off, on, on));
                table[4] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[4], on, off, off));
                table[5] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[5], on, off, on));
                table[6] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[6], on, on, off));
                table[7] = BitBlocks.literal<N4,byte>((byte)Bits.pack(result[7], on, on, on));
                require(table.GetCol(3) == bbResult);                
                table.emit(dst);
            }
        }

        static string header<M,N,T>(this BitMatrix<M,N,T> src, string label)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
        {
            var lastCol = src.ColCount - 1;
            var result = src.GetCol(lastCol);
            var sig = result.ToBitString().Format();
            var title = $"{label} {sig}";
            var sep = new string('-',80);
            var header = text.lines(title,sep);
            return header;
        }

        static string header<M,N,T,K>(this BitMatrix<M,N,T> src, K kind)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
            where K : struct, Enum
        {
            var lastCol = src.ColCount - 1;
            var result = src.GetCol(lastCol);
            var sig = result.ToBitString().Format();
            var title = $"{kind} {sig}";
            var sep = new string('-',80);
            var header = text.lines(title,sep);
            return header;
        }

        static void emit<M,N,T>(this BitMatrix<M,N,T> src, TextWriter dst)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
        {
            dst.Write(src.header("Table"));
            dst.WriteLine(src.Format());
        }


        static void emit<M,N,T,K>(this BitMatrix<M,N,T> src, K kind, TextWriter dst)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
            where K: struct, Enum
        {
            dst.Write(src.header(kind));
            dst.WriteLine(src.Format());
        }
    }
}