//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class TruthTables
    {
        public static BitVector4 Signature(UnaryLogicOpKind id)
        {
            var op = LogicOpApi.lookup(id);
            var x = BitVector4.Zero;
            x[0] = op(off); // 00 -> (0,0)
            x[1] = op(on);  // 01 -> (1,0)
            return x;
        }

        public static BitVector4 Signature(BinaryLogicOpKind id)
        {
            var op = LogicOpApi.lookup(id);
            var x = BitVector4.Zero;
            x[0] = op(off,off);
            x[1] = op(on,off);
            x[2] = op(off,on);
            x[3] = op(on,on);
            return x;
        }
        
        public static BitVector8 Signature(TernaryBitOpKind id)
        {
            var op = LogicOpApi.lookup(id);
            var x = BitVector8.Zero;
            x[0] = op(off,off,off);
            x[1] = op(off,off,on);
            x[2] = op(off,on,off);
            x[3] = op(off,on,on);
            x[4] = op(on,off,off);
            x[5] = op(on,off,on);
            x[6] = op(on,on, off);
            x[7] = op(on,on,on);
            return x;
        }

        public static BitMatrix<N2,N2,byte> Build(UnaryLogicOpKind kind)
        {
            var f = LogicOpApi.lookup(kind);
            var table = BitMatrix.natural<N2,N2,byte>();
            table[0] = BitVector.natural<N2,byte>(Bits.pack2(f(off), off));
            table[1] = BitVector.natural<N2,byte>(Bits.pack2(f(on), on));
            return table;            
        }

        public static BitMatrix<N4,N3,byte> Build(BinaryLogicOpKind kind)
        {
            var tt = BitMatrix.natural<N4,N3,byte>();
            var f = LogicOpApi.lookup(kind);
            tt[0] = BitVector.natural<N3,byte>(Bits.pack3(f(off, off), off, off));
            tt[1] = BitVector.natural<N3,byte>(Bits.pack3(f(on, off), off, on));
            tt[2] = BitVector.natural<N3,byte>(Bits.pack3(f(off, on), on, off));
            tt[3] = BitVector.natural<N3,byte>(Bits.pack3(f(on, on),  on, on));
            return tt;
        }

        public static BitMatrix<N8,N4,byte> Build(TernaryBitOpKind kind)
        {
            var tt = BitMatrix.natural<N8,N4,byte>();
            var f = LogicOpApi.lookup(kind);
            tt[0] = BitVector.natural<N4,byte>(Bits.pack4(f(off, off, off), off, off, off));
            tt[1] = BitVector.natural<N4,byte>(Bits.pack4(f(off, off, on), off, off, on));
            tt[2] = BitVector.natural<N4,byte>(Bits.pack4(f(off, on, off), off, on, off));
            tt[3] = BitVector.natural<N4,byte>(Bits.pack4(f(off, on, on), off, on, on));
            tt[4] = BitVector.natural<N4,byte>(Bits.pack4(f(on, off, off), on, off, off));
            tt[5] = BitVector.natural<N4,byte>(Bits.pack4(f(on, off, on), on, off, on));
            tt[6] = BitVector.natural<N4,byte>(Bits.pack4(f(on, on, off), off, on, on));
            tt[7] = BitVector.natural<N4,byte>(Bits.pack4(f(on, on, on), on, on, on));
            return tt;
        }

        public static void Emit(TextWriter dst, params UnaryLogicOpKind[] kinds)
            => kinds.Iterate(k => Emit(k,dst));

        public static void Emit(TextWriter dst, params BinaryLogicOpKind[] kinds)
            => kinds.Iterate(k => Emit(k,dst));

        public static void Emit(TextWriter dst, params TernaryBitOpKind[] kinds)
            => kinds.Iterate(k => Emit(k,dst));

        public static void Emit(TextWriter dst, OpArityKind arity)
        {
            switch(arity)
            {

                case OpArityKind.Unary: EmitUnaryOps(dst); break;
                case OpArityKind.Binary: EmitBinaryOps(dst); break;
                case OpArityKind.Ternary: EmitTernaryOps(dst); break;
                default: 
                    throw unsupported(arity);
            }
        }

        static BitMatrix<N2,N2,byte> Emit(UnaryLogicOpKind kind, TextWriter dst)
        {
            var table = Build(kind);
            table.Emit2(kind,dst);
            return table;
        }

        static BitMatrix<N4,N3,byte> Emit(BinaryLogicOpKind kind, TextWriter dst)
        {
            var table = Build(kind);
            table.Emit2(kind,dst);
            return table;
        }

        static BitMatrix<N8,N4,byte> Emit(TernaryBitOpKind kind, TextWriter dst)
        {
            var table = Build(kind);
            table.Emit2(kind,dst);
            return table;
        }


        static void EmitUnaryOps(TextWriter dst)
        {
            var ops = LogicOpApi.UnaryOpKinds.ToArray();
            for(var i=0; i< ops.Length; i++)
            {
                BitVector4 result = (byte)i;
                var table = BitMatrix.natural<N2,N2,byte>();
                table[0] = BitVector.natural<N2,byte>(Bits.pack2(result[0], off));
                table[1] = BitVector.natural<N2,byte>(Bits.pack2(result[0], on));
                table.Emit2(dst);
                
            }
        }

        static void EmitBinaryOps(TextWriter dst)
        {
            for(var i=0; i< 16; i++)
            {
                BitVector4 result = (byte)i;
                var table = BitMatrix.natural<N4,N3,byte>();
                table[0] = BitVector.natural<N3,byte>(Bits.pack3(result[0], off, off));
                table[1] = BitVector.natural<N3,byte>(Bits.pack3(result[1], off, on));
                table[2] = BitVector.natural<N3,byte>(Bits.pack3(result[2], on, off));
                table[3] = BitVector.natural<N3,byte>(Bits.pack3(result[3], on, on));
                require(table.GetCol(2) == result);                
                table.Emit2(dst);
            }
        }

        static void EmitTernaryOps(TextWriter dst)
        {
            for(var i=0; i< 256; i++)
            {
                BitVector8 result = (byte)i;
                var table = BitMatrix.natural<N8,N4,byte>();
                table[0] = BitVector.natural<N4,byte>(Bits.pack4(result[0], off, off, off));
                table[1] = BitVector.natural<N4,byte>(Bits.pack4(result[1], off, off, on));
                table[2] = BitVector.natural<N4,byte>(Bits.pack4(result[2], off, on, off));
                table[3] = BitVector.natural<N4,byte>(Bits.pack4(result[3], off, on, on));
                table[4] = BitVector.natural<N4,byte>(Bits.pack4(result[4], on, off, off));
                table[5] = BitVector.natural<N4,byte>(Bits.pack4(result[5], on, off, on));
                table[6] = BitVector.natural<N4,byte>(Bits.pack4(result[6], on, on, off));
                table[7] = BitVector.natural<N4,byte>(Bits.pack4(result[7], on, on, on));
                require(table.GetCol(3) == result);                
                table.Emit2(dst);

            }
        }

        static string Header<M,N,T>(this BitMatrix<M,N,T> src, string label)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged

        {
            var lastCol = src.ColCount - 1;
            var result = src.GetCol(lastCol);
            var sig = result.ToBitString().Format();
            var title = $"{label} {sig}";
            var sep = new string('-',80);
            var header = lines(title,sep);
            return header;
        }

        static string KindHeader<M,N,T,K>(this BitMatrix<M,N,T> src, K kind)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
            where K : struct, Enum
                => src.Header(kind.ToString());

        static string TableHeader<M,N,T>(this BitMatrix<M,N,T> src)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => src.Header("Table");


        static void Emit2<M,N,T>(this BitMatrix<M,N,T> src, TextWriter dst)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
        {
            dst.Write(src.TableHeader());
            dst.WriteLine(src.Format());
        }

        static void Emit2<M,N,T,K>(this BitMatrix<M,N,T> src, K kind, TextWriter dst)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
            where K: struct, Enum
        {
            dst.Write(src.KindHeader(kind));
            dst.WriteLine(src.Format());
        }


    }

}

