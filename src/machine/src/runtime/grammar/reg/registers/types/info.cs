//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{

    using K = Z0.Asm.Data.RegisterKind;

    public readonly struct R8 : IReg8<Fixed8>
    {    
        public const uint Width = IReg8.Width;

        public string Name {get;}

        public K Kind {get;}

        public int Index {get;}
    }

    public readonly struct R16 : IReg16<Fixed16>
    {    
        public const uint Width = IReg16.Width;

        public string Name {get;}

        public K Kind {get;}

        public int Index {get;}
    }

    public readonly struct R32 : IReg32<Fixed32>
    {    
        public const uint Width = IReg32.Width;

        public string Name {get;}

        public K Kind {get;}

        public int Index {get;}
    }

    public readonly struct R64 : IReg64<Fixed64>
    {    
        public const uint Width = IReg64.Width;

        public string Name {get;}

        public K Kind {get;}

        public int Index {get;}
    }   

    public readonly struct Reg128 : IXmmReg<Fixed128>
    {
        public const uint Width = IXmmReg.Width;

        public string Name {get;}

        public int Index {get;}
    }

    public readonly struct Reg256 : IYmmReg<Fixed256>
    {
        public const uint Width = IYmmReg.Width;

        public string Name {get;}

        public int Index {get;}
    }

    public readonly struct Reg512 : IYmmReg<Fixed512>
    {
        public const uint Width = IZmmReg.Width;

        public string Name {get;}

        public int Index {get;}
    }
}