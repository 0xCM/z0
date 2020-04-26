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

    using static Seed;
    using static Memories;

    /// <summary>
    /// Correlates operation identifiers and coded members
    /// </summary>
    public readonly struct ApiCodeIndex 
    {
        [MethodImpl(Inline)]
        public static ApiCodeIndex Create(in OpIndex<MemberCode> code)
            => new ApiCodeIndex(code);

        readonly IReadOnlyDictionary<OpIdentity,MemberCode> Hashtable;

        [MethodImpl(Inline)]
        ApiCodeIndex(in OpIndex<MemberCode> code)
        {
            this.Hashtable = code.Enumerated.ToDictionary(); 
        }

        public MemberCode this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get => Hashtable[id];
        }

        public int EntryCount
            => Hashtable.Count;
            
        public IEnumerable<OpIdentity> Keys
            => Hashtable.Keys;
        
        IEnumerable<MemberCode> Values
            => Hashtable.Values;

        public IEnumerable<MethodInfo> Methods
            => Values.Select(v => v.Member.Method);

        public IEnumerable<MemberCode> Search(ArityClass arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;    

        public IEnumerable<MemberCode> Search(OperatorClass @class)
            => from code in  Values
                let method = code.Member.Method
                where method.ClassifyOperator() == @class
                select code;    

        public IEnumerable<MemberCode> Search(OpKindId id)
            => from code in  Values
                let method = code.Member.Method
                where method.KindId() == id
                select code;    

        public IEnumerable<MemberCode> Operators
            => Values.Where(x => x.Member.Method.IsOperator());

        public IEnumerable<MemberCode> UnaryOperators
            => Search(OperatorClass.UnaryOp);

        public IEnumerable<MemberCode> BinaryOperators
            => Search(OperatorClass.BinaryOp);

        public IEnumerable<MemberCode> TernaryOperators
            => Search(OperatorClass.TernaryOp);

        public IEnumerable<MemberCode> NumericOperators(int? arity = null)
            => Values.Where(x => x.Member.Method.IsNumericOperator(arity));

        public IEnumerable<MemberCode> KindedOperators()
            => from code in Values
                where code.Method.IsKindedOperator()
                select code;

        public IEnumerable<MemberCode> KindedOperators(int arity)
            => from code in Values
                where code.Method.IsKindedOperator() && code.Method.ArityValue() == arity
                select code;
    }
}