//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a model of an unmanaged type
    /// </summary>
    public interface IClrStruct : IClrType
    {
        ClrTypeKind IClrType.Kind
            => ClrTypeKind.Struct;
    }
}