//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;
        
    [Table]
    public struct ImgResourceRecord 
    {
        public long Offset;

        public string Name;

        public string Attribute;

        public string Data;

        [MethodImpl(Inline)]
        internal ImgResourceRecord(string name, string attribute, long offset, string data)
        {
            this.Name = name;
            this.Attribute = attribute;
            this.Offset = offset;
            this.Data = data;
        }             
    }
}