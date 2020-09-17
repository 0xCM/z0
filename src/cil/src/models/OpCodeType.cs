//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct CilModel
    {
        public enum OpCodeType : byte
        {
            Annotation = 0,

            Macro = 1,

            Nternal = 2,

            Objmodel = 3,

            Prefix = 4,

            Primitive = 5,
        }
    }
}