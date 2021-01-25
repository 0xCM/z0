//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct ClassfiedApi
    {
        public const string TableName = "api.operations";

        public ApiClass ClassId;

        public ApiAsmClass AsmId;

        public OperationName Name;

        public TypeName ReturnType;

        public Index<ApiOperand> Operands;
    }
}