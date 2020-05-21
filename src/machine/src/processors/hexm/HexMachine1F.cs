//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static HexCodes;

    public struct HexMachine1F
    {
        Vector128<byte> State;

        bit Processed;
        
        [MethodImpl(Inline), Op]
        public void Process(in ReadOnlySpan<byte> data)
        {
            var count = 0;
            for(var i=0; i<data.Length; i++)
            {

                if(Process(skip(data, i)))
                    count++;
            }
        }

        [MethodImpl(Inline), Op]
        public static HexMachine1F Create(Vector128<byte> state)
            => new HexMachine1F(state);
                    
        [MethodImpl(Inline)]
        HexMachine1F(Vector128<byte> state)
        {
            State = default;
            Processed = false;
        }

        [MethodImpl(Inline), Op]
        public bit Process(byte code)
        {
            Processed = false;
            Process(x10, code);
            return Processed;
        }

        [MethodImpl(Inline)]
        void Process(X10 a, byte code)
        {
            if(code == x10)
                Process(x10);
            else if(code == x11)
                Process(x11);
            else if(code== x12)
                Process(x12);
            else if(code == x13)
                Process(x13);
            else if(code == x14)
                Process(x14);
            else if(code == x15)
                Process(x15);
            else
                Process(x16,code);
        }

        [MethodImpl(Inline)]
        void Process(X16 a, byte code)
        {
            if(code == x16)
                Process(x16);
            else if(code == x17)
                Process(x17);
            else if(code == x18)
                Process(x18);
            else if(code == x19)
                Process(x19);
            else if(code == x1a)
                Process(x1a);
            else if(code == x1b)
                Process(x1b);
            else
                Process(x1c,code);

        }

        [MethodImpl(Inline)]
        void Process(X1C a, byte code)
        {
            if(code == x1c)
                Process(x1c);
            else if(code == x1d)
                Process(x1d);
            else if(code == x1e)
                Process(x1e);
            else if(code == x1f)
                Process(x1f);
        }

        [MethodImpl(Inline), Op]
        public void Process(X10 x)
        {
            State = State.WithElement(x, x);                            
        }

        [MethodImpl(Inline), Op]
        public void Process(X11 x)
        {
            State = State.WithElement(x, x);                        
        }

        [MethodImpl(Inline), Op]
        public void Process(X12 x)
        {
            State = State.WithElement(x, x);                            
        }

        [MethodImpl(Inline), Op]
        public void Process(X13 x)
        {
            State = State.WithElement(x, x);                                
        }

        [MethodImpl(Inline), Op]
        public void Process(X14 x)
        {
            State = State.WithElement(x, x);                           
        }

        [MethodImpl(Inline), Op]
        public void Process(X15 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X16 x)
        {
            State = State.WithElement(x, x);           
        }


        [MethodImpl(Inline), Op]
        public void Process(X17 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X18 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X19 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X1A x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X1B x)
        {
            State = State.WithElement(x, x);                            
        }

        [MethodImpl(Inline), Op]
        public void Process(X1C x)
        {
            State = State.WithElement(x, x);                                
        }

        [MethodImpl(Inline), Op]
        public void Process(X1D x)
        {
            State = State.WithElement(x, x);                                
        }

        [MethodImpl(Inline), Op]
        public void Process(X1E x)
        {
            State = State.WithElement(x, x);                       
         
        }

        [MethodImpl(Inline), Op]
        public void Process(X1F x)
        {
            State = State.WithElement(x, x);           
        }   
    }
}