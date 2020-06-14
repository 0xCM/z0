//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    /// <summary>
    /// C# doesn't support native bitfields
    /// </summary>
    public readonly struct xed_flag_set
    {
        readonly uint state;

        [MethodImpl(Inline)]
        public static implicit operator xed_flag_set(xed_uint32_t src)    
            => new xed_flag_set(src);

        [MethodImpl(Inline)]
        public static implicit operator xed_flag_set(uint src)    
            => new xed_flag_set(src);

        [MethodImpl(Inline)]
        public xed_flag_set(xed_uint32_t src)    
            => state = src;        

        public xed_uint32_t must_be_1
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n0, state);
        }

        public xed_uint32_t cf
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n1, state);

            [MethodImpl(Inline)]
            set => BitWriter.Write(n1, state, value);
        }

        public xed_uint32_t pf
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n2, state);
        }

        public xed_uint32_t zf
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n3, state);
        }

        public xed_uint32_t sf
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n4, state);
        }

        public xed_uint32_t tf
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n5, state);
        }

        public xed_uint32_t _if
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n6, state);
        }

        public xed_uint32_t df
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n7, state);
        }

        public xed_uint32_t of
        {
            [MethodImpl(Inline)]
            get => BitReader.Read(n8, state);
        }
        /*

            xed_uint32_t must_be_1:1;
            xed_uint32_t pf:1;
            xed_uint32_t must_be_0a:1;
            
            xed_uint32_t af:1; ///< bit 4
            xed_uint32_t must_be_0b:1;
            xed_uint32_t zf:1;
            xed_uint32_t sf:1;
            
            xed_uint32_t tf:1;  ///< bit 8
            xed_uint32_t _if:1;  ///< underscore to avoid token clash
            xed_uint32_t df:1;
            xed_uint32_t of:1;
            
            xed_uint32_t iopl:2; ///< A 2-bit field, bits 12-13
            xed_uint32_t nt:1;
            xed_uint32_t must_be_0c:1;
            
            xed_uint32_t rf:1; ///< bit 16
            xed_uint32_t vm:1;
            xed_uint32_t ac:1;
            xed_uint32_t vif:1;
            
            xed_uint32_t vip:1; ///< bit 20
            xed_uint32_t id:1;   ///< bit 21
            xed_uint32_t must_be_0d:2;  ///< bits 22-23
            
            xed_uint32_t must_be_0e:4;  ///< bits 24-27

            // fc0,fc1,fc2,fc3 are not really part of rflags but I put them
            // here to save space. These bits are only used for x87
            // instructions.
            xed_uint32_t fc0:1;  ///< x87 flag FC0 (not really part of rflags)
            xed_uint32_t fc1:1;  ///< x87 flag FC1 (not really part of rflags)
            xed_uint32_t fc2:1;  ///< x87 flag FC2 (not really part of rflags)
            xed_uint32_t fc3:1;  ///< x87 flag FC3 (not really part of rflags)

        */
    }
}