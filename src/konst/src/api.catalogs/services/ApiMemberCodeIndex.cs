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

    using static Konst;

    /// <summary>
    /// Correlates operation identifiers and coded members
    /// </summary>
    public readonly struct ApiMemberCodeIndex
    {
        readonly IReadOnlyDictionary<OpIdentity,ApiMemberCode> Hashtable;

        public ApiOpIndex<ApiMemberCode> Source {get;}

        [MethodImpl(Inline)]
        internal ApiMemberCodeIndex(in ApiOpIndex<ApiMemberCode> code)
        {
            Source = code;
            Hashtable = code.Enumerated.ToDictionary();
        }

        public ApiMemberCode this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get => Hashtable[id];
        }

        public int EntryCount
        {
            [MethodImpl(Inline)]
            get => Hashtable?.Count ?? 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => EntryCount == 0;
        }

        public IEnumerable<OpIdentity> Keys
            => Hashtable.Keys;

        IEnumerable<ApiMemberCode> Values
            => Hashtable.Values;

        public IEnumerable<MethodInfo> Methods
            => Values.Select(v => v.Member.Method);

        public IEnumerable<ApiMemberCode> Search(ArityKind arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;

        public IEnumerable<ApiMemberCode> Search(ApiOperatorClass @class)
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
            => Search(ApiOperatorClass.UnaryOp);

        public IEnumerable<ApiMemberCode> BinaryOperators
            => Search(ApiOperatorClass.BinaryOp);

        public IEnumerable<ApiMemberCode> TernaryOperators
            => Search(ApiOperatorClass.TernaryOp);

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

        public static ApiMemberCodeIndex Empty
        {
            [MethodImpl(Inline)]
            get => new ApiMemberCodeIndex(ApiOpIndex<ApiMemberCode>.Empty);
        }
    }
}