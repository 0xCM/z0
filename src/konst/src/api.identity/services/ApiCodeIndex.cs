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
    public readonly struct ApiCodeIndex
    {
        internal static ApiCodeIndex create(ApiMemberIndex members, OpIndex<ApiHex> code)
        {
            var apicode = from pair in members.Intersect(code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select new ApiMemberHex(r.left, r.right);
            return new ApiCodeIndex(create(apicode.Select(c => (c.Id, c))));
        }

        readonly IReadOnlyDictionary<OpIdentity,ApiMemberHex> Hashtable;

        [MethodImpl(Inline)]
        public ApiCodeIndex(in OpIndex<ApiMemberHex> code)
        {
            Hashtable = code.Enumerated.ToDictionary();
        }

        public ApiMemberHex this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get => Hashtable[id];
        }

        public int EntryCount
            => Hashtable.Count;

        public IEnumerable<OpIdentity> Keys
            => Hashtable.Keys;

        IEnumerable<ApiMemberHex> Values
            => Hashtable.Values;

        public IEnumerable<MethodInfo> Methods
            => Values.Select(v => v.Member.Method);

        public IEnumerable<ApiMemberHex> Search(ArityClassKind arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;

        public IEnumerable<ApiMemberHex> Search(ApiOperatorClass @class)
            => from code in  Values
                let method = code.Member.Method
                where method.ClassifyOperator() == @class
                select code;

        public IEnumerable<ApiMemberHex> Search(ApiKeyId id)
            => from code in  Values
                let method = code.Member.Method
                where method.KindId() == id
                select code;

        public IEnumerable<ApiMemberHex> Operators
            => Values.Where(x => x.Member.Method.IsOperator());

        public IEnumerable<ApiMemberHex> UnaryOperators
            => Search(ApiOperatorClass.UnaryOp);

        public IEnumerable<ApiMemberHex> BinaryOperators
            => Search(ApiOperatorClass.BinaryOp);

        public IEnumerable<ApiMemberHex> TernaryOperators
            => Search(ApiOperatorClass.TernaryOp);

        public IEnumerable<ApiMemberHex> NumericOperators(int? arity = null)
            => Values.Where(x => x.Member.Method.IsNumericOperator(arity));

        public IEnumerable<ApiMemberHex> KindedOperators()
            => from code in Values
                where code.Method.IsKindedOperator()
                select code;

        public IEnumerable<ApiMemberHex> KindedOperators(int arity)
            => from code in Values
                where code.Method.IsKindedOperator() && code.Method.ArityValue() == arity
                select code;

        static OpIndex<T> create<T>(IEnumerable<(OpIdentity,T)> src)
        {
            try
            {
                var items = src.ToArray();
                var identities = items.Select(x => x.Item1).ToArray();
                var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                                where g.Count() > 1
                                select g.Key).ToHashSet();

                var dst = new Dictionary<OpIdentity,T>();
                if(duplicates.Count() != 0)
                    dst = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    dst = src.ToDictionary();
                return new OpIndex<T>(dst, duplicates.Select(d => ApiIdentityParser.parse(d)).Array());
            }
            catch(Exception e)
            {
                term.error(e);
                return OpIndex<T>.Empty;
            }
        }
    }
}