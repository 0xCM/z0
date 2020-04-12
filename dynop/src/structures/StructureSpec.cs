//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public readonly struct StructureSpec
    {   
        [MethodImpl(Inline)]
        public static StructureSpec Define(string Namespace, string TypeName, params StructuredField[] Fields)
            => new StructureSpec(Namespace, TypeName, Fields);
        
        [MethodImpl(Inline)]
        StructureSpec(string Namespace, string TypeName, params StructuredField[] Fields)
        {
            this.Namespace = Namespace;
            this.TypeName = TypeName;
            this.Fields = Fields;
        }
        
        public readonly string Namespace;
        
        public readonly string TypeName;

        public readonly StructuredField[] Fields;
    }
}