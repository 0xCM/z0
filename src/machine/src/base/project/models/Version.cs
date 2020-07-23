//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ProjectModel;

    partial struct ProjectModel
    {
        public readonly struct Version : ITextual
        {
            public readonly uint Data;
            
            [MethodImpl(Inline)]
            public Version(byte a, byte b = 0, byte c = 0, byte d = 0)
                => Data = math.or((uint)a, (uint)b << 8, (uint)c << 16, (uint)d << 24);
            
            [MethodImpl(Inline)]
            public Version(uint data)
                => Data = data;
            
            public byte A 
                => (byte)Data;
            
            public byte B 
                => (byte)(Data >> 8);

            public byte C
                => (byte)(Data >> 16);

            public byte D 
                => (byte)(Data >> 24);

            public string Format()
            {
                var dst = A.ToString();
                
                if(B != 0)
                    dst += ("." + B.ToString());
                
                if(C != 0)
                    dst += ("." + C.ToString());

                if(D != 0)
                    dst += ("." + D.ToString());
                
                return dst;
            }

            public override string ToString()
                => Format();
        }
    }
}