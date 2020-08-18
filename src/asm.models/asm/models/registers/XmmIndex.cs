//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using Z0.Asm.Dsl;
    
    public unsafe readonly ref struct XmmIndex
    {
        readonly Span<Xmm> Buffer;        

        readonly int RegisterCount;

        readonly Span<MemoryAddress> LocationBuffer;        
 
        [MethodImpl(Inline)]
        public static XmmIndex Create()
            => new XmmIndex(16);

        [MethodImpl(Inline)]
        public static XmmIndex Create(Xmm[] buffer, MemoryAddress[] locations)
            => new XmmIndex(buffer, locations);
       
        [MethodImpl(Inline)]
        XmmIndex(int k)
            : this()
        {            
            RegisterCount = k;
            Buffer = new Xmm[k];
            LocationBuffer = new MemoryAddress[k];
            for(var i=0u; i<k; i++)
            {
                seek(Buffer,i) = new Xmm(default, RegisterBits.join((RegisterCode)i, RegisterClass.XMM, RegisterWidth.W128));
            }
        }

        [MethodImpl(Inline)]
        XmmIndex(Xmm[] buffer, MemoryAddress[] locations)
            : this()
        {            
            RegisterCount = buffer.Length;
            Buffer = buffer;
            LocationBuffer = locations;            
        }

        public ReadOnlySpan<Xmm> Data
        {
            [MethodImpl(Inline)]
            get => Buffer;
        }

        public ReadOnlySpan<MemoryAddress> Locations
        {
            [MethodImpl(Inline)]
            get => UpdateLocations();
        }

        public ref Xmm this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Buffer,index);
        }

        [MethodImpl(Inline)]
        void Selected(Xmm r)
        {

        }        
        
        [MethodImpl(Inline)]
        void Selected(xmm0 r)
        {

        }

        [MethodImpl(Inline)]
        void Selected(xmm1 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm2 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm3 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm4 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm5 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm6 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm7 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm8 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm9 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm10 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm11 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm12 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm13 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm14 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(xmm15 r)
        {
            
        }

        public xmm0 xmm0         
        {
            [MethodImpl(Inline)]
            get => this[0];
        }

        public xmm1 xmm1
        {
            [MethodImpl(Inline)]
            get => this[1];

            [MethodImpl(Inline)]
            set => this[1] = value;
        }

        public xmm2 xmm2
        {
            [MethodImpl(Inline)]
            get => this[2];

            [MethodImpl(Inline)]
            set => this[2] = value;
        }

        public xmm3 xmm3
        {
            [MethodImpl(Inline)]
            get => this[3];

            [MethodImpl(Inline)]
            set => this[3] = value;
        }

        public xmm4 xmm4
        {
            [MethodImpl(Inline)]
            get => this[4];

            [MethodImpl(Inline)]
            set => this[4] = value;
        }

        public xmm5 xmm5
        {
            [MethodImpl(Inline)]
            get => this[5];

            [MethodImpl(Inline)]
            set => this[5] = value;
        }

        public xmm6 xmm6
        {
            [MethodImpl(Inline)]
            get => this[6];

            [MethodImpl(Inline)]
            set => this[6] = value;
        }

        public xmm7 xmm7
        {
            [MethodImpl(Inline)]
            get => this[7];

            [MethodImpl(Inline)]
            set => this[7] = value;
        }
        
        public xmm8 xmm8
        {
            [MethodImpl(Inline)]
            get => this[8];

            [MethodImpl(Inline)]
            set => this[8] = value;
        }

        public xmm9 xmm9
        {
            [MethodImpl(Inline)]
            get => this[9];

            [MethodImpl(Inline)]
            set => this[9] = value;

        }

        public xmm10 xmm10
        {
            [MethodImpl(Inline)]
            get => this[10];

            [MethodImpl(Inline)]
            set => this[10] = value;
        }

        public xmm11 xmm11
        {
            [MethodImpl(Inline)]
            get => this[11];

            [MethodImpl(Inline)]
            set => this[11] = value;
        }

        public xmm12 xmm12
        {
            [MethodImpl(Inline)]
            get => this[12];

            [MethodImpl(Inline)]
            set => this[12] = value;
        }

        public xmm13 xmm13
        {
            [MethodImpl(Inline)]
            get => this[13];

            [MethodImpl(Inline)]
            set => this[13] = value;
        }

        public xmm14 xmm14
        {
            [MethodImpl(Inline)]
            get => this[14];

            [MethodImpl(Inline)]
            set => this[14] = value;
        }

        public xmm15 xmm15
        {
            [MethodImpl(Inline)]
            get => this[15];

            [MethodImpl(Inline)]
            set => this[15] = value;
        }

        [MethodImpl(Inline)]
        unsafe ReadOnlySpan<MemoryAddress> UpdateLocations()
        {
            for(byte i=0; i<RegisterCount; i++)   
                seek(LocationBuffer,i) = pointer(ref this[i]);
            return LocationBuffer;
        }
    }
}