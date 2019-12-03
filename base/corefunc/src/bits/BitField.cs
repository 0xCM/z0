//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a 64-bit bitfield parameterized by an enumeration that confers bit position, 
    /// labels and identifiers that for accessing/describing the underlying bits.
    /// The enumeration type itself would/should be tagged with that [Flags] attribute though
    /// that is not required.
    /// </summary>
    public ref struct BitField<T>
        where T : unmanaged, Enum
    {
        const int BitCount = 64;

        ulong data;

        BitView<ulong> bits;
        
        public static BitField<T> Define(ulong data)
            => new BitField<T>(data);

        BitField(ulong data)
        {
            this.data = data;    
            this.bits = BitView.Over(ref this.data);
        }

        /// <summary>
        /// Reads or Sets a value-identified field
        /// </summary>
        public bit this[T id]
        {            
            [MethodImpl(Inline)]
            get => bits[0, System.Convert.ToByte(id)];

            [MethodImpl(Inline)]
            set => bits[0,System.Convert.ToByte(id)] = value;
        }

        /// <summary>
        /// Retrieves all bits in the field
        /// </summary>
        public Span<BitFieldValue> Bits
        {
            get
            {   var identifiers = (T[])Enum.GetValues(typeof(T));
                var labels = Enum.GetNames(typeof(T));
                var len = Math.Min(BitCount, labels.Length);
                
                Span<BitFieldValue> dst = new BitFieldValue[len];
                ref var target = ref head(dst);
                for(byte pos=0; pos< len; pos++)
                    seek(ref target, pos) = new BitFieldValue(pos, labels[pos], this[identifiers[pos]]);
                return dst;
            }
        }        

        /// <summary>
        /// Retrieves the enabled fields
        /// </summary>
        public ReadOnlySpan<T> Enabled
        {
            get
            {   var identifiers = (T[])Enum.GetValues(typeof(T));
                var len = Math.Min(BitCount, identifiers.Length);
                var count =0;
                Span<T> dst = new T[len];
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