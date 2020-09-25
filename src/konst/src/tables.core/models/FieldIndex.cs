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
    using static z;

   public readonly struct FieldIndex<F>
        where F : unmanaged, Enum
    {
        readonly FieldInfo[] Fields;

        public readonly string[] Names;

        public readonly F[] Values;

        public readonly uint Count;

        [MethodImpl(Inline)]
        internal FieldIndex(int k)
        {            
            Fields = typeof(F).Fields().Literals();
            Count = (uint)Fields.Length;
            Names = sys.alloc<string>(Count);
            Values = sys.alloc<F>(Count);

            var src = span(Fields);            
            for(var i=0; i<src.Length; i++)            
            {
                ref readonly var field = ref skip(src,i);
                Names[i] = field.Name;
                Values[i] = (F)field.GetRawConstantValue();
            }        
        }

        public F[] Literals 
        {        
            [MethodImpl(Inline)]
            get => Enums.literals<F>();
        }        

        [MethodImpl(Inline)]
        public short Position(F f)
            => (short)scalar<F,int>(f);

        [MethodImpl(Inline)]
        public short Width(F f)
            => (short)(scalar<F,int>(f) >> 16);

        public uint FieldCount
        {
            [MethodImpl(Inline)]
            get => (uint)Literals.Length;
        }
        
        public ref readonly F this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Literals[index];
        }
    }
}