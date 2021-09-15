//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class SRM
    {
        [Op]
        static PointerTableRefSizes _PointerTableRefSizes(int FieldRefSize, int MethodRefSize, int ParamRefSize, int EventRefSize, int PropertyRefSize)
        {
            var dst = new PointerTableRefSizes();
            dst.FieldRefSize = (uint)FieldRefSize;
            dst.MethodRefSize = (uint)MethodRefSize;
            dst.ParamRefSize = (uint)ParamRefSize;
            dst.EventRefSize = (uint)EventRefSize;
            dst.PropertyRefSize = (uint)PropertyRefSize;
            return dst;
        }
    }
}