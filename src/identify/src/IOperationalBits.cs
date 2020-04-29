//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IOperationalBits
    {
        bool AcceptsParameter(OperationBits src, NumericKind kind)
            => Identify.numeric(src.Uri.OpId.TextComponents.Skip(1)).Contains(kind);

        IEnumerable<OperationBits> AcceptsParameters(IEnumerable<OperationBits> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Identify.numeric(code.Uri.OpId.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        IEnumerable<OperationBits> AcceptsParameter(IEnumerable<OperationBits> src, NumericKind kind)
            => from code in src
                where AcceptsParameter(code, kind)
                select code;

        [MethodImpl(Inline)]
        int ParameterCount(OperationBits src)
            => src.Uri.OpId.TextComponents.Count() - 1;
                    
        IEnumerable<OperationBits> WithParameterCount(IEnumerable<OperationBits> src, int count)
            => from code in src
                where ParameterCount(code) == count
                select code;        

        [MethodImpl(Inline)]
        OperationCode ToApiCode(OperationBits src)
            => OperationCode.Define(src.Uri.OpId, src.Encoded.Content);
    }
}