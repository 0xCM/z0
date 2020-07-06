//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFunctionPointer
    {        
        DynamicPointer Pointer(DynamicDelegate src)
            => FunctionPointer.from(src);

        DynamicPointer Pointer<D>(DynamicDelegate<D> src)
            where D : Delegate
                => FunctionPointer.from(src);
    }
}