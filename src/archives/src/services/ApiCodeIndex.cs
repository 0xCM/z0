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
        readonly IReadOnlyDictionary<OpIdentity,ApiCode> Hashtable;

        [MethodImpl(Inline)]
        public ApiCodeIndex(in OpIndex<ApiCode> code)
        {
            this.Hashtable = code.Enumerated.ToDictionary(); 
        }

        public ApiCode this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get => Hashtable[id];
        }

        public int EntryCount
            => Hashtable.Count;
            
        public IEnumerable<OpIdentity> Keys
            => Hashtable.Keys;
        
        IEnumerable<ApiCode> Values
            => Hashtable.Values;

        public IEnumerable<MethodInfo> Methods
            => Values.Select(v => v.Member.Method);

        public IEnumerable<ApiCode> Search(ArityClass arity)
            => from code in  Values
                let method = code.Member.Method
                where method.ArityValue() == (int)arity
                select code;    

        public IEnumerable<ApiCode> Search(OperatorClass @class)
            => from code in  Values
                let method = code.Member.Method
                where method.ClassifyOperator() == @class
                select code;    

        public IEnumerable<ApiCode> Search(OpKindId id)
            => from code in  Values
                let method = code.Member.Method
                where method.KindId() == id
                select code;    

        public IEnumerable<ApiCode> Operators
            => Values.Where(x => x.Member.Method.IsOperator());

        public IEnumerable<ApiCode> UnaryOperators
            => Search(OperatorClass.UnaryOp);

        public IEnumerable<ApiCode> BinaryOperators
            => Search(OperatorClass.BinaryOp);

        public IEnumerable<ApiCode> TernaryOperators
            => Search(OperatorClass.TernaryOp);

        public IEnumerable<ApiCode> NumericOperators(int? arity = null)
            => Values.Where(x => x.Member.Method.IsNumericOperator(arity));

        public IEnumerable<ApiCode> KindedOperators()
            => from code in Values
                where code.Method.IsKindedOperator()
                select code;

        public IEnumerable<ApiCode> KindedOperators(int arity)
            => from code in Values
                where code.Method.IsKindedOperator() && code.Method.ArityValue() == arity
                select code;
    }
}