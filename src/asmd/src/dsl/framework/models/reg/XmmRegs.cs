//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    using R = Dsl;

    public unsafe readonly ref struct XmmRegs
    {
        readonly Span<R.xmm> Buffer;        

        readonly int RegisterCount;

        readonly Span<MemoryAddress> LocationBuffer;        
 
        [MethodImpl(Inline)]
        public static XmmRegs Create()
            => new XmmRegs(16);

        [MethodImpl(Inline)]
        public static XmmRegs Create(R.xmm[] buffer, MemoryAddress[] locations)
            => new XmmRegs(buffer, locations);
       
        [MethodImpl(Inline)]
        XmmRegs(int k)
            : this()
        {            
            RegisterCount = k;
            Buffer = new R.xmm[k];
            LocationBuffer = new MemoryAddress[k];
            for(var i=0; i<k; i++)
            {
                seek(Buffer,i) = new R.xmm(default, RegisterBits.join((RegisterCode)i, RegisterClass.XMM, RegisterWidth.W128));
            }
        }

        [MethodImpl(Inline)]
        XmmRegs(R.xmm[] buffer, MemoryAddress[] locations)
            : this()
        {            
            RegisterCount = buffer.Length;
            Buffer = buffer;
            LocationBuffer = locations;
            
        }

        public ReadOnlySpan<R.xmm> Data
        {
            [MethodImpl(Inline)]
            get => Buffer;
        }

        public ReadOnlySpan<MemoryAddress> Locations
        {
            [MethodImpl(Inline)]
            get => UpdateLocations();
        }

        public ref R.xmm this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Buffer,index);
        }

        void Selected(R.xmm r)
        {

        }
        
        
        [MethodImpl(Inline)]
        void Selected(R.xmm0 r)
        {

        }

        [MethodImpl(Inline)]
        void Selected(R.xmm1 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm2 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm3 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm4 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm5 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm6 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm7 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm8 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm9 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm10 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm11 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm12 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm13 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm14 r)
        {
            
        }

        [MethodImpl(Inline)]
        void Selected(R.xmm15 r)
        {
            
        }

        public R.xmm0 xmm0         
        {
            [MethodImpl(Inline)]
            get => this[0];
        }

        public R.xmm1 xmm1
        {
            [MethodImpl(Inline)]
            get => this[1];

            [MethodImpl(Inline)]
            set => this[1] = value;
        }

        public R.xmm2 xmm2
        {
            [MethodImpl(Inline)]
            get => this[2];

            [MethodImpl(Inline)]
            set => this[2] = value;
        }

        public R.xmm3 xmm3
        {
            [MethodImpl(Inline)]
            get => this[3];

            [MethodImpl(Inline)]
            set => this[3] = value;
        }

        public R.xmm4 xmm4
        {
            [MethodImpl(Inline)]
            get => this[4];

            [MethodImpl(Inline)]
            set => this[4] = value;
        }

        public R.xmm5 xmm5
        {
            [MethodImpl(Inline)]
            get => this[5];

            [MethodImpl(Inline)]
            set => this[5] = value;
        }

        public R.xmm6 xmm6
        {
            [MethodImpl(Inline)]
            get => this[6];

            [MethodImpl(Inline)]
            set => this[6] = value;
        }

        public R.xmm7 xmm7
        {
            [MethodImpl(Inline)]
            get => this[7];

            [MethodImpl(Inline)]
            set => this[7] = value;
        }
        
        public R.xmm8 xmm8
        {
            [MethodImpl(Inline)]
            get => this[8];

            [MethodImpl(Inline)]
            set => this[8] = value;
        }

        public R.xmm9 xmm9
        {
            [MethodImpl(Inline)]
            get => this[9];

            [MethodImpl(Inline)]
            set => this[9] = value;

        }

        public R.xmm10 xmm10
        {
            [MethodImpl(Inline)]
            get => this[10];

            [MethodImpl(Inline)]
            set => this[10] = value;
        }

        public R.xmm11 xmm11
        {
            [MethodImpl(Inline)]
            get => this[11];

            [MethodImpl(Inline)]
            set => this[11] = value;
        }

        public R.xmm12 xmm12
        {
            [MethodImpl(Inline)]
            get => this[12];

            [MethodImpl(Inline)]
            set => this[12] = value;
        }

        public R.xmm13 xmm13
        {
            [MethodImpl(Inline)]
            get => this[13];

            [MethodImpl(Inline)]
            set => this[13] = value;
        }

        public R.xmm14 xmm14
        {
            [MethodImpl(Inline)]
            get => this[14];

            [MethodImpl(Inline)]
            set => this[14] = value;
        }

        public R.xmm15 xmm15
        {
            [MethodImpl(Inline)]
            get => this[15];

            [MethodImpl(Inline)]
            set => this[15] = value;
        }

        [MethodImpl(Inline)]
        unsafe ReadOnlySpan<MemoryAddress> UpdateLocations()
        {
            for(var i=0; i<RegisterCount; i++)   
                seek(LocationBuffer,i) = ptr(ref this[i]);
            return LocationBuffer;
        }
    }
}