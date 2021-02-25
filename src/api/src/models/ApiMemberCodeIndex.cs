//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// Correlates operation identifiers and coded members
    /// </summary>
    public readonly struct ApiMemberCodeIndex
    {
        readonly IReadOnlyDictionary<OpIdentity,ApiMemberCode> CodeIndex;

        readonly IReadOnlyDictionary<OpIdentity,ApiCodeBlock> BlockIndex;

        readonly ApiOpIndex<ApiCodeBlock> Blocks;

        [MethodImpl(Inline)]
        public ApiMemberCodeIndex(ApiMemberIndex members, ApiOpIndex<ApiCodeBlock> code, Index<ApiMemberCode> mc)
        {
            Blocks = code;
            CodeIndex = mc.Select(x => (x.Id, x)).ToDictionary();
            BlockIndex = code.Enumerated.Select(x => (x.Item1,  x.Item2)).ToDictionary();
        }

        public ApiCodeBlock this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get => BlockIndex[id];
        }

        public int EntryCount
        {
            [MethodImpl(Inline)]
            get => CodeIndex?.Count ?? 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => EntryCount == 0;
        }

        public IEnumerable<OpIdentity> Keys
            => CodeIndex.Keys;

        IEnumerable<ApiMemberCode> Values
            => CodeIndex.Values;

        IEnumerable<ApiCodeBlock> Values2
            => BlockIndex.Values;

        public IEnumerable<MethodInfo> Methods
            => Values.Select(v => v.Member.Method);

        public IEnumerable<ApiMemberCode> Search(ArityClass arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;

        public IEnumerable<ApiMemberCode> Search(OperatorArity @class)
            => from code in  Values
                let method = code.Member.Method
                where method.ClassifyOperator() == @class
                select code;

        public IEnumerable<ApiMemberCode> Search(ApiClass id)
            => from code in  Values
                let method = code.Member.Method
                where method.KindId() == id
                select code;

        public IEnumerable<ApiMemberCode> Operators
            => Values.Where(x => x.Member.Method.IsOperator());

        public IEnumerable<ApiMemberCode> UnaryOperators
            => Search(OperatorArity.UnaryOp);

        public IEnumerable<ApiMemberCode> BinaryOperators
            => Search(OperatorArity.BinaryOp);

        public IEnumerable<ApiMemberCode> TernaryOperators
            => Search(OperatorArity.TernaryOp);

        public IEnumerable<ApiMemberCode> NumericOperators(int? arity = null)
            => Values.Where(x => x.Member.Method.IsNumericOperator(arity));

        public IEnumerable<ApiMemberCode> KindedOperators()
            => from code in Values
                where code.Method.IsKindedOperator()
                select code;

        public IEnumerable<ApiMemberCode> KindedOperators(int arity)
            => from code in Values
                where code.Method.IsKindedOperator() && code.Method.ArityValue() == arity
                select code;

    }
}