//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    /// <summary>
    /// Specifies the meaning of a numeric code where applied
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class MklCodeAttribute : Attribute
    {
        public MklCodeAttribute(string Meaning)
        {
            this.Meaning = Meaning;
        }

        public string Meaning {get;}
    }
}
