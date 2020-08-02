//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly struct ImgResourceRecord
    {
        public long Offset {get;}

        public string Name {get;}

        public string Attribute {get;}

        public string Implementation {get;}

        [MethodImpl(Inline)]
        internal ImgResourceRecord(string Name, string Attribute, long Offset, string Implementation)
        {
            this.Name = Name;
            this.Attribute = Attribute;
            this.Offset = Offset;
            this.Implementation = Implementation;
        }             
    }
}