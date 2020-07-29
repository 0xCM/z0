//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Clr;

    /// <summary>
    /// Characterizes a model of a class type
    /// </summary>
    public interface IClrClass : IClrType
    {
        ClrTypeKind IClrType.Kind 
            => ClrTypeKind.Class;   
    }
}