//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;    
 
    public static partial class Data
    {
        public static ReadOnlySpan<byte> Units128x8u
            => new byte[16]{
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
                };

        public static ReadOnlySpan<byte> Units128x16u
            => new byte[16]{
                1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0
                };

        public static ReadOnlySpan<byte> Units128x32u
            => new byte[16]{
                1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0
                };

        public static ReadOnlySpan<byte> Units128x64u
            => new byte[16]{
                1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0
                };

        public static ReadOnlySpan<byte> Units256x8u
            => new byte[32]{
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
                };

        public static ReadOnlySpan<byte> Units256x16u
            => new byte[32]{
                1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,
                1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0
                };

        public static ReadOnlySpan<byte> Units256x32u
            => new byte[32]{
                1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,
                1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0
                };

        public static ReadOnlySpan<byte> Units256x64u
            => new byte[32]{
                1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
                1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0
                }; 

        [DataRegistry]
        static void RegisterUnits()
        {
            const string basename = "Units";
            var w = default(ITypeNat);
            var index = UnitsIndex;

            w = n128;
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U8), Units128x8u);
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U16), Units128x16u);
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U32), Units128x32u);
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U64), Units128x64u);
            
            w = n256;
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U8), Units256x8u);
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U16), Units256x16u);
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U32), Units256x32u);
            Register(index++, TypeIdentities.resource(basename, w, NumericKind.U64), Units256x64u);
        }

    }

}