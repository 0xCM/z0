//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class FieldSynonymAttribute : Attribute
    {
        FieldSynonymAttribute(Enum other)
        {
            SynonymFor = other;
        }

        public FieldSynonymAttribute(object other)
            : this((Enum)other)
        {
            
        }

        public Enum SynonymFor {get;}
    }
}