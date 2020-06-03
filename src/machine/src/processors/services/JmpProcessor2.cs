//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm.Data;
    using Z0.Asm;

    using static Seed;


/*
| 77 cb    | JA rel8     | ja short 0014h: encoded[2]{77 07}  | Jump short if above (CF=0 and ZF=0).                                           |
| 0F 87 cw | JA rel16    |                                    | Jump near if above (CF=0 and ZF=0). Not supported in 64-bit mode.              |
| 0F 87 cd | JA rel32    |                                    | Jump near if above (CF=0 and ZF=0).                                            |
| 73 cb    | JAE rel8    | jae short 0077h: encoded[2]{73 33} | Jump short if above or equal (CF=0).                                           |
| 0F 83 cw | JAE rel16   |                                    | Jump near if above or equal (CF=0). Not supported in 64-bit mode.              |
| 0F 83 cd | JAE rel32   |                                    | Jump near if above or equal (CF=0).                                            |
| 72 cb    | JB rel8     | jb short 005ch: encoded[2]{72 39}  | Jump short if below (CF=1).                                                    |
| 0F 82 cw | JB rel16    |                                    | Jump near if below (CF=1). Not supported in 64-bit mode.                       |
| 0F 82 cd | JB rel32    |                                    | Jump near if below (CF=1).                                                     |
| 70 cb    | JO rel8     | jo short 00c0h : encoded[2]{70 6e} | Jump short if overflow (OF=1).                                                 |
| 0F 80 cw | JO rel16    |                                    | Jump near if overflow (OF=1). Not supported in 64-bit mode.                    |
| 0F 80 cd | JO rel32    |                                    | Jump near if overflow (OF=1).                                                  |
*/
    public readonly struct JA<W>
        where W : ITypeWidth
    {
        
    }

    public readonly struct JA8
    {

    }

    public readonly struct JA16
    {
        
    }

    public readonly struct JA32
    {
        
    }

    public readonly struct JAE<W>
        where W : ITypeWidth
    {

    }

    public readonly struct JB<W>
        where W : ITypeWidth
    {

    }

    public struct JmpProcessor2
    {
        readonly DataBroker64<JmpKind,LocatedInstruction> broker;
        
        public IMachineContext Context {get;}
        
        [MethodImpl(Inline)]
        public void Connect()
        {
            // broker[JmpKind.JA] = DataHandlers.Create<LocatedInstruction>(OnJA);
            // broker[JmpKind.JAE] = DataHandlers.Create<LocatedInstruction>(OnJAE);
            // broker[JmpKind.JB] = DataHandlers.Create<LocatedInstruction>(OnJB);
            // broker[JmpKind.JBE] = DataHandlers.Create<LocatedInstruction>(OnJBE);
        }

        [MethodImpl(Inline)]
        internal JmpProcessor2(IMachineContext context, bool connect = true) 
        {
            Context = context;
            broker = ProcessBrokers.jmp();
            if(connect)
                Connect();
        }

        [MethodImpl(Inline)]
        public void Process(LocatedInstruction src)
        {
            if(src.Instruction.IsJccShortOrNear)
            {
                var kind = Enums.Parse(src.Mnemonic.ToString(),JmpKind.None);
                broker.Relay(kind,src);   
            }
        }

        [MethodImpl(Inline)]
        public void OnJA(LocatedInstruction inxs)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJAE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJB(LocatedInstruction inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJBE(LocatedInstruction inxs)
        {
            term.announce();            
        }        
    }
}