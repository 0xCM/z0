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
    public readonly struct ApiCodeIndex : IApiView<ApiCodeIndex,ApiOpIndex<ApiMemberCode>>
    {
        static ApiOpIndex<(L left, R right)> intersect<L,R>(IApiOpIndex<L> left, IApiOpIndex<R> right)
        {
             var keys = left.Keys.ToHashSet();
             keys.IntersectWith(right.Keys);
             var keylist = keys.ToArray();
             var count = keylist.Length;
             var entries = Arrays.alloc<(OpIdentity,(L,R))>(count);
             for(var i=0; i<count; i++)
             {
                var key = keylist[i];
                entries[i] = (key, (left[key], right[key]));
             }
             return ApiCode.index(entries);
         }

        internal static ApiCodeIndex create(ApiMemberIndex members, ApiOpIndex<ApiCodeBlock> code)
        {
            var apicode = from pair in intersect(members, code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select new ApiMemberCode(r.left, r.right);
            return new ApiCodeIndex(create(apicode.Select(c => (c.Id, c))));
        }

        readonly IReadOnlyDictionary<OpIdentity,ApiMemberCode> Hashtable;

        public ApiOpIndex<ApiMemberCode> Source {get;}

        [MethodImpl(Inline)]
        public ApiCodeIndex(in ApiOpIndex<ApiMemberCode> code)
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
            => Hashtable.Count;

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

        public IEnumerable<ApiMemberCode> Search(ApiOpId id)
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

        static ApiOpIndex<T> create<T>(IEnumerable<(OpIdentity,T)> src)
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
                return new ApiOpIndex<T>(dst, duplicates.Select(d => OpIdentityParser.parse(d)).Array());
            }
            catch(Exception e)
            {
                term.error(e);
                return ApiOpIndex<T>.Empty;
            }
        }
    }
}