//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;   
    using static z;

   public readonly struct TableFields<F>
        where F : unmanaged, Enum
    {
        readonly FieldInfo[] Fields;

        public readonly string[] Names;

        public readonly F[] Values;

        public readonly uint Count;

        [MethodImpl(Inline)]
        internal TableFields(FieldInfo[] fields)
        {            
            Fields = fields;
            Count = (uint)Fields.Length;
            Names = sys.alloc<string>(Count);
            Values = sys.alloc<F>(Count);
            Fill();
        }

        public F[] Literals 
        {        
            [MethodImpl(Inline)]
            get => Values;
        }        

        [MethodImpl(Inline)]
        public short Width(F f)
            => (short)(scalar<F,ushort>(f));

        [MethodImpl(Inline)]
        public string Name(uint index)
            => Names[index];

        [MethodImpl(Inline)]
        public FieldInfo Reflected(uint index)
            => Fields[index];

        public uint FieldCount
        {
            [MethodImpl(Inline)]
            get => Count;
        }
        
        public ref readonly F this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Literals[index];
        }

        void Fill()
        {
            var src = span(Fields);            
            for(var i=0; i<src.Length; i++)            
            {
                ref readonly var field = ref z.skip(src,i);
                Names[i] = field.Name;
                Values[i] = (F)field.GetRawConstantValue();
            }        
        }
    }
}