//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to a type to denote inclusion as a datatype within the DSL
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Delegate)]
    public class DatatypeAttribute : Attribute
    {
        public DatatypeAttribute()
        {
            Synonyms = Array.Empty<object>();
            VariableWidth = false;
        }

        public DatatypeAttribute(bool vwidth)
        {
            Synonyms = Array.Empty<object>();
            VariableWidth = vwidth;
        }

        public DatatypeAttribute(params object[] synonyms)
        {
            Synonyms = synonyms;
            VariableWidth = false;
        }

        public DatatypeAttribute(bool vwidth, params object[] synonyms)
        {
            Synonyms = synonyms;
            VariableWidth = vwidth;
        }

        public bool VariableWidth {get;}

        public object[] Synonyms {get;}
    }
}