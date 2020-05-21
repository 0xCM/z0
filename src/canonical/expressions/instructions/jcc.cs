//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Z0.Asm.Data;
    
    using static Seed;
    using static Asm.Data.JccCode;

/*
    # Specs
    ------------------------------------------------------------------------------------------------------------------------------------------------------
    | Expression | Instruction   | M16      | M32      | M64      | CpuId      | Id                                                
    | 0F 87 cd   | JA rel32      | Y        | Y        | N        | 386+       | Ja_rel32_32                                       
    | 0F 87 cd   | JA rel32      | N        | N        | Y        | X64        | Ja_rel32_64                                       
    | 0F 87 cw   | JA rel16      | Y        | Y        | Y        | 386+       | Ja_rel16                                          

    | 77 cb      | JA rel8       | Y        | Y        | Y        | 8086+      | Ja_rel8_16                                        
    | 77 cb      | JA rel8       | Y        | Y        | N        | 386+       | Ja_rel8_32                                        
    | 77 cb      | JA rel8       | N        | N        | Y        | X64        | Ja_rel8_64                                        

    | 0F 83 cd   | JAE rel32     | Y        | Y        | N        | 386+       | Jae_rel32_32                                      
    | 0F 83 cd   | JAE rel32     | N        | N        | Y        | X64        | Jae_rel32_64                                      
    | 0F 83 cw   | JAE rel16     | Y        | Y        | Y        | 386+       | Jae_rel16                                         
    | 73 cb      | JAE rel8      | Y        | Y        | Y        | 8086+      | Jae_rel8_16                                       
    | 73 cb      | JAE rel8      | Y        | Y        | N        | 386+       | Jae_rel8_32                                       
    | 73 cb      | JAE rel8      | N        | N        | Y        | X64        | Jae_rel8_64                                       

    | 0F 82 cd   | JB rel32      | Y        | Y        | N        | 386+       | Jb_rel32_32                                       
    | 0F 82 cd   | JB rel32      | N        | N        | Y        | X64        | Jb_rel32_64                                       
    | 0F 82 cw   | JB rel16      | Y        | Y        | Y        | 386+       | Jb_rel16                                          
    | 72 cb      | JB rel8       | Y        | Y        | Y        | 8086+      | Jb_rel8_16                                        
    | 72 cb      | JB rel8       | Y        | Y        | N        | 386+       | Jb_rel8_32                                        
    | 72 cb      | JB rel8       | N        | N        | Y        | X64        | Jb_rel8_64                                        

    | 0F 86 cd   | JBE rel32     | Y        | Y        | N        | 386+       | Jbe_rel32_32                                      
    | 0F 86 cd   | JBE rel32     | N        | N        | Y        | X64        | Jbe_rel32_64                                      
    | 0F 86 cw   | JBE rel16     | Y        | Y        | Y        | 386+       | Jbe_rel16                                         
    | 76 cb      | JBE rel8      | Y        | Y        | Y        | 8086+      | Jbe_rel8_16                                       
    | 76 cb      | JBE rel8      | Y        | Y        | N        | 386+       | Jbe_rel8_32                                       
    | 76 cb      | JBE rel8      | N        | N        | Y        | X64        | Jbe_rel8_64                                       

    | a16 o16 E3 | JCXZ rel8     | Y        | Y        | N        | 8086+      | Jcxz_rel8_16                                      
    | a16 o32 E3 | JCXZ rel8     | Y        | Y        | N        | 386+       | Jcxz_rel8_32                                      

    | 0F 84 cd   | JE rel32      | Y        | Y        | N        | 386+       | Je_rel32_32                                       
    | 0F 84 cd   | JE rel32      | N        | N        | Y        | X64        | Je_rel32_64                                       
    | 0F 84 cw   | JE rel16      | Y        | Y        | Y        | 386+       | Je_rel16                                          
    | 74 cb      | JE rel8       | Y        | Y        | Y        | 8086+      | Je_rel8_16                                        
    | 74 cb      | JE rel8       | Y        | Y        | N        | 386+       | Je_rel8_32                                        
    | 74 cb      | JE rel8       | N        | N        | Y        | X64        | Je_rel8_64                                        
    | a32 E3 cb  | JECXZ rel8    | N        | N        | Y        | X64        | Jecxz_rel8_64                                     
    | a32 o16 E3 | JECXZ rel8    | Y        | Y        | Y        | 386+       | Jecxz_rel8_16                                     
    | a32 o32 E3 | JECXZ rel8    | Y        | Y        | N        | 386+       | Jecxz_rel8_32                                     
    | 0F 8F cd   | JG rel32      | Y        | Y        | N        | 386+       | Jg_rel32_32                                       
    | 0F 8F cd   | JG rel32      | N        | N        | Y        | X64        | Jg_rel32_64                                       
    | 0F 8F cw   | JG rel16      | Y        | Y        | Y        | 386+       | Jg_rel16                                          
    | 7F cb      | JG rel8       | Y        | Y        | Y        | 8086+      | Jg_rel8_16                                        
    | 7F cb      | JG rel8       | Y        | Y        | N        | 386+       | Jg_rel8_32                                        
    | 7F cb      | JG rel8       | N        | N        | Y        | X64        | Jg_rel8_64                                        
    | 0F 8D cd   | JGE rel32     | Y        | Y        | N        | 386+       | Jge_rel32_32                                      
    | 0F 8D cd   | JGE rel32     | N        | N        | Y        | X64        | Jge_rel32_64                                      
    | 0F 8D cw   | JGE rel16     | Y        | Y        | Y        | 386+       | Jge_rel16                                         
    | 7D cb      | JGE rel8      | Y        | Y        | Y        | 8086+      | Jge_rel8_16                                       
    | 7D cb      | JGE rel8      | Y        | Y        | N        | 386+       | Jge_rel8_32                                       
    | 7D cb      | JGE rel8      | N        | N        | Y        | X64        | Jge_rel8_64                                       
    | 0F 8C cd   | JL rel32      | Y        | Y        | N        | 386+       | Jl_rel32_32                                       
    | 0F 8C cd   | JL rel32      | N        | N        | Y        | X64        | Jl_rel32_64                                       
    | 0F 8C cw   | JL rel16      | Y        | Y        | Y        | 386+       | Jl_rel16                                          
    | 7C cb      | JL rel8       | Y        | Y        | Y        | 8086+      | Jl_rel8_16                                        
    | 7C cb      | JL rel8       | Y        | Y        | N        | 386+       | Jl_rel8_32                                        
    | 7C cb      | JL rel8       | N        | N        | Y        | X64        | Jl_rel8_64                                        
    | 0F 8E cd   | JLE rel32     | Y        | Y        | N        | 386+       | Jle_rel32_32                                      
    | 0F 8E cd   | JLE rel32     | N        | N        | Y        | X64        | Jle_rel32_64                                      
    | 0F 8E cw   | JLE rel16     | Y        | Y        | Y        | 386+       | Jle_rel16                                         
    | 7E cb      | JLE rel8      | Y        | Y        | Y        | 8086+      | Jle_rel8_16                                       
    | 7E cb      | JLE rel8      | Y        | Y        | N        | 386+       | Jle_rel8_32                                       
    | 7E cb      | JLE rel8      | N        | N        | Y        | X64        | Jle_rel8_64                                       
    | 0F 00 /6   | JMPE r/m16    | Y        | Y        | N        | IA-64      | Jmpe_rm16                                         
    | 0F 00 /6   | JMPE r/m32    | Y        | Y        | N        | IA-64      | Jmpe_rm32                                         
    | 0F B8 cd   | JMPE disp32   | Y        | Y        | N        | IA-64      | Jmpe_disp32                                       
    | 0F B8 cw   | JMPE disp16   | Y        | Y        | N        | IA-64      | Jmpe_disp16                                       
    | E9 cd      | JMP rel32     | Y        | Y        | N        | 386+       | Jmp_rel32_32                                      
    | E9 cd      | JMP rel32     | N        | N        | Y        | X64        | Jmp_rel32_64                                      
    | E9 cw      | JMP rel16     | Y        | Y        | Y        | 8086+      | Jmp_rel16                                         
    | EA cd      | JMP ptr16:1   | Y        | Y        | N        | 8086+      | Jmp_ptr1616                                       
    | EA cp      | JMP ptr16:3   | Y        | Y        | N        | 386+       | Jmp_ptr1632                                       
    | EB cb      | JMP rel8      | Y        | Y        | Y        | 8086+      | Jmp_rel8_16                                       
    | EB cb      | JMP rel8      | Y        | Y        | N        | 386+       | Jmp_rel8_32                                       
    | EB cb      | JMP rel8      | N        | N        | Y        | X64        | Jmp_rel8_64                                       
    | FF /4      | JMP r/m16     | Y        | Y        | Y        | 8086+      | Jmp_rm16                                          
    | FF /4      | JMP r/m32     | Y        | Y        | N        | 386+       | Jmp_rm32                                          
    | FF /4      | JMP r/m64     | N        | N        | Y        | X64        | Jmp_rm64                                          
    | FF /5      | JMP m16:16    | Y        | Y        | Y        | 8086+      | Jmp_m1616                                         
    | FF /5      | JMP m16:32    | Y        | Y        | Y        | 386+       | Jmp_m1632                                         
    | REX.W FF / | JMP m16:64    | N        | N        | Y        | X64        | Jmp_m1664                                         
    | 0F 85 cd   | JNE rel32     | Y        | Y        | N        | 386+       | Jne_rel32_32                                      
    | 0F 85 cd   | JNE rel32     | N        | N        | Y        | X64        | Jne_rel32_64                                      
    | 0F 85 cw   | JNE rel16     | Y        | Y        | Y        | 386+       | Jne_rel16                                         
    | 75 cb      | JNE rel8      | Y        | Y        | Y        | 8086+      | Jne_rel8_16                                       
    | 75 cb      | JNE rel8      | Y        | Y        | N        | 386+       | Jne_rel8_32                                       
    | 75 cb      | JNE rel8      | N        | N        | Y        | X64        | Jne_rel8_64                                       
    | 0F 81 cd   | JNO rel32     | Y        | Y        | N        | 386+       | Jno_rel32_32                                      
    | 0F 81 cd   | JNO rel32     | N        | N        | Y        | X64        | Jno_rel32_64                                      
    | 0F 81 cw   | JNO rel16     | Y        | Y        | Y        | 386+       | Jno_rel16                                         
    | 71 cb      | JNO rel8      | Y        | Y        | Y        | 8086+      | Jno_rel8_16                                       
    | 71 cb      | JNO rel8      | Y        | Y        | N        | 386+       | Jno_rel8_32                                       
    | 71 cb      | JNO rel8      | N        | N        | Y        | X64        | Jno_rel8_64                                       
    | 0F 8B cd   | JNP rel32     | Y        | Y        | N        | 386+       | Jnp_rel32_32                                      
    | 0F 8B cd   | JNP rel32     | N        | N        | Y        | X64        | Jnp_rel32_64                                      
    | 0F 8B cw   | JNP rel16     | Y        | Y        | Y        | 386+       | Jnp_rel16                                         
    | 7B cb      | JNP rel8      | Y        | Y        | Y        | 8086+      | Jnp_rel8_16                                       
    | 7B cb      | JNP rel8      | Y        | Y        | N        | 386+       | Jnp_rel8_32                                       
    | 7B cb      | JNP rel8      | N        | N        | Y        | X64        | Jnp_rel8_64                                       
    | 0F 89 cd   | JNS rel32     | Y        | Y        | N        | 386+       | Jns_rel32_32                                      
    | 0F 89 cd   | JNS rel32     | N        | N        | Y        | X64        | Jns_rel32_64                                      
    | 0F 89 cw   | JNS rel16     | Y        | Y        | Y        | 386+       | Jns_rel16                                         
    | 79 cb      | JNS rel8      | Y        | Y        | Y        | 8086+      | Jns_rel8_16                                       
    | 79 cb      | JNS rel8      | Y        | Y        | N        | 386+       | Jns_rel8_32                                       
    | 79 cb      | JNS rel8      | N        | N        | Y        | X64        | Jns_rel8_64                                       
    | 0F 80 cd   | JO rel32      | Y        | Y        | N        | 386+       | Jo_rel32_32                                       
    | 0F 80 cd   | JO rel32      | N        | N        | Y        | X64        | Jo_rel32_64                                       
    | 0F 80 cw   | JO rel16      | Y        | Y        | Y        | 386+       | Jo_rel16                                          
    | 70 cb      | JO rel8       | Y        | Y        | Y        | 8086+      | Jo_rel8_16                                        
    | 70 cb      | JO rel8       | Y        | Y        | N        | 386+       | Jo_rel8_32                                        
    | 70 cb      | JO rel8       | N        | N        | Y        | X64        | Jo_rel8_64                                        
    | 0F 8A cd   | JP rel32      | Y        | Y        | N        | 386+       | Jp_rel32_32                                       
    | 0F 8A cd   | JP rel32      | N        | N        | Y        | X64        | Jp_rel32_64                                       
    | 0F 8A cw   | JP rel16      | Y        | Y        | Y        | 386+       | Jp_rel16                                          
    | 7A cb      | JP rel8       | Y        | Y        | Y        | 8086+      | Jp_rel8_16                                        
    | 7A cb      | JP rel8       | Y        | Y        | N        | 386+       | Jp_rel8_32                                        
    | 7A cb      | JP rel8       | N        | N        | Y        | X64        | Jp_rel8_64                                        
    | E3 cb      | JRCXZ rel8    | N        | N        | Y        | X64        | Jrcxz_rel8_16                                     
    | E3 cb      | JRCXZ rel8    | N        | N        | Y        | X64        | Jrcxz_rel8_64                                     
    | 0F 88 cd   | JS rel32      | Y        | Y        | N        | 386+       | Js_rel32_32                                       
    | 0F 88 cd   | JS rel32      | N        | N        | Y        | X64        | Js_rel32_64                                       
    | 0F 88 cw   | JS rel16      | Y        | Y        | Y        | 386+       | Js_rel16                                          
    | 78 cb      | JS rel8       | Y        | Y        | Y        | 8086+      | Js_rel8_16                                        
    | 78 cb      | JS rel8       | Y        | Y        | N        | 386+       | Js_rel8_32                                        
    | 78 cb      | JS rel8       | N        | N        | Y        | X64        | Js_rel8_64                                        

*/

    partial class AsmExpr
    {
        [Op]
        public static JccCode jcc1(byte x, byte y)
        {
            JccCode result = 0;
            if(x > y)
                result = target_GT;
            else if(x < y)
                result = target_LT;
            else if(x == y)
                result = target_EQ;

            return result;  
        }

        [Op]
        public static JccCode jcc1_1(byte x, byte y)
        {
            if(x > y)
                return target_GT;
            else if(x < y)
                return target_LT;
            else
                return target_EQ;
        }

        [Op]
        public static JccCode jcc2(byte x, byte y)
        {
            JccCode result = 0;
            if(x >= y)
                result = target_GTEQ;
            else if(x <= y)
                result = target_LTEQ;
            else if(x != y)
                result = target_NEQ;

            return result;  
        }


        [Op]
        public static byte jcc_no_switch(byte x)
        {
            byte result = 0;
                if(x ==11)
                    result = 0b11100000;
                else if(x ==2)
                    result = 0b11100000 >> 1;
                else if(x == 13)
                    result = 0b11100000 >> 3;
                else if(x == 7)
                    result = 0b11100000 >> 4;
                else if(x == 9)
                    result = 0b11 << 1;
                else if(x == 6)
                    result = 0b11 << 2;
                else if(x == 21)
                    result = 0b11 << 3;
                else if(x == 111)
                    result = 0b11 << 4;
            return result;             
        }

        const string data = "0f 1f 44 00 00 33 c0 0f b6 d1 83 fa 0d 77 25 83 fa 02 74 33 83 c2 fa 83 fa 07 77 5a 8b d2 48 8d 0d 53 00 00 00 8b 0c 91 4c 8d 05 d6 ff ff ff 49 03 c8 ff e1 83 fa 15 74 31 83 fa 6f 74 33 eb 36 b8 e0 00 00 00 eb 2f b8 70 00 00 00 eb 28 b8 1c 00 00 00 eb 21 b8 0e 00 00 00 eb 1a b8 06 00 00 00 eb 13 b8 0c 00 00 00 eb 0c b8 18 00 00 00 eb 05 b8 30 00 00 00 c3 00 5e 00 00 00 50 00 00 00 71 00 00 00 57 00 00 00 71 00 00 00 3b 00 00 00 71 00 00 00 49 00 00 00 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00";

        [Op]
        public static byte jcc_switch(byte x)
        {
            byte result = 0;
            switch(x)
            {
                case 11:
                    result = 0b11100000;
                    break;
                case 2:
                    result = 0b11100000 >> 1;
                    break;
                case 13:
                    result = 0b11100000 >> 3;
                    break;
                case 7:
                    result = 0b11100000 >> 4;
                    break;
                case 9:
                    result = 0b11 << 1;
                    break;
                case 6:
                    result = 0b11 << 2;
                    break;
                case 21:
                    result = 0b11 << 3;
                    break;
                case 111:
                    result = 0b11 << 4;
                    break;
            }
            return result;             
        }

        static JccCode target_GT
            =>  NLE;

        static JccCode target_LT
            =>  L;

        static JccCode target_EQ
            =>  E;            

        static JccCode target_GTEQ
            =>  NL;

        static JccCode target_LTEQ
            =>  LE;

        static JccCode target_NEQ
            =>  NE;            
    }
}