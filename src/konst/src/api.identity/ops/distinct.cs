//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using NK = NumericKind;
    using ID = ScalarKind;

    partial struct ApiIdentity
    {
        [Op]
        public static HashSet<NumericKind> distinct(NumericKind k)
        {
            var dst = new HashSet<NumericKind>();
            if(NumericKinds.contains(k, ID.U8))
                dst.Add(NK.U8);

            if(NumericKinds.contains(k, ID.I8))
                dst.Add(NK.I8);

            if(NumericKinds.contains(k, ID.U16))
                dst.Add(NK.U16);

            if(NumericKinds.contains(k, ID.I16))
                dst.Add(NK.I16);

            if(NumericKinds.contains(k, ID.U32))
                dst.Add(NK.U32);

            if(NumericKinds.contains(k, ID.I32))
                dst.Add(NK.I32);

            if(NumericKinds.contains(k, ID.U64))
                dst.Add(NK.U64);

            if(NumericKinds.contains(k, ID.I64))
                dst.Add(NK.I64);

            if(NumericKinds.contains(k, ID.F32))
                dst.Add(NK.F32);

            if(NumericKinds.contains(k, ID.F64))
                dst.Add(NK.F64);

            return dst;
        }
    }
}