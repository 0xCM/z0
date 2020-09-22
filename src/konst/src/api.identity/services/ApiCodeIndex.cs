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
        internal static ApiCodeIndex create(ApiMemberIndex members, OpIndex<X86UriHex> code)
        {
            var apicode = from pair in members.Intersect(code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select new X86ApiMember(r.left, r.right);
            return new ApiCodeIndex(create(apicode.Select(c => (c.Id, c))));
        }

        readonly IReadOnlyDictionary<OpIdentity,X86ApiMember> Hashtable;

        [MethodImpl(Inline)]
        public ApiCodeIndex(in OpIndex<X86ApiMember> code)
        {
            Hashtable = code.Enumerated.ToDictionary();
        }

        public X86ApiMember this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get => Hashtable[id];
        }

        public int EntryCount
            => Hashtable.Count;

        public IEnumerable<OpIdentity> Keys
            => Hashtable.Keys;

        IEnumerable<X86ApiMember> Values
            => Hashtable.Values;

        public IEnumerable<MethodInfo> Methods
            => Values.Select(v => v.Member.Method);

        public IEnumerable<X86ApiMember> Search(ArityClassKind arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;

        public IEnumerable<X86ApiMember> Search(ApiOperatorClass @class)
            => from code in  Values
                let method = code.Member.Method
                where method.ClassifyOperator() == @class
                select code;

        public IEnumerable<X86ApiMember> Search(ApiKeyId id)
            => from code in  Values
                let method = code.Member.Method
                where method.KindId() == id
                select code;

        public IEnumerable<X86ApiMember> Operators
            => Values.Where(x => x.Member.Method.IsOperator());

        public IEnumerable<X86ApiMember> UnaryOperators
            => Search(ApiOperatorClass.UnaryOp);

        public IEnumerable<X86ApiMember> BinaryOperators
            => Search(ApiOperatorClass.BinaryOp);

        public IEnumerable<X86ApiMember> TernaryOperators
            => Search(ApiOperatorClass.TernaryOp);

        public IEnumerable<X86ApiMember> NumericOperators(int? arity = null)
            => Values.Where(x => x.Member.Method.IsNumericOperator(arity));

        public IEnumerable<X86ApiMember> KindedOperators()
            => from code in Values
                where code.Method.IsKindedOperator()
                select code;

        public IEnumerable<X86ApiMember> KindedOperators(int arity)
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