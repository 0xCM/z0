//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public ref struct BitField<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        static int BitCount => bitsize<T>();

        T data;

        BitView<T> bits;
        
        public static BitField<E,T> Define(T data)
            => new BitField<E,T>(data);

        BitField(T data)
        {
            this.data = data;    
            this.bits = BitView.Over(ref this.data);
        }

        /// <summary>
        /// Reads or Sets a value-identified field
        /// </summary>
        public bit this[E id]
        {            
            [MethodImpl(Inline)]
            get => bits[0, System.Convert.ToByte(id)];

            [MethodImpl(Inline)]
            set => bits[0,System.Convert.ToByte(id)] = value;
        }

        /// <summary>
        /// Retrieves the enabled fields
        /// </summary>
        public ReadOnlySpan<E> Enabled
        {
            get
            {   var identifiers = (E[])Enum.GetValues(typeof(E));
                var len = Math.Min(BitCount, identifiers.Length);
                var count =0;
                Span<E> dst = new E[len];
                for(var i=0; i< len; i++)
                {
                    var sv = identifiers[i];
                    if (this[identifiers[i]])
                        dst[count++] = sv;
                }
                return dst.Slice(0, count);
            }
        }
    }

}