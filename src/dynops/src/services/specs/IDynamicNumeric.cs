//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDynamicNumeric : IService
    {
        UnaryOp<T> EmitUnaryOp<T>(IBufferToken dst, IdentifiedCode src)
            where T : unmanaged;

        BinaryOp<T> EmitBinaryOp<T>(IBufferToken dst, IdentifiedCode src)
            where T : unmanaged;            

        TernaryOp<T> EmitTernaryOp<T>(IBufferToken dst, IdentifiedCode src)
            where T : unmanaged;            
    }
}