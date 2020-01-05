//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;


    public enum CpuIdEcx : byte
    {
        SSE3 = 0,
        
        PCLMULQDQ = 1,
        
        DTES64 = 2,
        
        MONITOR = 3,

        DS_CPL = 4,
        
        VMX = 5,

        SMX = 6,
        
        EIST = 7

    }
    
    public static class CpuFeatureSet
    {
        public static CpuBitField<CpuIdEcx> Ecx(ulong data)
            => CpuBitField<CpuIdEcx>.Define(data);
    }

    public ref struct CpuFeatureSet<T>
        where T : unmanaged, Enum
    {
        const int DataSize = 32;

        static string[] SlotNames
            => Enums.names<T>();

        static T[] SlotValues
            => Enums.members<T>();

        uint data;

        BitView<uint> bits;
        
        public static CpuFeatureSet<T> Define(uint data)
            => new CpuFeatureSet<T>(data);

        CpuFeatureSet(uint data)
        {
            this.data = data;    
            this.bits = BitView.Over(ref this.data);
        }

        public bit this[T id]
        {            
            get => bits[0, ebyte(id)];
            set => bits[0, ebyte(id)] = value;
        }
                    
        public ReadOnlySpan<T> GetAvailable()
        {
            var max = Math.Min(DataSize, SlotNames.Length);
            var count =0;
            Span<T> dst = new T[max];
            for(var i=0; i< max; i++)
            {
                var sv = SlotValues[i];
                if (this[SlotValues[i]])
                    dst[count++] = sv;
            }
            return dst.Slice(0, count);
        }
    }

   public ref struct CpuBitField<T>
        where T : unmanaged, Enum
    {
        const int BitCount = 64;

        ulong data;

        BitView<ulong> bits;
        
        public static CpuBitField<T> Define(ulong data)
            => new CpuBitField<T>(data);

        CpuBitField(ulong data)
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
            get => Test(id);

            [MethodImpl(Inline)]
            set => bits[0, ebyte(id)] = value;
        }

        [MethodImpl(Inline)]
        public bit Test(T id)
            => bits[0, ebyte(id)];

        /// <summary>
        /// Retrieves the enabled fields
        /// </summary>
        public ReadOnlySpan<T> GetEnabled()
        {
            var identifiers = Enums.members<T>();
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