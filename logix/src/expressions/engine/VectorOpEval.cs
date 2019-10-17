//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    public static class VectorOpEval
    {
        public static Vec128<T> eval<T>(UnaryLogicOpKind op, Vec128<T> x)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicOpKind.Not:
                    return ginx.vnot(x);
                case UnaryLogicOpKind.Negate:
                    return ginx.vnegate(x);
            }
            return default;
        }

        public static Vec256<T> eval<T>(UnaryLogicOpKind op, Vec256<T> x)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicOpKind.Not:
                    return ginx.vnot(x);
                case UnaryLogicOpKind.Negate:
                    return ginx.vnegate(x);
            }
            return default;
        }

        public static Vec128<T> eval<T>(ShiftOpKind op, Vec128<T> x, int offset)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return ginx.vsll(x,(byte)offset);
                case ShiftOpKind.Srl:
                    return ginx.vsrl(x,(byte)offset);
                case ShiftOpKind.Rotl:
                    return ginx.vrotl(x,(byte)offset);
                case ShiftOpKind.Rotr:
                    return ginx.vrotr(x,(byte)offset);

            }
            return default;
        }

        public static Vec256<T> eval<T>(ShiftOpKind op, Vec256<T> x, int offset)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return ginx.vsll(x,(byte)offset);
                case ShiftOpKind.Srl:
                    return ginx.vsrl(x,(byte)offset);
                case ShiftOpKind.Rotl:
                    return ginx.vrotl(x,(byte)offset);
                case ShiftOpKind.Rotr:
                    return ginx.vrotr(x,(byte)offset);

            }
            return default;
        }

        public static Vec128<T> eval<T>(BinaryLogicOpKind op, Vec128<T> x, Vec128<T> y)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicOpKind.And:
                    return ginx.vand(x,y);
                case BinaryLogicOpKind.Or:
                    return ginx.vor(x,y);
                case BinaryLogicOpKind.XOr:
                    return ginx.vxor(x,y);
                case BinaryLogicOpKind.Nand:
                    return ginx.vnand(x,y);
                case BinaryLogicOpKind.Nor:
                    return ginx.vnor(x,y);
                case BinaryLogicOpKind.Xnor:
                    return ginx.vxnor(x,y);
            }
            return default;
        }

        public static Vector128<T> eval<T>(BinaryLogicOpKind op, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicOpKind.And:
                    return ginx.vand(x,y);
                case BinaryLogicOpKind.Or:
                    return ginx.vor(x,y);
                case BinaryLogicOpKind.XOr:
                    return ginx.vxor(x,y);
                case BinaryLogicOpKind.Nand:
                    return ginx.vnand(x,y);
                case BinaryLogicOpKind.Nor:
                    return ginx.vnor(x,y);
                case BinaryLogicOpKind.Xnor:
                    return ginx.vxnor(x,y);
            }
            return default;
        }

        public static Vec256<T> eval<T>(BinaryLogicOpKind op, Vec256<T> x, Vec256<T> y)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicOpKind.And:
                    return ginx.vand(x,y);
                case BinaryLogicOpKind.Or:
                    return ginx.vor(x,y);
                case BinaryLogicOpKind.XOr:
                    return ginx.vxor(x,y);
                case BinaryLogicOpKind.Nand:
                    return ginx.vnand(x,y);
                case BinaryLogicOpKind.Nor:
                    return ginx.vnor(x,y);
                case BinaryLogicOpKind.Xnor:
                    return ginx.vxnor(x,y);
            }
            return default;
        }

        public static Vector256<T> eval<T>(BinaryLogicOpKind op, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicOpKind.And:
                    return ginx.vand(x,y);
                case BinaryLogicOpKind.Or:
                    return ginx.vor(x,y);
                case BinaryLogicOpKind.XOr:
                    return ginx.vxor(x,y);
                case BinaryLogicOpKind.Nand:
                    return ginx.vnand(x,y);
                case BinaryLogicOpKind.Nor:
                    return ginx.vnor(x,y);
                case BinaryLogicOpKind.Xnor:
                    return ginx.vxnor(x,y);
            }
            return default;
        }

    }

}