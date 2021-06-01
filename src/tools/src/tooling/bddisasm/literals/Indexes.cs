//-----------------------------------------------------------------------------
// Copyright   : 2020 Bitdefender
// License     : Apache-2.0
// Source      : generate_tables.py
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial class BdDisasm
    {
        public readonly struct Indexes
        {
            [SymbolSource]
            public enum ModRm : byte
            {
                [Symbol("mem")]
                mem = 0,

                [Symbol("reg")]
                reg = 1,
            }

            [SymbolSource]
            public enum MandatoryPrefix : byte
            {
                [Symbol("NP")]
                np = 0,

                [Symbol("66")]
                x66 = 1,

                [Symbol("F3")]
                xF3 = 2,

                [Symbol("F2")]
                xF2 = 3
            }

            [SymbolSource]
            public enum OtherPrefix : byte
            {
                [Symbol("None")]
                None = 0,

                [Symbol("rexb")]
                rexb = 1,

                [Symbol("rexw")]
                rexw = 2,

                [Symbol("64")]
                x64 = 3,

                [Symbol("aF3")]
                aF3 = 4,

                [Symbol("rep")]
                rep = 5,

                [Symbol("sib")]
                sib = 6
            }

            [SymbolSource]
            public enum Mode : byte
            {
                [Symbol("None")]
                None = 0,

                [Symbol("m16")]
                m16 = 1,

                [Symbol("m32")]
                m32 = 2,

                [Symbol("m64")]
                m64 = 3,
            }


            [SymbolSource]
            public enum DefaultDataSize : byte
            {
                [Symbol("None")]
                None = 0,

                [Symbol("ds16")]
                ds16  = 1,

                [Symbol("ds32")]
                ds32  = 2,

                [Symbol("ds64")]
                ds64  = 3,

                [Symbol("dds64")]
                dds64 = 4,

                [Symbol("fds64")]
                fds64 = 5,
            }

            [SymbolSource]
            public enum DefaultAddressSize : byte
            {
                [Symbol("None")]
                None = 0,

                [Symbol("as16")]
                as16 = 1,

                [Symbol("as32")]
                as32 = 2,

                [Symbol("as64")]
                as64 = 3,
            }

            [SymbolSource]
            public enum VendorRedirection : byte
            {
                [Symbol("any")]
                any = 0,

                [Symbol("intel")]
                intel = 1,

                [Symbol("amd")]
                amd = 2,

                [Symbol("geode")]
                geode = 3,

                [Symbol("cyrix")]
                cyrix = 4,

            }

            [SymbolSource]
            public enum FeatureRedirection : byte
            {
                [Symbol("None")]
                None = 0,

                [Symbol("mpx")]
                mpx = 1,

                [Symbol("cet")]
                cet = 2,

                [Symbol("cldm")]
                cldm = 3
            }
        }
    }
}