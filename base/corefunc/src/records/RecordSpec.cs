//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;


    public class RecordSpec
    {   
        public static RecordSpec Define(string Namespace, string TypeName, params FieldSpec[] Fields)
            => new RecordSpec(Namespace, TypeName, Fields);
        
        public RecordSpec(string Namespace, string TypeName, params FieldSpec[] Fields)
        {
            this.Namespace = Namespace;
            this.TypeName = TypeName;
            this.Fields = Fields;
        }
        
        public string Namespace {get;}
        
        public string TypeName {get;}

        public FieldSpec[] Fields {get;}

    }


}