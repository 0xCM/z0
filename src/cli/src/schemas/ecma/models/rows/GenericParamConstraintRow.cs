//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct GenericParamConstraintRow : IRecord<GenericParamConstraintRow>
    {
        public RowKey Key;

        public int Owner;

        public int Constraint;
    }
}