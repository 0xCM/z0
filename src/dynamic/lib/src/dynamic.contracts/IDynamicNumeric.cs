//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDynamicNumeric
    {
        UnaryOp<T> EmitUnaryOp<T>(BufferToken dst, ApiCodeBlock src)
            where T : unmanaged;

        BinaryOp<T> EmitBinaryOp<T>(BufferToken dst, ApiCodeBlock src)
            where T : unmanaged;

        TernaryOp<T> EmitTernaryOp<T>(BufferToken dst, ApiCodeBlock src)
            where T : unmanaged;
    }
}