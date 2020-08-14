//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    
    public readonly struct HeaderCell<F>
        where F : unmanaged, Enum
    {
        public readonly uint Index;

        readonly FieldInfo Field;

        readonly F Value;
                
        [MethodImpl(Inline)]
        public HeaderCell(uint index, FieldInfo field, F value)
        {
            Index = index;
            Field = field;
            Value = value;
        }
        
        public string Name
        {
            [MethodImpl(Inline)]
            get => Field.Name;
        }
        
        public ushort Width
        {
            [MethodImpl(Inline)]
            get => z.@as<F,ushort>(Value);
        }
    }

}