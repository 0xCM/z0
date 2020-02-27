//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RecordSpec
    {   
        [MethodImpl(Inline)]
        public static RecordSpec Define(string Namespace, string TypeName, params RecordFieldSpec[] Fields)
            => new RecordSpec(Namespace, TypeName, Fields);
        
        [MethodImpl(Inline)]
        RecordSpec(string Namespace, string TypeName, params RecordFieldSpec[] Fields)
        {
            this.Namespace = Namespace;
            this.TypeName = TypeName;
            this.Fields = Fields;
        }
        
        public readonly string Namespace;
        
        public readonly string TypeName;

        public readonly RecordFieldSpec[] Fields;
    }
}