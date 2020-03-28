//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static root;

    public readonly struct ApiCodeIndex 
    {
        readonly IReadOnlyDictionary<OpIdentity,ApiMemberCode> Hashtable;

        [MethodImpl(Inline)]
        public static ApiCodeIndex Create(in OpIndex<ApiMemberCode> code)
            => new ApiCodeIndex(code);

        [MethodImpl(Inline)]
        ApiCodeIndex(in OpIndex<ApiMemberCode> code)
        {
            this.Hashtable = code.Enumerated.ToDictionary();
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

        public IEnumerable<ApiMemberCode> Search(ArityClass arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;    

        public IEnumerable<ApiMemberCode> Search(OperatorClass @class)
            => from code in  Values
                let method = code.Member.Method
                where method.ClassifyOperator() == @class
                select code;    

        public IEnumerable<ApiMemberCode> Search(OpKindId id)
            => from code in  Values
                let method = code.Member.Method
                where method.KindId() == id
                select code;    

        public IEnumerable<ApiMemberCode> Operators
            => Values.Where(x => x.Member.Method.IsOperator());

        public IEnumerable<ApiMemberCode> UnaryOperators
            => Search(OperatorClass.UnaryOp);

        public IEnumerable<ApiMemberCode> BinaryOperators
            => Search(OperatorClass.BinaryOp);

        public IEnumerable<ApiMemberCode> TernaryOperators
            => Search(OperatorClass.TernaryOp);

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